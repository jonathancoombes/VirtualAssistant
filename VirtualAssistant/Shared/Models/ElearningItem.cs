using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace VirtualAssistant.Shared.Models
{
    public class ElearningItem
    {
        public int ElearningItemId { get; set; }
        public TrainingMaterialItem TrainingMaterial { get; set; }
        public SetupPackage SetupPackage { get; set; }

    }
}
