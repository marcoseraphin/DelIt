using System;
using System.Collections.Generic;
using delt.ViewModels;
using Xamarin.Forms;

namespace delt.Views
{
	public partial class PermissionsGrantedSelfPage : ContentPage
	{
		public PermissionsGrantedSelfPage()
		{
			InitializeComponent();
			this.BindingContext = new PermissionsGrantedSelfPageModel();

		}
	}
}
