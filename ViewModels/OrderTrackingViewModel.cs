using CRM.Services.Db;

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
    }
}
