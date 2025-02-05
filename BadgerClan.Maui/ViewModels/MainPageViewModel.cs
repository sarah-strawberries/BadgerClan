using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgerClan.Maui.ViewModels
{
    public partial class MainPageViewModel
    {
        HttpClient client;
        public MainPageViewModel(HttpClient client)
        {
            this.client = client;
        }

    }
}
