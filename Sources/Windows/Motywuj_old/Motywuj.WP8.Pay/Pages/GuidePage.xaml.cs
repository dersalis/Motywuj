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

namespace Motywator
{
	public partial class GuidePage : PhoneApplicationPage
	{
		private CitationManagement _citation = CitationManagement.Instatnce;

		public GuidePage()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, RoutedEventArgs e)
		{
			if (NavigationService.CanGoBack) NavigationService.GoBack();
		}

		protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
		{
			//base.OnNavigatingFrom(e);
			_citation.GuideStart = false;
		}
	}
}