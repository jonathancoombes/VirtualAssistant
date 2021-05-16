using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using VirtualAssistant.Shared.Models;

namespace VirtualAssistant.Client.Shared
{
    public partial class TrainingMaterial
    {
        [CascadingParameter] public Basket TheBasket { get; set; }

        void Accredited()
        {
            TheBasket.
            ShowAccreditationStatusRequest = false;

        }
        void NotAccredited()
        {


            ShowAccreditationStatusRequest = false;

        }
        public bool ShowAccreditationStatusRequest { get; set; }

        [Parameter]
    public User ActiveUser { get; set; } 

    [Parameter]

    public TrainingMaterial Material { get; set; }

    [Parameter]
    public bool DisplayAccreditationButtons { get; set; }

    [Parameter]
    public EventCallback<TrainingMaterial> DeleteMaterial { get; set; }

    [Parameter]
    public bool ShowMainMenu { get; set; }

    }
}
