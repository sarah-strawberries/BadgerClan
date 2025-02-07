using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BadgerClan.Maui.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        HttpClient client;
        public ICommand MoveLeftCommand { get; }
        public MainPageViewModel(HttpClient client)
        {
            this.client = client;
            MoveLeftCommand = new Command(MoveLeft);
        }

        // Command methods

        public void MoveLeft()
        {

        }
        

    }
}
