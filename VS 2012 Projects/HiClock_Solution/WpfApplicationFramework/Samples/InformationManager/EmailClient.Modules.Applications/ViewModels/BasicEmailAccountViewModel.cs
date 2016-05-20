﻿using System.ComponentModel.Composition;
using System.Waf.Applications;
using Waf.InformationManager.EmailClient.Modules.Applications.Views;
using Waf.InformationManager.EmailClient.Modules.Domain.Emails;
using Waf.InformationManager.EmailClient.Modules.Domain.AccountSettings;

namespace Waf.InformationManager.EmailClient.Modules.Applications.ViewModels
{
    [Export, PartCreationPolicy(CreationPolicy.NonShared)]
    public class BasicEmailAccountViewModel : ViewModel<IBasicEmailAccountView>
    {
        private EmailAccount emailAccount;
        private bool isPop3Checked;
        private bool isExchangeChecked;

        
        [ImportingConstructor]
        public BasicEmailAccountViewModel(IBasicEmailAccountView view) : base(view)
        {
            isPop3Checked = true;
        }


        public EmailAccount EmailAccount
        {
            get { return emailAccount; }
            set
            {
                if (emailAccount != value)
                {
                    emailAccount = value;
                    if (emailAccount.EmailAccountSettings is Pop3Settings)
                    {
                        IsPop3Checked = true;
                    }
                    else if (emailAccount.EmailAccountSettings is ExchangeSettings)
                    {
                        IsExchangeChecked = true;
                    }
                    RaisePropertyChanged("EmailAccount");
                }
            }
        }

        public bool IsPop3Checked
        {
            get { return isPop3Checked; }
            set 
            {
                if (isPop3Checked != value)
                {
                    isPop3Checked = value;
                    IsExchangeChecked = !value;
                    RaisePropertyChanged("IsPop3Checked");
                }
            }
        }

        public bool IsExchangeChecked
        {
            get { return isExchangeChecked; }
            set 
            {
                if (isExchangeChecked != value)
                {
                    isExchangeChecked = value;
                    IsPop3Checked = !value;
                    RaisePropertyChanged("IsExchangeChecked");
                }
            }
        }
    }
}
