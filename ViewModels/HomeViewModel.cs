using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace CRM.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        #region Commands
        public HomeViewModel()
        {
            Title = "Welcom to CRM";

        }
        #endregion
    }
}
