using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
//using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.Input;

namespace BadgerClan.Maui.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        HttpClient client;
        public ICommand MoveLeftCommand { get; }
        public ICommand MoveUpLeftCommand { get; }
        public ICommand MoveDownLeftCommand { get; }
        public ICommand MoveRightCommand { get; }
        public ICommand MoveUpRightCommand { get; }
        public ICommand MoveDownRightCommand { get; }
        public MainPageViewModel(HttpClient client)
        {
            this.client = client;

            //MoveLeftCommand = new AsyncCommand(MoveLeft);
            //MoveUpLeftCommand = new AsyncCommand(MoveUpLeft);
            //MoveDownLeftCommand = new AsyncCommand(MoveDownLeft);
            //MoveRightCommand = new AsyncCommand(MoveRight);
            //MoveUpRightCommand = new AsyncCommand(MoveUpRight);
            //MoveDownRightCommand = new AsyncCommand(MoveDownRight);
        }

        // Command methods

        [RelayCommand]
        public async Task MoveLeft()
        {
            await client.PostAsync("MoveLeft", null);
        }
        public async Task MoveUpLeft()
        {
            await client.PostAsync("MoveUpLeft", null);
        }
        public async Task MoveDownLeft()
        {
            await client.PostAsync("MoveRight", null);
        }
        public async Task MoveRight()
        {
            await client.PostAsync("MoveUpRight", null);
        }
        public async Task MoveUpRight()
        {
            await client.PostAsync("MoveDownLeft", null);
        }
        public async Task MoveDownRight()
        {
            await client.PostAsync("MoveDownRight", null);
        }
    }
}
