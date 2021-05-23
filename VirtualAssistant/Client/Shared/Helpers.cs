using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualAssistant.Client.Shared
{
    public static class Helpers
    {
        public static string Loader(string duration)
        {
            string result = "";
            return result = $"<div id='loader' class='{duration.ToString()}' style='display:inline-block'>" + "<img src=" + "images/loadi.gif" + " width='85'/></div>";
    
        }


    }
}
