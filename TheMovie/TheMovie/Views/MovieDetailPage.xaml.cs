using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheMovie.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieDetailPage : ContentPage
    {       
        public MovieDetailPage()
        {
            InitializeComponent();

            VideosListView.ItemSelected += (sender, e) => {
                ((ListView)sender).SelectedItem = null;
            };
        }      
    }
}
