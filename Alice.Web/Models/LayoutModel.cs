using Alice.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alice.Web.Models
{
    public class LayoutModel
    {
        private readonly SiteSettingsService _siteSettingsService;

        public LayoutModel(SiteSettingsService siteSettingsService)
        {
            _siteSettingsService = siteSettingsService;
            var allSettings = _siteSettingsService.GetAll();

            SliderFirstTitle = allSettings.First(x => x.FieldName == "SliderFirstTitle").FieldValue;
            SliderFirstButtonTitle = allSettings.First(x => x.FieldName == "SliderFirstButtonTitle").FieldValue;
            SliderSecondTitle = allSettings.First(x => x.FieldName == "SliderSecondTitle").FieldValue;
            SliderSecondButtonTitle = allSettings.First(x => x.FieldName == "SliderSecondButtonTitle").FieldValue;
            SliderThirdTitle = allSettings.First(x => x.FieldName == "SliderThirdTitle").FieldValue;
            SliderThirdButtonTitle = allSettings.First(x => x.FieldName == "SliderThirdButtonTitle").FieldValue;
            SliderForthTitle = allSettings.First(x => x.FieldName == "SliderForthTitle").FieldValue;
            SliderForthButtonTitle = allSettings.First(x => x.FieldName == "SliderForthButtonTitle").FieldValue;
            SliderFirstImage = allSettings.First(x => x.FieldName == "SliderFirstImage").FieldValue;
            SliderSecondImage = allSettings.First(x => x.FieldName == "SliderSecondImage").FieldValue;
            SliderThirdImage = allSettings.First(x => x.FieldName == "SliderThirdImage").FieldValue;
            SliderForthImage = allSettings.First(x => x.FieldName == "SliderForthImage").FieldValue;
            SliderFirstButtonLink = allSettings.First(x => x.FieldName == "SliderFirstButtonLink").FieldValue;
            SliderSecondButtonLink = allSettings.First(x => x.FieldName == "SliderSecondButtonLink").FieldValue;
            SliderThirdButtonLink = allSettings.First(x => x.FieldName == "SliderThirdButtonLink").FieldValue;
            SliderForthButtonLink = allSettings.First(x => x.FieldName == "SliderForthButtonLink").FieldValue;
            texttitle = allSettings.First(x => x.FieldName == "texttitle").FieldValue;
            textdescription = allSettings.First(x => x.FieldName == "textdescription").FieldValue;
            HomeCategoryImageOne = allSettings.First(x => x.FieldName == "HomeCategoryImageOne").FieldValue;
            HomeCategoryImageTwo = allSettings.First(x => x.FieldName == "HomeCategoryImageTwo").FieldValue;
            HomeCategoryImageThree = allSettings.First(x => x.FieldName == "HomeCategoryImageThree").FieldValue;
            HomeCategoryImageFour = allSettings.First(x => x.FieldName == "HomeCategoryImageFour").FieldValue;
            HomeCategoryImageFive = allSettings.First(x => x.FieldName == "HomeCategoryImageFive").FieldValue;
            HomeCategoryImageSix = allSettings.First(x => x.FieldName == "HomeCategoryImageSix").FieldValue;
            HomeCategoryImageSeven = allSettings.First(x => x.FieldName == "HomeCategoryImageSeven").FieldValue;

        }

        public string SliderFirstTitle { get; set; }
        public string SliderFirstButtonTitle { get; set; }
        public string SliderSecondTitle { get; set; }
        public string SliderSecondButtonTitle { get; set; }
        public string SliderThirdTitle { get; set; }
        public string SliderThirdButtonTitle { get; set; }
        public string SliderForthTitle { get; set; }
        public string SliderForthButtonTitle { get; set; }
        public string SliderFirstImage { get; set; }
        public string SliderSecondImage { get; set; }
        public string SliderThirdImage { get; set; }
        public string SliderForthImage { get; set; }
        public string SliderFirstButtonLink { get; set; }
        public string SliderSecondButtonLink { get; set; }
        public string SliderThirdButtonLink { get; set; }
        public string SliderForthButtonLink { get; set; }
        public string texttitle { get; set; }
        public string textdescription { get; set; }
        public string HomeCategoryImageOne { get; set; }
        public string HomeCategoryImageTwo { get; set; }
        public string HomeCategoryImageThree { get; set; }
        public string HomeCategoryImageFour { get; set; }
        public string HomeCategoryImageFive { get; set; }
        public string HomeCategoryImageSix { get; set; }
        public string HomeCategoryImageSeven { get; set; }

    }
}
