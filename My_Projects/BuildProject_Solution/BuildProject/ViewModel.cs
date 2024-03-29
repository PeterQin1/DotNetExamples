using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;
using BuildProject.Properties;

namespace BuildProject
{
    [Serializable]
    public class ViewModel : INotifyPropertyChanged
    {

        private string FSolution;
        public const string C_Solution = "Solution";
        public string Solution
        {
            get { return FSolution; }
            set
            {
                if (FSolution != value)
                {
                    FSolution = value;
                    RaisePropertyChanged(C_Solution);
                }                
            }
        }

        private string FSetupProject;
        public const string C_SetupProject = "SetupProject";
        public string SetupProject
        {
            get { return FSetupProject; }
            set
            {
                if (FSetupProject != value)
                {
                    FSetupProject = value;
                    RaisePropertyChanged(C_SetupProject);
                }
            }
        }

        private string FSetupSolution;
        public const string C_SetupSolution = "SetupSolution";
        public string SetupSolution
        {
            get { return FSetupSolution; }
            set
            {
                if (FSetupSolution != value)
                {
                    FSetupSolution = value;
                    RaisePropertyChanged(C_SetupSolution);
                }
            }
        }

        private string FSetupOutput;
        public const string C_SetupOutput = "SetupOutput";
        public string SetupOutput
        {
            get { return FSetupOutput; }
            set
            {
                if (FSetupOutput != value)
                {
                    FSetupOutput = value;
                    RaisePropertyChanged(C_SetupOutput);
                }
            }
        }

        private string FSetupProjOriginalOutput = Resources.SetupProjOriginalOutput;
        public const string C_SetupProjOriginalOutput = "SetupProjOriginalOutput";
        public string SetupProjOriginalOutput
        {
            get { return FSetupProjOriginalOutput; }
            set
            {
                if (FSetupProjOriginalOutput != value)
                {
                    FSetupProjOriginalOutput = value;
                    RaisePropertyChanged(C_SetupProjOriginalOutput);
                }
            }
        }

        private string FBuildSolutionCmd = Resources.BuildSolutionCmd;
        public const string C_BuildSolutionCmd = "BuildSolutionCmd";
        public string BuildSolutionCmd
        {
            get { return FBuildSolutionCmd; }
            set
            {
                if (FBuildSolutionCmd != value)
                {
                    FBuildSolutionCmd = value;
                    RaisePropertyChanged(C_BuildSolutionCmd);
                }
            }
        }

        private string FBuildProjectCmd = Resources.BuildProjectCmd;
        public const string C_BuildProjectCmd = "BuildProjectCmd";
        public string BuildProjectCmd
        {
            get { return FBuildProjectCmd; }
            set
            {
                if (FBuildProjectCmd != value)
                {
                    FBuildProjectCmd = value;
                    RaisePropertyChanged(C_BuildProjectCmd);
                }
            }
        }

        private string FBuildConfig = Resources.BuildConfig;
        public const string C_BuildConfig = "BuildConfig";
        public string BuildConfig
        {
            get { return FBuildConfig; }
            set
            {
                if (FBuildConfig != value)
                {
                    FBuildConfig = value;
                    RaisePropertyChanged(C_BuildConfig);
                }
            }
        }

        private string FDevenvFolder = Resources.DevenvFolder;
        public const string C_DevenvFolder = "DevenvFolder";
        public string DevenvFolder
        {
            get { return FDevenvFolder; }
            set
            {
                if (FDevenvFolder != value)
                {
                    FDevenvFolder = value;
                    RaisePropertyChanged(C_DevenvFolder);
                }
            }
        }

        private string FDevenvFolder2005 = Resources.DevenvFolder2005;
        public const string C_DevenvFolder2005 = "DevenvFolder2005";
        public string DevenvFolder2005
        {
            get { return FDevenvFolder2005; }
            set
            {
                if (FDevenvFolder2005 != value)
                {
                    FDevenvFolder2005 = value;
                    RaisePropertyChanged(C_DevenvFolder2005);
                }
            }
        }

        private string FDevenvFolder2008 = Resources.DevenvFolder2008;
        public const string C_DevenvFolder2008 = "DevenvFolder2008";
        public string DevenvFolder2008
        {
            get { return FDevenvFolder2008; }
            set
            {
                if (FDevenvFolder2008 != value)
                {
                    FDevenvFolder2008 = value;
                    RaisePropertyChanged(C_DevenvFolder2008);
                }
            }
        }

        private string FDevenvFolder2010 = Resources.DevenvFolder2010;
        public const string C_DevenvFolder2010 = "DevenvFolder2010";
        public string DevenvFolder2010
        {
            get { return FDevenvFolder2010; }
            set
            {
                if (FDevenvFolder2010 != value)
                {
                    FDevenvFolder2010 = value;
                    RaisePropertyChanged(C_DevenvFolder2010);
                }
            }
        }

        private string FDevenvFolder2012 = Resources.DevenvFolder2012;
        public const string C_DevenvFolder2012 = "DevenvFolder2012";
        public string DevenvFolder2012
        {
            get { return FDevenvFolder2012; }
            set
            {
                if (FDevenvFolder2012 != value)
                {
                    FDevenvFolder2012 = value;
                    RaisePropertyChanged(C_DevenvFolder2012);
                }
            }
        }

