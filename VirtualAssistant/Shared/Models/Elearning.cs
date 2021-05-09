using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssistant.Shared.Models
{
    public class Elearning
    {
        public int ElearningId { get; set; }
        public TrainingMaterial TrainingMaterial { get; set; }
        public SetupPackage SetupPackage { get; set; }

    }
}
