using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssistant.Shared.Models
{
    public class Basket : IBasketRepositoryService
    {
        public int BasketId { get; set; }

        public bool? TrainingMaterialInterest { get; set; } = null;
        public bool? AccreditationInterest { get; set; } = null;
        public bool? ELearningInterest { get; set; } = null;
        
        public Hashtable TrainingMaterialItems { get; set; }
        public Hashtable AccreditationItems { get; set; }
        public Hashtable ElearningItems { get; set; }
        public List<Hashtable> MainBasket { get; set; }


        public void AddBasketItem<T>(T item)
        {
            throw new NotImplementedException();
        }

        public void DeleteBasketItem<T>(T item)
        {
            throw new NotImplementedException();
        }
    }
}

