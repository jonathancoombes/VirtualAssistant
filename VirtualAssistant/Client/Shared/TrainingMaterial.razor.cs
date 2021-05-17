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
       [Parameter] public IBasketRepositoryService TheBasket { get; set; }

        void Accredited()
        {
            ShowAccreditationStatusRequest = false;
            DisplayAccreditationAssistanceButtons = false;
            DisplayAccreditationStatusButtons = false;
            TheBasket.AccreditationInterest = false;
            //Continue
        }
        void NotAccredited()
        {
            DisplayAccreditationAssistanceButtons = true;
            ShowAccreditationStatusRequest = false;
            DisplayAccreditationStatusButtons = false;
            StateHasChanged();

        }

        void DoesNeedAccreditationAssistance()
        {
           TheBasket.AccreditationAssistance = true;
           ShowAccreditationStatusRequest = false;
           DisplayAccreditationAssistanceButtons = true;
        }
        void DoesNotNeedAccreditationAssistance()
        {
            TheBasket.AccreditationAssistance = false;
            DisplayAccreditationAssistanceButtons = false;
            TheBasket.AccreditationInterest = false;

        }
        public bool ShowAccreditationStatusRequest { get; set; }

        [Parameter]
    public User ActiveUser { get; set; } 

    [Parameter]

    public TrainingMaterial Material { get; set; }

    [Parameter]
    public bool DisplayAccreditationStatusButtons { get; set; }

    public bool DisplayAccreditationAssistanceButtons { get; set; } = false;

    [Parameter]
    public EventCallback<TrainingMaterial> DeleteMaterial { get; set; }

    [Parameter]
    public bool ShowMainMenu { get; set; }

    }
}
