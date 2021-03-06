﻿using Prism.Mvvm;
using TheMovie.Interfaces;

using Xamarin.Forms;

namespace TheMovie.ViewModels
{
    public class BaseViewModel : BindableBase
    {
        protected IApiService ApiService => DependencyService.Get<IApiService>();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;

        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }        
    }
}
