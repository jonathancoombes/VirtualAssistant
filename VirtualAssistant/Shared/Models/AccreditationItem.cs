using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssistant.Shared;

namespace VirtualAssistant.Shared.Models
{
    public class AccreditationItem
    {
        public int AccreditationItemId { get; set; }
        public QmsType QmsType{ get; set; }
        public bool ExternalAccreditationSupportReferral { get; set; }

    }

}
