using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BadgerClan.Maui.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        HttpClient client;
        public IAsyncRelayCommand MoveLeftCommand1 { get; }
        public IAsyncRelayCommand MoveUpLeftCommand { get; }
        public IAsyncRelayCommand MoveDownLeftCommand { get; }
        public IAsyncRelayCommand MoveRightCommand { get; }
        public IAsyncRelayCommand MoveUpRightCommand { get; }
        public IAsyncRelayCommand MoveDownRightCommand { get; }
        public MainPageViewModel(HttpClient client)
        {
            this.client = client;

            MoveLeftCommand1 = new AsyncRelayCommand(MoveLeft);
            MoveUpLeftCommand = new AsyncRelayCommand(MoveUpLeft);
            MoveDownLeftCommand = new AsyncRelayCommand(MoveDownLeft);
            MoveRightCommand = new AsyncRelayCommand(MoveRight);
            MoveUpRightCommand = new AsyncRelayCommand(MoveUpRight);
            MoveDownRightCommand = new AsyncRelayCommand(MoveDownRight);
        }

        // Command methods

        [RelayCommand]
        public async Task MoveLeft()
        {
            Console.WriteLine("Attempting to get async at " + client.BaseAddress + "/MoveLeft");
            await client.GetAsync("/MoveLeft");
        }
        public async Task MoveUpLeft()
        {
            await client.GetAsync("/MoveUpLeft");
        }
        public async Task MoveDownLeft()
        {
            await client.GetAsync("/MoveRight");
        }
        public async Task MoveRight()
        {
            await client.GetAsync("/MoveUpRight");
        }
        public async Task MoveUpRight()
        {
            await client.GetAsync("/MoveDownLeft");
        }
        public async Task MoveDownRight()
        {
            await client.GetAsync("/MoveDownRight");
        }
    }
}
