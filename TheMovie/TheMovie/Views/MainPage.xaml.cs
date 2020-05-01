using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheMovie.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
            
            ItemsListView.ItemSelected += (sender, e) => {
                ((ListView)sender).SelectedItem = null;
            };
        }        
    }
}
