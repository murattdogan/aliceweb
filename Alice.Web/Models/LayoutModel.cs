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

        private readonly GalleryPoolService _galleryPoolService;


        public LayoutModel(SiteSettingsService siteSettingsService, GalleryPoolService galleryPoolService)
        {
            _siteSettingsService = siteSettingsService;
            _galleryPoolService = galleryPoolService;

            var allSettings = _siteSettingsService.GetAll();

            SliderFirstTitle = allSettings.First(x => x.FieldName == "SliderFirstTitle").FieldValue;
            SliderFirstButtonTitle = allSettings.First(x => x.FieldName == "SliderFirstButtonTitle").FieldValue;
            SliderSecondTitle = allSettings.First(x => x.FieldName == "SliderSecondTitle").FieldValue;
            SliderSecondButtonTitle = allSettings.First(x => x.FieldName == "SliderSecondButtonTitle").FieldValue;
            SliderThirdTitle = allSettings.First(x => x.FieldName == "SliderThirdTitle").FieldValue;
            SliderThirdButtonTitle = allSettings.First(x => x.FieldName == "SliderThirdButtonTitle").FieldValue;
            SliderForthTitle = allSettings.First(x => x.FieldName == "SliderForthTitle").FieldValue;
            SliderForthButtonTitle = allSettings.First(x => x.FieldName == "SliderForthButtonTitle").FieldValue;
            SliderFirstImage = GetImage(allSettings.First(x => x.FieldName == "SliderFirstImage").FieldValue);
            SliderSecondImage = GetImage(allSettings.First(x => x.FieldName == "SliderSecondImage").FieldValue);
            SliderThirdImage = GetImage(allSettings.First(x => x.FieldName == "SliderThirdImage").FieldValue);
            SliderForthImage = GetImage(allSettings.First(x => x.FieldName == "SliderForthImage").FieldValue);
            SliderFirstButtonLink = allSettings.First(x => x.FieldName == "SliderFirstButtonLink").FieldValue;
            SliderSecondButtonLink = allSettings.First(x => x.FieldName == "SliderSecondButtonLink").FieldValue;
            SliderThirdButtonLink = allSettings.First(x => x.FieldName == "SliderThirdButtonLink").FieldValue;
            SliderForthButtonLink = allSettings.First(x => x.FieldName == "SliderForthButtonLink").FieldValue;
            texttitle = allSettings.First(x => x.FieldName == "texttitle").FieldValue;
            textdescription = allSettings.First(x => x.FieldName == "textdescription").FieldValue;
            HomeCategoryImageOne =   GetImage(allSettings.First(x => x.FieldName == "HomeCategoryImageOne").FieldValue);
            HomeCategoryImageTwo =   GetImage(allSettings.First(x => x.FieldName == "HomeCategoryImageTwo").FieldValue);
            HomeCategoryImageThree = GetImage(allSettings.First(x => x.FieldName == "HomeCategoryImageThree").FieldValue);
            HomeCategoryImageFour =  GetImage(allSettings.First(x => x.FieldName == "HomeCategoryImageFour").FieldValue);
            HomeCategoryImageFive =  GetImage(allSettings.First(x => x.FieldName == "HomeCategoryImageFive").FieldValue);
            HomeCategoryImageSix =   GetImage(allSettings.First(x => x.FieldName == "HomeCategoryImageSix").FieldValue);
            HomeCategoryImageSeven = GetImage(allSettings.First(x => x.FieldName == "HomeCategoryImageSeven").FieldValue);
            HomeCategoryImageOneTitle = allSettings.First(x => x.FieldName == "HomeCategoryImageOneTitle").FieldValue;
            HomeCategoryImageTwoTitle = allSettings.First(x => x.FieldName == "HomeCategoryImageTwoTitle").FieldValue;
            HomeCategoryImageThreeTitle = allSettings.First(x => x.FieldName == "HomeCategoryImageThreeTitle").FieldValue;
            HomeCategoryImageFourTitle = allSettings.First(x => x.FieldName == "HomeCategoryImageFourTitle").FieldValue;
            HomeCategoryImageFiveTitle = allSettings.First(x => x.FieldName == "HomeCategoryImageFiveTitle").FieldValue;
            HomeCategoryImageSixTitle = allSettings.First(x => x.FieldName == "HomeCategoryImageSixTitle").FieldValue;
            HomeCategoryImageSevenTitle = allSettings.First(x => x.FieldName == "HomeCategoryImageSevenTitle").FieldValue;

        }

        private string GetImage(string galleryId)
        {
            string image = "";
            var t = _galleryPoolService.GetByGalleryId(galleryId);
            if (t != null)
            {
                image = $"http://localhost:5005{t.ImagePath}\\{t.GalleryId}{t.PathExtension}";
            }
            return image;
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
        public string HomeCategoryImageOneTitle { get; set; }
        public string HomeCategoryImageTwoTitle { get; set; }
        public string HomeCategoryImageThreeTitle { get; set; }
        public string HomeCategoryImageFourTitle { get; set; }
        public string HomeCategoryImageFiveTitle { get; set; }
        public string HomeCategoryImageSixTitle { get; set; }
        public string HomeCategoryImageSevenTitle { get; set; }

    }
}
