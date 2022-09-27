using CommunityToolkit.Mvvm.ComponentModel;

namespace CRM.ViewModels
{
    public partial class BaseViewModel:ObservableObject
    {
        [ObservableProperty]
        private bool _isBusy;


        [ObservableProperty]
        private string _title;
    }
}
