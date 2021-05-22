using System.Collections;
using System.Collections.Generic;

namespace VirtualAssistant.Shared.Models
{
    public interface IBasketRepositoryService
    {

        public int BasketId { get; set; }
        public bool ShowMainMenu { get; set; }
        public bool ShowGreeting { get; set; }

        public bool? TrainingMaterialInterest { get; set; }
        public bool? AccreditationInterest { get; set; }
        public bool? AccreditationAssistance { get; set; }
        public bool? ELearningInterest { get; set; }
        public bool? SetaMaterialInterest { get; set; }
        public bool? QctoMaterialInterest { get; set; }
        public bool? OtherMaterialInterest { get; set; }

        void DeleteBasketItem<T>(T item);
        public void AddBasketItem<T>(T item);
        List<Hashtable> MainBasket { get; set; }
        
        public Hashtable TrainingMaterialItems { get; set; }
        public Hashtable AccreditationItems { get; set; }
        public Hashtable ElearningItems { get; set; }



         
    };
}