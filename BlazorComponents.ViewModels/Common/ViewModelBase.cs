﻿
using CommunityToolkit.Mvvm.ComponentModel;

namespace BlazorComponents.ViewModels.Common
{
    public abstract class ViewModelBase: ObservableObject
    {
        public virtual void OnViewModelInitialized()
        {

        }
    }
}
