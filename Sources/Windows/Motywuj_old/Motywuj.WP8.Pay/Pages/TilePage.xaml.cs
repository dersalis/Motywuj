using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO.IsolatedStorage;

using Motywator.Motywator;
using Atrx.WindowsPhone.Motywuj;
using Motywator.Resources;

namespace Motywator.Pages
{
    public partial class TilePage : PhoneApplicationPage
    {
        // Instancja motywuj
        private CitationManagement _citations = CitationManagement.Instatnce;

        public TilePage()
        {
            InitializeComponent();

            // DataConstext
            DataContext = _citations;

            // Dodaj appBar
            ApplicationBar = CreateTilePageAppBar();
        }


        //
        // Tworzy ApplicationBar dla strony Widok cytatu
        //
        private ApplicationBar CreateTilePageAppBar()
        {
            // Nowy AppBar
            ApplicationBar newAppBar = new ApplicationBar();

            //ustawienia paska
            newAppBar.Mode = ApplicationBarMode.Default;
            newAppBar.Opacity = 0.75;
            newAppBar.IsVisible = true;
            newAppBar.IsMenuEnabled = true;
            newAppBar.ForegroundColor = Colors.White;
            newAppBar.BackgroundColor = Color.FromArgb(255, 54, 89, 14);


            // Przycisk dodawania do ulubionych
            ApplicationBarIconButton btnOk = new ApplicationBarIconButton();
            btnOk.IconUri = new Uri("/Toolkit.Content/ApplicationBar.Check.png", UriKind.Relative);
            btnOk.Text = AppResources.ButtonOk;
            btnOk.Click += new EventHandler(btnOk_Click);
            newAppBar.Buttons.Add(btnOk);

            // Przycisk dzielenia się cytatem
            ApplicationBarIconButton btnCancel = new ApplicationBarIconButton();
            btnCancel.IconUri = new Uri("/Toolkit.Content/ApplicationBar.Cancel.png", UriKind.Relative);
            btnCancel.Text = AppResources.ButtonAnuluj;
            btnCancel.Click += new EventHandler(btnCancel_Click);
            newAppBar.Buttons.Add(btnCancel);

            // Zwróć AppBar
            return newAppBar;
        }


        // Zamyka stronę
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Opuść stronę
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }


        // Dodaje kafelek i zamyka stronę
        private void btnOk_Click(object sender, EventArgs e)
        {
            // Dodaj kafelek
            TileManagement.GenerateTile(stpTilePanel, _citations.ViewCitation.Id.ToString());
            // Opuść stronę
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }
    }
}