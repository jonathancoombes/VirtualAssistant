using System.Collections;
using System.Collections.Generic;

namespace VirtualAssistant.Shared.Models
{
    public interface IBasketRepositoryService
    {
        void DeleteBasketItem<T>(T item);
        public void AddBasketItem<T>(T item);
        List<Hashtable> MainBasket { get; set; }

        public Hashtable TrainingMaterialItems { get; set; }
        public Hashtable AccreditationItems { get; set; }
        public Hashtable ElearningItems { get; set; }

         
    };
}