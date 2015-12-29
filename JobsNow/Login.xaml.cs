using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JobsNow
{
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

		async void OnLogin(object sender, EventArgs e)
		{
			await DisplayAlert ("Clicked", "He clickado en login", "Cancel");
		}
	}
}

