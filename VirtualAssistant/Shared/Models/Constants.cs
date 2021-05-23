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
       public enum TrainingMaterialItemType { 
            SetaQualification,
            SetaUnitStandard,
            QctoQualification,
            Other

        }
        public enum TrainingMaterialItemFormat
        {
            StandardClassroom = 1,
            Elearning = 2

        }
        public enum QmsType
        {
            StandardClassroomFormat = 1,
            ElearningFormat = 2

        }

        public enum LmsType
        {
            Moodle = 0,
            Blackboard = 1,
            Edmondo = 2,
            CaptivatePrime = 3,
            LearnUpon = 4,
            ISpring = 5,
            LearnDash = 6,
            Totara = 7,
            Chamilo = 8,
            Canvas = 9,
            Other = 10
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

}
