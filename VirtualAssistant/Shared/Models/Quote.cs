using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssistant.Shared.Models
{
    public class Quote
    {
        public int SessionId { get; set; }
        public Session Session { get; set; }

    }
}
