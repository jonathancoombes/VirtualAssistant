using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualAssistant.Client.Shared;
using VirtualAssistant.Shared.Models;

namespace VirtualAssistant.Client.Pages
{
    public partial class Index
    {
        public User NewUser1 = new User();
        string nameRequest = "Hello, I am Sam. What is your name?";


        protected override void OnInitialized()
        {
            TheBasket.ShowMainMenu = true;
            TheBasket.ShowGreeting = true;
        }
    }
}
