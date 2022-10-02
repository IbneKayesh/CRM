using CommunityToolkit.Mvvm.Input;

namespace CRM.ViewModels
{
    public partial class OrderTrackingViewModel : BaseViewModel
    {
        public OrderTrackingViewModel()
        {
            Title = "Order Tracking";
        }
        //Property
        public string order_no { get; set; }
        //Property


        [RelayCommand]
        async void TrackOrderNo()
        {
            //validations
            if (string.IsNullOrWhiteSpace(order_no) )
            {
                await Shell.Current.CurrentPage.DisplayAlert("Error", "Order No is Required", "Ok");
                return;
            }
            await Shell.Current.CurrentPage.DisplayAlert("Tracking Info", $"Your Order [{order_no}] - will delivered soon to your nearest branch", "Ok");
        }
    }
}
