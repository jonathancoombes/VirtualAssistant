using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using VirtualAssistant.Shared.Models;

namespace VirtualAssistant.Client.Shared
{
    public partial class MainMenuOptions
    {

        [Parameter] public IBasketRepositoryService TheBasket { get; set; }

        [Parameter]
        public User ActiveUser { get; set; }
        
       
      protected override void OnInitialized()
        {
            TheBasket.ShowMainMenu = true;
        }

        public bool ShowTrainingMaterial { get; set; }
        public bool ShowAccreditation { get; set; }
        public bool ShowElearning { get; set; }
        public bool ShowOther { get; set; }



        void ResetState()
        {
            ShowTrainingMaterial = false;
            ShowAccreditation = false;
            ShowElearning = false;
            ShowOther = false;
        }

    }
}
