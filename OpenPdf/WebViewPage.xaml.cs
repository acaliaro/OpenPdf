using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace OpenPdf
{
    public partial class WebViewPage : ContentPage, INotifyPropertyChanged
    {

        public WebViewPage(string uri, bool isPdf)
        {
            InitializeComponent();
            this.BindingContext = new WebViewPageViewModel(uri, isPdf);
        }
    }
}
