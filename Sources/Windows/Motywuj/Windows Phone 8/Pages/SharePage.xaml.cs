using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Motywator.Motywator;

namespace Motywator.Pages
{
    public partial class SharePage : PhoneApplicationPage
    {
        private CitationManagement _citation = CitationManagement.Instatnce;

        public SharePage()
        {
            InitializeComponent();
        }

        private void btnShareEmail_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            _citation.ShareViaEmail();
            if (NavigationService.CanGoBack) NavigationService.GoBack();
        }

        private void btnShareSms_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            _citation.ShareViaSms();
            if (NavigationService.CanGoBack) NavigationService.GoBack();
        }

        private void btnShareStatus_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            _citation.ShareYourStatus();
            if (NavigationService.CanGoBack) NavigationService.GoBack();
        }
    }
}