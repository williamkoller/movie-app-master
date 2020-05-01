using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheMovie.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchMoviesPage : ContentPage
    {        
        public SearchMoviesPage()
        {
            InitializeComponent();            

            ItemsListView.ItemSelected += (sender, e) => {
                ((ListView)sender).SelectedItem = null;
            };

            if (Device.RuntimePlatform == Device.Android)
            {
                SearchBar.HeightRequest = 40;
            }
        }        

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (string.IsNullOrEmpty(SearchBar.Text))
            {
                SearchBar.Focus();
            }            
        }        
    }
}