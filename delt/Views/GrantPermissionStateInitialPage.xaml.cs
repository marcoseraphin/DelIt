using System;
using System.Collections.Generic;
using delt.ViewModels;
using Xamarin.Forms;

namespace delt.Views
{
	public partial class GrantPermissionStateInitialPage : ContentPage
	{
		public GrantPermissionStateInitialPage()
		{
            InitializeComponent();
			this.BindingContext = new GrantPermissionStateInitialPageModel();
		}
	}
}
