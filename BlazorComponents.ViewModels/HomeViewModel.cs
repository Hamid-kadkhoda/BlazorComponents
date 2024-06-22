using BlazorComponents.ViewModels.Common;

namespace BlazorComponents.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {

        public override void OnViewModelInitialized()
        {
            Console.WriteLine("Home View model init...");
        }
    }
}
