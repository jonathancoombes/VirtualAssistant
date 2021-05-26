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

        public Basket()
        {
            TrainingMaterialItem = new TrainingMaterialItem();
            TrainingMaterialItems = new List<TrainingMaterialItem>();
            ElearningItems = new List<ElearningItem>();
            AccreditationItems = new List<AccreditationItem>();
        }

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

        public TrainingMaterialItem TrainingMaterialItem { get; set; }

        public List<TrainingMaterialItem> TrainingMaterialItems { get; set; }
        public List<ElearningItem> ElearningItems { get; set; }
        public List<AccreditationItem> AccreditationItems { get; set; }


    }
}

