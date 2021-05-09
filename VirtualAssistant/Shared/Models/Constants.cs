using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssistant.Shared.Models
{
    public enum QuoteMethod
        {
            Email = 1,
            Display = 2
        }
        public enum ContactMethod
        {
            Callback = 1,
            Message = 2
        }
       public  enum TrainingMaterialType { 
            SetaQualification,
            SetaUnitStandard,
            QctoQualification

        }
        public enum TrainingMaterialFormat
        {
            StandardClassroom = 1,
            Elearning = 2

        }
        public enum QmsType
        {
            StandardClassroomFormat = 1,
            ElearningFormat = 2

        }
        public enum Seta
        {
            ServicesSeta,
            WrSeta,
            HwSeta,
            CathsSeta,
            CetaSeta,
            MictSeta

        }

        public enum SetupPackage
        {
            Gold, 
            Platinum
        }

        public enum ElearningPlatform
        {

        }
}
