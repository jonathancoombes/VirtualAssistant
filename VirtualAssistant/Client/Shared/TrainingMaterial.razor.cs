using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using VirtualAssistant.Shared.Models;

namespace VirtualAssistant.Client.Shared
{
    public partial class TrainingMaterial 
    {
        

        [Parameter] public IBasketRepositoryService TBasket { get; set; }
        
        public string buttonActiveStyle = "btn-success";
        public string buttonNonActiveStyle = "btn-default";
        public string iconActiveStyle = "fa fa-check";
        public string iconNonActiveStyle = "far fa-times-circle";

        public TrainingMaterial()
        {
            TBasket.ShowMainMenu = false;
        }

        public string ButtonStyle <T>(T item)
        {
            
            if (item.Equals(true))
            {
                return buttonActiveStyle;
            }

            return buttonNonActiveStyle;

        }
        public string IconStyle<T>(T item)
        {

            if (item.Equals(true))
            {
                return iconActiveStyle;
            }

            return iconNonActiveStyle;

        }


        void Accredited()
        {
            
            ShowAccreditationStatusRequest = false;
            DisplayAccreditationAssistanceButtons = false;
            DisplayAccreditationStatusButtons = false;
            TBasket.AccreditationInterest = false;
            ShowMaterialTypes = true;
        }
        void NotAccredited()
        {
            DisplayAccreditationAssistanceButtons = true;
            ShowAccreditationStatusRequest = false;
            DisplayAccreditationStatusButtons = false;
            

        }

        void DoesNeedAccreditationAssistance()
        {
           TBasket.AccreditationAssistance = true;
           ShowAccreditationStatusRequest = false;
           DisplayAccreditationAssistanceButtons = false;
           ShowMaterialTypes = true;
        }
        void DoesNotNeedAccreditationAssistance()
        {
            TBasket.AccreditationAssistance = false;
            DisplayAccreditationAssistanceButtons = false;
            TBasket.AccreditationInterest = false;
            ShowMaterialTypes = true;
        }

        void SetaMaterialInterest()
        {
            if (TBasket.SetaMaterialInterest == null || TBasket.SetaMaterialInterest == false)
            {
                TBasket.SetaMaterialInterest = true;
            }
            else 
                TBasket.SetaMaterialInterest = false;
        }

      
        void QctoMaterialInterest()
        {
            if (TBasket.QctoMaterialInterest == null || TBasket.QctoMaterialInterest == false)
            {
                TBasket.QctoMaterialInterest = true;
            }
            else
                TBasket.QctoMaterialInterest = false;
        }

        void OtherMaterialInterest()
        {
            if (TBasket.OtherMaterialInterest == null || TBasket.OtherMaterialInterest == false)
            {
                TBasket.OtherMaterialInterest = true;
            }
            else
                TBasket.OtherMaterialInterest = false;
        }

        void ELearningInterest()
        {
            if (TBasket.ELearningInterest == null || TBasket.ELearningInterest == false)
            {
                TBasket.ELearningInterest = true;
            }
            else
                TBasket.ELearningInterest = false;
        }

        void MaterialTypeSelected()
        {
            ProductTypeSelected = true;
            ShowMaterialTypes = false;
            

        }
        
        public bool ShowAccreditationStatusRequest { get; set; }

        public bool ProductTypeSelected { get; set; }
        public bool SaqaIdAvailabilityRequest { get; set; }
        public bool SaqaIdAvailable { get; set; }
        public bool SaqaIdMeaningRequired { get; set; }
        public bool ShowSaqaSearch { get; set; }

        [Parameter]
    public User ActiveUser { get; set; } 

    [Parameter]

    public TrainingMaterial Material { get; set; }

    [Parameter]
    public bool DisplayAccreditationStatusButtons { get; set; }

    public bool DisplayAccreditationAssistanceButtons { get; set; } = false;

    [Parameter]
    public EventCallback<TrainingMaterial> DeleteMaterial { get; set; }

    [Parameter]
    public bool ShowMaterialTypes { get; set; }

    }
}
