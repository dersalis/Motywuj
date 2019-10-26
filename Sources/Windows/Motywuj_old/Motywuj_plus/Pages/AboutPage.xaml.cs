using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Microsoft.Phone.Tasks;
using Motywator.Resources;

namespace Motywator.Pages
{
    public partial class AboutPage : PhoneApplicationPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        
        //
        // Naciśnięcie adresu email
        //
        private void txtSendEmail_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Wyślij email
            SendEmail();
        }

        //
        // Naciśnięcie przycisku 
        //
        private void btnGuide_Click(object sender, RoutedEventArgs e)
        {
            // Przełącz na nową stronę i przekaż parametr - wskazaną notatkę
            NavigationService.Navigate(new Uri("/Pages/GuidePage.xaml", UriKind.Relative));
        }

        private void btnReview_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceReviewTask marketplaceReviewTask = new MarketplaceReviewTask();

            marketplaceReviewTask.Show();
        }

        private void btnStore_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceSearchTask marketplaceSearchTask = new MarketplaceSearchTask();
            marketplaceSearchTask.SearchTerms = "Damian Ruta";

            marketplaceSearchTask.Show();
        }

        private void btnEmail_Click(object sender, RoutedEventArgs e)
        {
            SendEmail();
        }

        //
        // Tworzy i wysyła wiadomość email
        //
        private void SendEmail()
        {
            /*
             * CEL:
             * Tworzy i wysyła wiadomość email
             */
            // Utwórz zadanie
            EmailComposeTask emailComposeTask = new EmailComposeTask();
            // Ustaw temat
            emailComposeTask.Subject = AppResources.TextEmailSubiect;
            //emailComposeTask.Body = "message body";
            // Dodaj adres
            emailComposeTask.To = "mobileapps@aturex.pl";
            //emailComposeTask.Cc = "cc@example.com";
            //emailComposeTask.Bcc = "bcc@example.com";

            // Utwórz okno redagowania wiadomości
            emailComposeTask.Show();
        }
    }
}