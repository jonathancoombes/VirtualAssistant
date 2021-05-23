using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualAssistant.Client.Shared
{
    public static class Constants
    {
        public struct MessageDelay
        {
            public static string MessageDelayShort = "MessageShort";
            public static string MessageDelayMed = "MessageMed";
        }
        public struct LoaderDuration
        {
            public static string LoaderShort = "LoaderShort";
            public static string LoaderMed = "LoaderMed";
        }
        
        public enum DisplayType
        {
            Loader,
            Message
        }

        public enum ProductType
        {
            TrainingMaterial = 0,
            Accreditation = 1,
            Elearning = 2,
            Bespoke = 3
        }

        public enum MaterialType
        {
            SetaMaterial = 0,
            QctoMaterial = 1,
            NonAlignedMaterial = 2
        }

        public enum Seta
        {
            Agri = 0,
            Wr = 1,
            Caths = 2,
            Services = 3,
            Mqa = 4,
            Mict = 5,
            Etdp = 6,
            Hw = 7
        }


    }
}
