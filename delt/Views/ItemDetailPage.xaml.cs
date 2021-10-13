using System.ComponentModel;
using Xamarin.Forms;
using delt.ViewModels;

namespace delt.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}
