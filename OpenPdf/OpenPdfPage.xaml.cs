using Xamarin.Forms;

namespace OpenPdf
{
    public partial class OpenPdfPage : ContentPage
    {
        public OpenPdfPage()
        {
            InitializeComponent();
        }

        void OpenPdf(object sender, System.EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new WebViewPage("http://media.wuerth.com/stmedia/shop/catalogpages/LANG_it/14314732.pdf", true));
        }

        void OpenJpg(object sender, System.EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new WebViewPage("https://media.wuerth.com/stmedia/shop/348px/13367514.jpg", false));
        }
    }
}
