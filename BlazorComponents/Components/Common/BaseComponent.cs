using Microsoft.AspNetCore.Components;
using System.ComponentModel;

namespace BlazorComponents.Components.Common
{
    public class BaseComponent<TViewModel> : ComponentBase, INotifyPropertyChanged
    {
        [Inject] public TViewModel? ViewModel { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
