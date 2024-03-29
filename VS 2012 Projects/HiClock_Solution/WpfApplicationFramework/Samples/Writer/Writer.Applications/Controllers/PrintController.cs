﻿using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.IO.Packaging;
using System.Waf.Applications;
using System.Windows.Documents;
using System.Windows.Xps.Packaging;
using System.Windows.Xps.Serialization;
using Waf.Writer.Applications.Documents;
using Waf.Writer.Applications.Services;
using Waf.Writer.Applications.ViewModels;
using Waf.Writer.Applications.Views;

namespace Waf.Writer.Applications.Controllers
{
    /// <summary>
    /// Responsible for the print related commands and the PrintPreview.
    /// </summary>
    [Export]
    internal class PrintController : Controller
    {
        private const string PackagePath = "pack://temp.xps";
        
        private readonly CompositionContainer container;
        private readonly IShellService shellService;
        private readonly ShellViewModel shellViewModel;
        private readonly MainViewModel mainViewModel;
        private readonly IFileService fileService;
        private readonly IPrintDialogService printDialogService;
        private readonly DelegateCommand printPreviewCommand;
        private readonly DelegateCommand printCommand;
        private readonly DelegateCommand closePrintPreviewCommand;
        private PrintPreviewViewModel printPreviewViewModel;
        private Package package;
        private XpsDocument xpsDocument;

        
        [ImportingConstructor]
        public PrintController(CompositionContainer container, IShellService shellService, ShellViewModel shellViewModel, 
            MainViewModel mainViewModel, IFileService fileService, IPrintDialogService printDialogService)
        {
            this.container = container;
            this.shellService = shellService;
            this.shellViewModel = shellViewModel;
            this.mainViewModel = mainViewModel;
            this.fileService = fileService;
            this.printDialogService = printDialogService;
            this.printPreviewCommand = new DelegateCommand(ShowPrintPreview, CanPrintDocument);
            this.printCommand = new DelegateCommand(PrintDocument, CanPrintDocument);
            this.closePrintPreviewCommand = new DelegateCommand(ClosePrintPreview);

            AddWeakEventListener(fileService, FileServicePropertyChanged);
        }


        public void Initialize()
        {
            mainViewModel.PrintPreviewCommand = printPreviewCommand;
            mainViewModel.PrintCommand = printCommand;            
        }

        public void Shutdown()
        {
            if (xpsDocument != null)
            {
                xpsDocument.Close();
            }
        }

        private bool CanPrintDocument()
        {
            return fileService.ActiveDocument != null;
        }

        private void ShowPrintPreview()
        {
            // We have to clone the FlowDocument before we use different pagination settings for the export.        
            RichTextDocument document = fileService.ActiveDocument as RichTextDocument;
            FlowDocument clone = document.CloneContent();
            clone.ColumnWidth = double.PositiveInfinity;

            // Create a package for the XPS document
            MemoryStream packageStream = new MemoryStream();
            package = Package.Open(packageStream, FileMode.Create, FileAccess.ReadWrite);

            // Create a XPS document with the path "pack://temp.xps"
            PackageStore.AddPackage(new Uri(PackagePath), package);
            xpsDocument = new XpsDocument(package, CompressionOption.SuperFast, PackagePath);
            
            // Serialize the XPS document
            XpsSerializationManager serializer = new XpsSerializationManager(new XpsPackagingPolicy(xpsDocument), false);
            DocumentPaginator paginator = ((IDocumentPaginatorSource)clone).DocumentPaginator;
            serializer.SaveAsXaml(paginator);

            // Get the fixed document sequence
            FixedDocumentSequence documentSequence = xpsDocument.GetFixedDocumentSequence();
            
            // Create and show the print preview view
            printPreviewViewModel = new PrintPreviewViewModel(
                container.GetExportedValue<IPrintPreviewView>(), shellService, documentSequence);
            printPreviewViewModel.CloseCommand = closePrintPreviewCommand;
            shellViewModel.ContentView = printPreviewViewModel.View;
        }

        private void PrintDocument()
        {
            if (printDialogService.ShowDialog())
            {
                // We have to clone the FlowDocument before we use different pagination settings for the export.        
                RichTextDocument document = (RichTextDocument)fileService.ActiveDocument;
                FlowDocument clone = document.CloneContent();

                printDialogService.PrintDocument(((IDocumentPaginatorSource)clone).DocumentPaginator, 
                    fileService.ActiveDocument.FileName);
            }
        }

        private void ClosePrintPreview()
        {
            // Remove the package from the store
            PackageStore.RemovePackage(new Uri(PackagePath));

            xpsDocument.Close();
            package.Close();

            shellViewModel.ContentView = mainViewModel.View;
        }

        private void FileServicePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ActiveDocument")
            {
                printPreviewCommand.RaiseCanExecuteChanged();
                printCommand.RaiseCanExecuteChanged();
            }
        }
    }
}
