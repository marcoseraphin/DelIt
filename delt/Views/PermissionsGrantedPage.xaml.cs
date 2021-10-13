using System;
using System.Collections.Generic;
using delt.ViewModels;
using Xamarin.Forms;

namespace delt.Views
{
	public partial class PermissionsGrantedPage : ContentPage
	{
		public PermissionsGrantedPage()
		{
			InitializeComponent();
			this.BindingContext = new PermissionsGrantedPageModel();
		}
	}
}
