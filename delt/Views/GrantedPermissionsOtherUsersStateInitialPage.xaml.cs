using System;
using System.Collections.Generic;
using delt.ViewModels;
using Xamarin.Forms;

namespace delt.Views
{
	public partial class GrantedPermissionsOtherUsersStateInitialPage : ContentPage
	{
		public GrantedPermissionsOtherUsersStateInitialPage()
		{
			InitializeComponent();
			this.BindingContext = new GrantedPermissionsOtherUsersStateInitialPageModel();
		}
	}
}
