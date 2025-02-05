﻿using BadgerClan.Maui.ViewModels;
namespace BadgerClan.Maui;

public partial class MainPage : ContentPage
{
    HttpClient client;

    public MainPage()
    {
        InitializeComponent();
        client = new HttpClient();
        BindingContext = new MainPageViewModel(client);
    }

    #region Event Handlers
        private async void MoveLeftButton_Clicked(object sender, EventArgs e)
    {
        await MoveLeft();
    }

    private async void MoveUpLeftButton_Clicked(object sender, EventArgs e)
    {
        await MoveUpLeft();
    }

    private async void MoveUpRightButton_Clicked(object sender, EventArgs e)
    {
        await MoveUpRight();
    }

    private async void MoveRightButton_Clicked(object sender, EventArgs e)
    {
        await MoveUpRight();
    }

    private async void MoveDownLeft_Clicked(object sender, EventArgs e)
    {
        await MoveUpRight();
    }

    private async void MoveDownRightButton_Clicked(object sender, EventArgs e)
    {
        await MoveDownRight();
    }
    #endregion

    #region Methods
    public async Task MoveLeft()
    {
        await client.PostAsync("MoveLeft", null);
    }

    public async Task MoveUpLeft()
    {
        await client.PostAsync("MoveUpLeft", null);
    }

    public async Task MoveRight()
    {
        await client.PostAsync("MoveRight", null);
    }

    public async Task MoveUpRight()
    {
        await client.PostAsync("MoveUpRight", null);
    }

    public async Task MoveDownLeft()
    {
        await client.PostAsync("MoveDownLeft", null);
    }

    public async Task MoveDownRight()
    {
        await client.PostAsync("MoveDownRight", null);
    }
    #endregion
}
