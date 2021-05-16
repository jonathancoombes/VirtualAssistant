using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using VirtualAssistant.Shared.Models;

namespace VirtualAssistant.Client.Shared
{
    public partial class Basket
    {
        [Inject] 
        IBasketRepositoryService BasketService { get; set; }
            
        [Parameter]
        public Basket MainBasket { get; set; }

        [Parameter]

        public bool DisplayButtons { get; set; }

        [Parameter]
        public EventCallback<TrainingMaterial> EventCallback { get; set; }


    }
}
