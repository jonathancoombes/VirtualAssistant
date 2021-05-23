using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssistant.Shared.Models
{
    public class TrainingMaterialItem
    {
        public int TrainingMaterialItemId { get; set; }
        public int? SaqaId { get; set; }
        public TrainingMaterialItemType TmType { get; set; }
        public TrainingMaterialItemFormat TmFormat { get; set; }
    }


}

