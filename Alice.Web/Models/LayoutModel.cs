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
            SliderFirstTitle = _siteSettingsService.GetFirstByFieldName("SliderFirstTitle").FieldValue;
            SliderFirstButtonTitle = _siteSettingsService.GetFirstByFieldName("SliderFirstButtonTitle").FieldValue;
            SliderSecondTitle = _siteSettingsService.GetFirstByFieldName("SliderSecondTitle").FieldValue;
            SliderSecondButtonTitle = _siteSettingsService.GetFirstByFieldName("SliderSecondButtonTitle").FieldValue;
            SliderThirdTitle = _siteSettingsService.GetFirstByFieldName("SliderThirdTitle").FieldValue;
            SliderThirdButtonTitle = _siteSettingsService.GetFirstByFieldName("SliderThirdButtonTitle").FieldValue;
            SliderForthTitle = _siteSettingsService.GetFirstByFieldName("SliderForthTitle").FieldValue;
            SliderForthButtonTitle = _siteSettingsService.GetFirstByFieldName("SliderForthButtonTitle").FieldValue;
            SliderFirstImage = _siteSettingsService.GetFirstByFieldName("SliderFirstImage").FieldValue;
            SliderSecondImage = _siteSettingsService.GetFirstByFieldName("SliderSecondImage").FieldValue;
            SliderThirdImage = _siteSettingsService.GetFirstByFieldName("SliderThirdImage").FieldValue;
            SliderForthImage = _siteSettingsService.GetFirstByFieldName("SliderForthImage").FieldValue;
            SliderFirstButtonLink = _siteSettingsService.GetFirstByFieldName("SliderFirstButtonLink").FieldValue;
            SliderSecondButtonLink = _siteSettingsService.GetFirstByFieldName("SliderSecondButtonLink").FieldValue;
            SliderThirdButtonLink = _siteSettingsService.GetFirstByFieldName("SliderThirdButtonLink").FieldValue;
            SliderForthButtonLink = _siteSettingsService.GetFirstByFieldName("SliderForthButtonLink").FieldValue;
            texttitle = _siteSettingsService.GetFirstByFieldName("texttitle").FieldValue;
            textdescription = _siteSettingsService.GetFirstByFieldName("textdescription").FieldValue;
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

    }
}