        BindingList<TAssemblyInfo> FAssemblyInfoSource = new BindingList<TAssemblyInfo>();

        public BindingList<TAssemblyInfo> AssemblyInfoSource
        {
            get { return FAssemblyInfoSource; }
        }

        BindingList<ProjectInfo> FProjects = new BindingList<ProjectInfo>();
        [XmlIgnore]
        public BindingList<ProjectInfo> Projects
        {
            get { return FProjects; }
        }

        public ViewModel()
        {
            
        }

        public void AddProject(string aName)
        {
            ProjectInfo proj = new ProjectInfo(aName);
            Projects.Add(proj);
        }

        public void IncludeOrExcludeProject(ProjectInfo aProj)
        {
            aProj.Include = !aProj.Include;
        }

        public void RemoveProject(ProjectInfo aProj)
        {
            Projects.Remove(aProj);
        }

        public void AddAssemblyInfo(string aName, string aValue)
        {
            TAssemblyInfo assembly = new TAssemblyInfo();
            assembly.InfoName = aName;
            assembly.InfoValue = aValue;
            if (AssemblyInfoSource.Contains(assembly) == false)
            {
                AssemblyInfoSource.Add(assembly);
            }
        }

        public void RemoveAssemblyInfo(string aName)
        {
            TAssemblyInfo assembly = new TAssemblyInfo();
            assembly.InfoName = aName;
            int index = AssemblyInfoSource.IndexOf(assembly);
            if (index >= 0)
            {
                AssemblyInfoSource.RemoveAt(index);
            }
        }

        public void RemoveAssemblyInfo(TAssemblyInfo aAssembly)
        {
            AssemblyInfoSource.Remove(aAssembly);
        }

        public void UpdateAsseblyInfo(string aName, string aValue)
        {
            TAssemblyInfo assembly = new TAssemblyInfo();
            assembly.InfoName = aName;
            assembly.InfoValue = aValue;
            int index = AssemblyInfoSource.IndexOf(assembly);
            if (index >= 0)
            {
                AssemblyInfoSource[index].InfoValue = aValue;
            }
            else
            {
                AssemblyInfoSource.Add(assembly);
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        private void RaisePropertyChanged(string aPropName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(aPropName));
            }
        }

        private string FRootDirectory = null;
        private string RootDirectory
        {
            get
            {
                if (FRootDirectory == null || string.IsNullOrEmpty(FRootDirectory))
                {
                    FRootDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    if (Directory.Exists(FRootDirectory) == false)
                    {
                        Directory.CreateDirectory(FRootDirectory);
                    }
                }
                return FRootDirectory;
            }
        }

        private string DataPath
        {
            get
            {
                return Path.Combine(RootDirectory, "BuildSetting.xml");
            }
        }

        public void Load()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ViewModel));
            if (File.Exists(DataPath))
            {
                Stream stream = new FileStream(DataPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                try
                {
                    ViewModel vm = xs.Deserialize(stream) as ViewModel;
                    Update(vm);                   
                }
                finally
                {
                    stream.Close();
                }    
            }
            //Default
            if (this.AssemblyInfoSource.Count == 0)
            {
                TAssemblyInfo assembly;

                assembly = new TAssemblyInfo();
                assembly.InfoName = "AssemblyCompany";
                assembly.InfoValue = "Peter.Inc";
                AssemblyInfoSource.Add(assembly);

                assembly = new TAssemblyInfo();
                assembly.InfoName = "AssemblyCopyright";
                assembly.InfoValue = "Copyright © Peter.Inc 2013";
                AssemblyInfoSource.Add(assembly);

                assembly = new TAssemblyInfo();
                assembly.InfoName = "AssemblyVersion";
                assembly.InfoValue = "1.0.0.1";
                AssemblyInfoSource.Add(assembly);

                assembly = new TAssemblyInfo();
                assembly.InfoName = "AssemblyFileVersion";
                assembly.InfoValue = "1.0.0.1";
                AssemblyInfoSource.Add(assembly);
            }
        }

        public void Save()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ViewModel));
            Stream stream = new FileStream(DataPath, FileMode.Create, FileAccess.Write, FileShare.Read);
            try
            {
                xs.Serialize(stream, this);
            }
            finally
            {
                stream.Close();
            }
            
            
        }

        public void Update(ViewModel aVM)
        {
            this.Solution = aVM.Solution;
            this.SetupProject = aVM.SetupProject;
            this.SetupSolution = aVM.SetupSolution;
            this.SetupOutput = aVM.SetupOutput;
            this.SetupProjOriginalOutput = aVM.SetupProjOriginalOutput;
            this.BuildSolutionCmd = aVM.BuildSolutionCmd;
            this.BuildProjectCmd = aVM.BuildProjectCmd;
            this.BuildConfig = aVM.BuildConfig;
            this.DevenvFolder = aVM.DevenvFolder;
            this.AssemblyInfoSource.Clear();
            foreach (TAssemblyInfo var in aVM.AssemblyInfoSource)
            {
                this.AssemblyInfoSource.Add(var);
            }
        }
    }
}
