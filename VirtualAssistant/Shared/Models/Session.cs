using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssistant.Shared.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public User UserId { get; set; }
        public Basket Basket{ get; set; }
        public Quote QuoteId { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
