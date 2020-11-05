using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicTac
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new Tic();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
