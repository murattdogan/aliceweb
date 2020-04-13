using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alice.Admin.Filters;
using Alice.Admin.Models;
using Alice.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace Alice.Admin.Controllers
{
    [ServiceFilter(typeof(AuthorizationAttribute))]
    public class AnaSayfaController : Controller
    {
        private readonly KeywordPoolService _keywordPoolService;
        private readonly SiteSettingsService _siteSettingsService;

        public AnaSayfaController(KeywordPoolService keywordPoolService, SiteSettingsService siteSettingsService)
        {
            _keywordPoolService = keywordPoolService;
            _siteSettingsService = siteSettingsService;
        }


        public IActionResult Yonetim()
        {
            ViewBag.AlreadyImageList = _siteSettingsService.GetAll();
            ViewBag.SelectAllKeyword = _keywordPoolService.GetAll();
            return View();
        }
        public JsonResult TextUpdate(string title, string description)
        {

            var titleResult = _siteSettingsService.GetFirstByFieldName("texttitle");
            var descriptionResult = _siteSettingsService.GetFirstByFieldName("textdescription");

            if (titleResult != null && descriptionResult != null)
            {
                titleResult.FieldValue = title;
                descriptionResult.FieldValue = description;

                _siteSettingsService.Update(titleResult);
                _siteSettingsService.Update(descriptionResult);
            }

            return Json(true);
        }

        public JsonResult UpdateCategoryBox(string galleryId, string categorySliderFieldName, string categoryCheckTitle)
        {
            var imageResult = _siteSettingsService.GetFirstByFieldName(categorySliderFieldName);
            var titleResult = _siteSettingsService.GetFirstByFieldName($"{categorySliderFieldName}Title");

            if (imageResult != null && titleResult != null)
            {
                imageResult.FieldValue = galleryId;
                titleResult.FieldValue = categoryCheckTitle;
                _siteSettingsService.Update(imageResult);
                _siteSettingsService.Update(titleResult);
                return Json(true);
            }
            return Json(false);
        }


        public JsonResult UpdateSlider(string galleryId, string sliderNumberId, string slideTitle, string slideButtonTitle, string slideButtonLink)
        {
            if (sliderNumberId == "SliderFirst")
            {
                var firstImage = _siteSettingsService.GetFirstByFieldName("SliderFirstImage");
                var firstTitle = _siteSettingsService.GetFirstByFieldName("SliderFirstTitle");
                var firstButtonTitle = _siteSettingsService.GetFirstByFieldName("SliderFirstButtonTitle");
                var firstButtonLink = _siteSettingsService.GetFirstByFieldName("SliderFirstButtonLink");

                if (firstImage != null && firstTitle != null && firstButtonTitle != null && firstButtonLink != null)
                {
                    firstImage.FieldValue = galleryId;
                    firstTitle.FieldValue = slideTitle;
                    firstButtonTitle.FieldValue = slideButtonTitle;
                    firstButtonLink.FieldValue = slideButtonLink;

                    _siteSettingsService.Update(firstImage);
                    _siteSettingsService.Update(firstTitle);
                    _siteSettingsService.Update(firstButtonTitle);
                    _siteSettingsService.Update(firstButtonLink);
                }

            }
            else if (sliderNumberId == "SliderSecond")
            {
                var firstImage = _siteSettingsService.GetFirstByFieldName("SliderSecondImage");
                var firstTitle = _siteSettingsService.GetFirstByFieldName("SliderSecondTitle");
                var firstButtonTitle = _siteSettingsService.GetFirstByFieldName("SliderSecondButtonTitle");
                var firstButtonLink = _siteSettingsService.GetFirstByFieldName("SliderSecondButtonLink");

                if (firstImage != null && firstTitle != null && firstButtonTitle != null && firstButtonLink != null)
                {
                    firstImage.FieldValue = galleryId;
                    firstTitle.FieldValue = slideTitle;
                    firstButtonTitle.FieldValue = slideButtonTitle;
                    firstButtonLink.FieldValue = slideButtonLink;

                    _siteSettingsService.Update(firstImage);
                    _siteSettingsService.Update(firstTitle);
                    _siteSettingsService.Update(firstButtonTitle);
                    _siteSettingsService.Update(firstButtonLink);
                }
            }
            else if (sliderNumberId == "SliderThird")
            {
                var firstImage = _siteSettingsService.GetFirstByFieldName("SliderThirdImage");
                var firstTitle = _siteSettingsService.GetFirstByFieldName("SliderThirdTitle");
                var firstButtonTitle = _siteSettingsService.GetFirstByFieldName("SliderThirdButtonTitle");
                var firstButtonLink = _siteSettingsService.GetFirstByFieldName("SliderThirdButtonLink");

                if (firstImage != null && firstTitle != null && firstButtonTitle != null && firstButtonLink != null)
                {
                    firstImage.FieldValue = galleryId;
                    firstTitle.FieldValue = slideTitle;
                    firstButtonTitle.FieldValue = slideButtonTitle;
                    firstButtonLink.FieldValue = slideButtonLink;

                    _siteSettingsService.Update(firstImage);
                    _siteSettingsService.Update(firstTitle);
                    _siteSettingsService.Update(firstButtonTitle);
                    _siteSettingsService.Update(firstButtonLink);
                }
            }
            else if (sliderNumberId == "SliderForth")
            {
                var firstImage = _siteSettingsService.GetFirstByFieldName("SliderForthImage");
                var firstTitle = _siteSettingsService.GetFirstByFieldName("SliderForthTitle");
                var firstButtonTitle = _siteSettingsService.GetFirstByFieldName("SliderForthButtonTitle");
                var firstButtonLink = _siteSettingsService.GetFirstByFieldName("SliderForthButtonLink");

                if (firstImage != null && firstTitle != null && firstButtonTitle != null && firstButtonLink != null)
                {
                    firstImage.FieldValue = galleryId;
                    firstTitle.FieldValue = slideTitle;
                    firstButtonTitle.FieldValue = slideButtonTitle;
                    firstButtonLink.FieldValue = slideButtonLink;

                    _siteSettingsService.Update(firstImage);
                    _siteSettingsService.Update(firstTitle);
                    _siteSettingsService.Update(firstButtonTitle);
                    _siteSettingsService.Update(firstButtonLink);
                }
            }

            return Json(true);
        }



        public JsonResult GetSingleSlider(string fieldName)
        {
            SliderModel model = new SliderModel()
            {
                SlideTitle = _siteSettingsService.GetFirstByFieldName($"{fieldName}Title").FieldValue,
                SliderImage = _siteSettingsService.GetFirstByFieldName($"{fieldName}Image").FieldValue,
                SlideButtonLink = _siteSettingsService.GetFirstByFieldName($"{fieldName}ButtonLink").FieldValue,
                SlideButtonTitle = _siteSettingsService.GetFirstByFieldName($"{fieldName}ButtonTitle").FieldValue
            };
            return Json(model);
        }
    }
}