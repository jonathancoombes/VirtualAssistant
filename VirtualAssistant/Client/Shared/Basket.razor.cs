using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using VirtualAssistant.Shared.Models;

namespace VirtualAssistant.Client.Shared
{
    public partial class Basket
    {
        [Parameter] public IBasketRepositoryService TheBasket { get; set; }

        public void DeleteBasketItem(TrainingMaterialItem item)
        {
            TheBasket.TrainingMaterialItems.Remove(item);
        }


        

    }
}
