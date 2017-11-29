using System;
using System.ComponentModel;

namespace OpenPdf
{
    public class WebViewPageViewModel : INotifyPropertyChanged
    {

        public bool IsPdf { get; set; }
        public string Uri { get; set; }

        public WebViewPageViewModel(string uri, bool isPdf)
        {
            Uri = uri;
            IsPdf = isPdf;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
