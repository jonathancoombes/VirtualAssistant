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
            return new($"<div id='loader' class='{duration}' style='display:block'> <img src='{Constants.LoaderImage} ' width='85'/></div>");
        }


    }
}
