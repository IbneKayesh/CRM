using CRM.ViewModels;


namespace CRM.ViewPages;

public partial class ChangePswdPage : ContentPage
{
	public ChangePswdPage(ChangePswdViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}