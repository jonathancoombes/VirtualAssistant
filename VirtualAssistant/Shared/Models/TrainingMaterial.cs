using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssistant.Shared.Models
{
    public class TrainingMaterial
    {
        public int TrainingMaterialId { get; set; }
        public int SaqaId { get; set; }
        public TrainingMaterialType TmType { get; set; }
        public TrainingMaterialFormat TmFormat { get; set; }
    }


}

