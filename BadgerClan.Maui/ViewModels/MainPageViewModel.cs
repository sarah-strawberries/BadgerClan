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
        public ICommand MoveUpLeftCommand { get; }
        public ICommand MoveDownLeftCommand { get; }
        public ICommand MoveRightCommand { get; }
        public ICommand MoveUpRightCommand { get; }
        public ICommand MoveDownRightCommand { get; }
        public MainPageViewModel(HttpClient client)
        {
            this.client = client;

            MoveLeftCommand = new Command(MoveLeft);
            MoveUpLeftCommand = new Command(MoveUpLeft);
            MoveDownLeftCommand = new Command(MoveDownLeft);
            MoveRightCommand = new Command(MoveRight);
            MoveUpRightCommand = new Command(MoveUpRight);
            MoveDownRightCommand = new Command(MoveDownRight);
        }

        // Command methods

        public void MoveLeft()
        {

        }        
        public void MoveUpLeft()
        {

        }        
        public void MoveDownLeft()
        {

        }        
        public void MoveRight()
        {

        }        
        public void MoveUpRight()
        {

        }        
        public void MoveDownRight()
        {

        }
        

    }
}
