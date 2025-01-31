using BadgerClan.Maui.ViewModels;
namespace BadgerClan.Maui;

public partial class MainPage : ContentPage
{
    //HttpClient client;

    public MainPage(/*HttpClient client*/)
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel(new HttpClient());
        //this.client = client;
    }


    private void MoveLeftButton_Clicked(object sender, EventArgs e)
    {
        //client.PostAsync("MoveLeft", null);
    }

    private void MoveUpLeftButton_Clicked(object sender, EventArgs e)
    {
        //client.PostAsync("MoveUpLeft", null);
    }

    private void MoveUpRightButton_Clicked(object sender, EventArgs e)
    {
        //client.PostAsync("MoveUpRight", null);
    }

    private void MoveRightButton_Clicked(object sender, EventArgs e)
    {
        //client.PostAsync("MoveRight", null);
    }

    private void MoveDownLeft_Clicked(object sender, EventArgs e)
    {
        //client.PostAsync("MoveDownLeft", null);
    }

    private void MoveDownRightButton_Clicked(object sender, EventArgs e)
    {
        //client.PostAsync("MoveDownRight", null);
    }
}
