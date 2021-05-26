using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using VirtualAssistant.Shared.Models;

namespace VirtualAssistant.Client.Shared
{
    public partial class TrainingMaterial
    {

        [Parameter] public IBasketRepositoryService TheBasket { get; set; }

        public string buttonActiveStyle = "btn-success";
        public string buttonNonActiveStyle = "btn-default";
        public string iconActiveStyle = "fa fa-check";
        public string iconNonActiveStyle = "far fa-times-circle";


        public List<TrainingMaterialItem> TrainingMaterialItems = new List<TrainingMaterialItem>();
       
        

        [Required, MinLength(4), MaxLength(6)]
        public int? SaqaId { get; set; }

        public void RefreshState()
        {
            this.StateHasChanged();
        }


        public void AddTrainingMaterialItemToBasket()
        {        
        
        TrainingMaterialItem selectedTrainingMaterialItem = new TrainingMaterialItem();

        selectedTrainingMaterialItem.SaqaId = SaqaId;
            if (selectedTrainingMaterialItem.SaqaId != null)
            {
                TrainingMaterialItems.Add(selectedTrainingMaterialItem);
            }

            TheBasket.TrainingMaterialItems = TrainingMaterialItems;
            SaqaId = null;

        }

        public void RemoveTrainingMaterialItemFromBasket(TrainingMaterialItem item)
        {
            TheBasket.TrainingMaterialItems.Remove(item);
        }

        protected override void OnInitialized()
        {
            TheBasket.ShowMainMenu = false;
             TheBasket.TrainingMaterialItems = TrainingMaterialItems;

            ShowBasket = false;

        }

        public string ButtonStyle<T>(T item)
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


        void SaqaIdAvailability(bool avail)
        {
            if (avail)
            {
                SaqaIdAvailable = true;
                SaqaIdMeaningRequired = false;
            }
            else
            {
                SaqaIdAvailable = false;
            }

        }

        void Accredited()
        {
            ShowAccreditationStatusRequest = false;
            DisplayAccreditationAssistanceButtons = false;
            DisplayAccreditationStatusButtons = false;
            TheBasket.AccreditationInterest = false;
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
            TheBasket.AccreditationAssistance = true;
            ShowAccreditationStatusRequest = false;
            DisplayAccreditationAssistanceButtons = false;
            ShowMaterialTypes = true;
        }
        void DoesNotNeedAccreditationAssistance()
        {
            TheBasket.AccreditationAssistance = false;
            DisplayAccreditationAssistanceButtons = false;
            TheBasket.AccreditationInterest = false;
            ShowMaterialTypes = true;
        }

        void SetaMaterialInterest()
        {
            if (TheBasket.SetaMaterialInterest == null || TheBasket.SetaMaterialInterest == false)
            {
                TheBasket.SetaMaterialInterest = true;
            }
            else
                TheBasket.SetaMaterialInterest = false;
        }


        void QctoMaterialInterest()
        {
            if (TheBasket.QctoMaterialInterest == null || TheBasket.QctoMaterialInterest == false)
            {
                TheBasket.QctoMaterialInterest = true;
            }
            else
                TheBasket.QctoMaterialInterest = false;
        }

        void OtherMaterialInterest()
        {
            if (TheBasket.OtherMaterialInterest == null || TheBasket.OtherMaterialInterest == false)
            {
                TheBasket.OtherMaterialInterest = true;
            }
            else
                TheBasket.OtherMaterialInterest = false;
        }

        void ELearningInterest()
        {
            if (TheBasket.ELearningInterest == null || TheBasket.ELearningInterest == false)
            {
                TheBasket.ELearningInterest = true;
            }
            else
                TheBasket.ELearningInterest = false;
        }

        void MaterialTypeSelected()
        {
            ProductTypeSelected = true;
            ShowMaterialTypes = false;
        }

        public bool ShowAccreditationStatusRequest { get; set; }

        public bool ProductTypeSelected { get; set; }
        public bool SaqaIdAvailabilityRequirement { get; set; }
        public bool SaqaIdAvailable { get; set; }
        public bool SaqaIdMeaningRequired { get; set; }
        public bool ShowSaqaSearch { get; set; }
        public bool ShowSaqaIdRequestOptions { get; set; }
        public bool ShowBasket { get; set; }
        
    [Parameter]
    public User ActiveUser { get; set; }

    [Parameter]
    public bool DisplayAccreditationStatusButtons { get; set; }

    public bool DisplayAccreditationAssistanceButtons { get; set; } = false;

    [Parameter]
    public EventCallback<TrainingMaterial> DeleteMaterial { get; set; }

    [Parameter]
    public bool ShowMaterialTypes { get; set; }

    }
}
