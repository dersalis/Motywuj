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
using Motywator.Resources;

namespace Motywator.Pages
{
    public partial class SettingsPage : PhoneApplicationPage
    {
        public SettingsPage()
        {
            InitializeComponent();

            // Dodaj appBar
            ApplicationBar = CreateSettingsPageAppBar();
        }

        //
        // Tworzy ApplicationBar dla strony Ustawienia
        //
        private ApplicationBar CreateSettingsPageAppBar()
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}