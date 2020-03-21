using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Alice.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace Alice.Web.Controllers
{
    public class TourController : Controller
    {
        private readonly TourService _tourService;
        private readonly TourPlanService _tourPlanService;
        private readonly TourCategoriesService _tourCategoriesService;
        private readonly CategoryService _categoriesService;

        public TourController(TourService tourService, TourPlanService tourPlanService, TourCategoriesService tourCategoriesService, CategoryService categoriesService)
        {
            _tourService = tourService;
            _tourPlanService = tourPlanService;
            _tourCategoriesService = tourCategoriesService;
            _categoriesService = categoriesService;
        }

        public IActionResult Detail(string tourUrl, string tourPage)
        {
            if (tourUrl.Contains(".") || tourUrl.Contains("src") || tourUrl.ToLower().Contains("true") || tourUrl.ToLower().Contains("false"))
            {
                return RedirectPermanent(tourUrl);
            }
            var q = _tourService.GetTourByUrl(tourUrl);
            if (q != null)
            {
                //var breadCrumb = new List<string>();
                //breadCrumb.Add(q.TourName);

                //var tourCategories = _tourCategoriesService.GetAllByTourIdCategoriesName(q.Id);
                //var breadCrumbCategory = tourCategories.FirstOrDefault(x => q.TourUrl.Contains(x.CategoriesName));
                //breadCrumb.Add(breadCrumbCategory.CategoriesName);

                //var secondTopCategory = _categoriesService.GetParentCategoryName(breadCrumbCategory.CategoriesId);
                //breadCrumb.Add(secondTopCategory.CategoryName);
                //breadCrumb.Add(_categoriesService.GetParentCategoryName(secondTopCategory.Id).CategoryName);


                ViewBag.TourDays = _tourPlanService.GetAll().Where(x => x.TourId == q.Id).ToList();
                if (tourPage == "tour-plan")
                {
                    ViewBag.TourDays = _tourPlanService.GetAll().Where(x => x.TourId == q.Id).ToList();
                    return View("~/Views/Tour/tourplan.cshtml", q);
                }
                else if (tourPage == "tour-map")
                {
                    return View("~/Views/Tour/tourmap.cshtml", q);
                }
                else if (tourPage == "hotel")
                {
                    return View("~/Views/Tour/hotel.cshtml", q);
                }
                else if (tourPage == "conditions")
                {
                    ViewBag.TourDays = _tourPlanService.GetAll().Where(x => x.TourId == q.Id).ToList();
                    return View("~/Views/Tour/conditions.cshtml", q);
                }
                else if (tourPage == "gallery")
                {
                    ViewBag.Gallery = _tourPlanService.GetAll().Where(x => x.TourId == q.Id).ToList();
                    return View("~/Views/Tour/gallery.cshtml", q);
                }

                return View(q);
            }


            return View(null);
        }

        public IActionResult MessagePost(string Name, string Phone, string Email, string Notes)
        {
            string body = $"Dear {Name},<br><br>We have received your request.<br><br>We would like to thank you for your kind interest in our company & services. We would be delighted to suggest and plan a detailed itinerary to help you to discover Istanbul & Turkey.<br><br>We would be happy to provide you with a quotation as soon as possible.<br><br><font size=2><i>Great touring experiences are those that will be long remembered. They are ones that ensure you will tell your friends to visit this part of the world.<br><br>We offer private and customized accessible tours for individuals, families and groups, you can customize the tour of your dreams and the choices are virtually endless.<br><br>We invite you to come and turn the pages of the great history and civilizations, archaeology, nature.</i></font><br><br>Sincerely yours,<br><br><b>Ugur ILGAR<br>CEO</b><br>Luxury Istanbul";
            body += "<br/> <br/>";
            body += "<table>";
            body += $"<tr><td><b>Phone<b/></td><td>:</td><td>{Phone}</td></tr>";
            body += $"<tr><td><b>Email<b/></td><td>:</td><td>{Email}</td></tr>";
            body += $"<tr><td><b>Notes<b/></td><td>:</td><td>{Notes}</td></tr>";
            body += "</table>";



            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            mail.BodyEncoding = System.Text.Encoding.Default;
            mail.SubjectEncoding = System.Text.Encoding.Default;
            MailAddress gonderen = new MailAddress("noreply@luxuryistanbul.com", "noreply@luxuryistanbul.com", System.Text.Encoding.Default);
            mail.From = gonderen;
            mail.ReplyTo = new MailAddress("info@luxuryistanbul.com");
            mail.Bcc.Add("info@luxuryistanbul.com");
            mail.Bcc.Add("guzelkucukerkan@gmail.com");
            mail.To.Add(Email);
            mail.Subject = "Tour Request";
            mail.Body = body;
            mail.Priority = MailPriority.High;
            SmtpClient sunucu = new SmtpClient("mail.luxuryistanbul.com", 587);
            NetworkCredential nc = new NetworkCredential("noreply@luxuryistanbul.com", "Qvsc3711");
            sunucu.Credentials = nc;
            sunucu.Send(mail);

            return View();
        }
    }
}