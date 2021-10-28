using System;
using System.Collections.Generic;
using delt.ViewModels;
using Xamarin.Forms;

namespace delt.Views
{
	public partial class GrantedPermissionsStateInitialPage : ContentPage
	{
		public GrantedPermissionsStateInitialPage()
		{
            InitializeComponent();
			this.BindingContext = new GrantedPermissionsStateInitialPageModel();
		}
	}
}
