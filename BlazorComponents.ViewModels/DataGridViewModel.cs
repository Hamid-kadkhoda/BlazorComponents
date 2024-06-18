using BlazorComponents.ViewModels.Common;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BlazorComponents.ViewModels
{
    public partial class DataGridViewModel: ViewModelBase
    {

        public DataGridViewModel()
        {
            
        }

        [ObservableProperty]
        private List<object>? _DataSource;
    }
}
