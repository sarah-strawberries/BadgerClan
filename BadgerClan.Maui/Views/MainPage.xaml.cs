using BadgerClan.Maui.ViewModels;
namespace BadgerClan.Maui;

public partial class MainPage : ContentPage
{
    HttpClient client;

    public MainPage()
    {
        InitializeComponent();
        client = new HttpClient();
        // client.BaseAddress = new Uri("http://localhost:5043"); // change localhost to Azure path when hosted
        BindingContext = new MainPageViewModel(client);
    }
}
