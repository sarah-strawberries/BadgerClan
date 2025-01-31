using BadgerClan.Maui.ViewModels;
namespace BadgerClan.Maui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel(new HttpClient());
    }


    private void MoveLeftButton_Clicked(object sender, EventArgs e)
    {

    }

    private void MoveUpLeftButton_Clicked(object sender, EventArgs e)
    {

    }

    private void MoveUpLeftButton_Clicked_1(object sender, EventArgs e)
    {

    }

    private void MoveUpRightButton_Clicked(object sender, EventArgs e)
    {

    }

    private void MoveRightButton_Clicked(object sender, EventArgs e)
    {

    }

    private void MoveDownRightButton_Clicked(object sender, EventArgs e)
    {

    }

    private void MoveDownLeft_Clicked(object sender, EventArgs e)
    {

    }
}
