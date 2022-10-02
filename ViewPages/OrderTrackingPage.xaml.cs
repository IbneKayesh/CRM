using CRM.ViewModels;

namespace CRM.ViewPages;

public partial class OrderTrackingPage : ContentPage
{
	public OrderTrackingPage(OrderTrackingViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;	
	}
}