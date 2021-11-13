using Newtonsoft.Json;
using SwachBharat.CMS.Bll.Repository.ChildRepository;
using SwachBharat.CMS.Bll.Repository.GridRepository;
using SwachBharat.CMS.Bll.Repository.MainRepository;
using SwachBharat.CMS.Bll.ViewModels.ChildModel.Model;
using SwachBharat.CMS.Bll.ViewModels.Grid;
using SwachBharat.CMS.Dal.DataContexts;
using SwachhBharatAbhiyan.CMS.Models.SessionHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace SwachhBharatAbhiyan.CMS.Controllers
{
    public class HomeController : Controller
    {
        IChildRepository childRepository;
        IMainRepository mainRepository;
        public HomeController()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                mainRepository = new MainRepository();
                childRepository = new ChildRepository(SessionHandler.Current.AppId);
            }
            else
                Redirect("/Account/Login");
        }


        public ActionResult Index()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                ViewBag.lat = SessionHandler.Current.Latitude;
                ViewBag.lang = SessionHandler.Current.Logitude;
                ViewBag.YoccFeddbackLink = SessionHandler.Current.YoccFeddbackLink;
                ViewBag.UlbName = SessionHandler.Current.AppName; 
                var details = childRepository.GetDashBoardDetails();
                return View(details);
            }
            else
                return Redirect("/Account/Login");
        }

        public ActionResult About()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                ViewBag.Message = "Your application description page.";
                return View();
            }
            else
                return Redirect("/Account/Login");
        }

        public ActionResult Organisationstructure()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                ViewBag.Message = "Your ORGANISATION description page.";
                return View();
            }
            else
                return Redirect("/Account/Login");
        }
        public ActionResult Who()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                ViewBag.Message = "Your Who's Who Page.";
                return View();
            }
            else
                return Redirect("/Account/Login");
        }
        public ActionResult ContactUs()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                ViewBag.Message = "Your contact page.";
                return View();
            }
            else
                return Redirect("/Account/Login");

        }
        public ActionResult Help()
        {
            return View();
        }
        public ActionResult WebsitePolicies()
        {
            return View();
        }
        public ActionResult Notice_Disclosures()
        {
            return View();
        }
        public ActionResult Mechanism()
        {
            return View();
        }
        public ActionResult Responsibility_Authority()
        {
            return View();
        }
        public ActionResult Terms_Conditions()
        {
            return View();
        }

        public ActionResult Validation_TestingProcess()
        {
            return View();
        }

        public ActionResult Sitemap()
        {
            return View();
        }



        public ActionResult DashBoard()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                var details = childRepository.GetDashBoardDetails();

                if (details!=null)
                {
                    string jsonstr = JsonConvert.SerializeObject(details);
                    return Json(jsonstr, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(null, JsonRequestBehavior.AllowGet);
                }
            }
            else
                return Redirect("/Account/Login");
        }

        
        public ActionResult EmployeeTargetCount(DateTime? fdate = null, DateTime? tdate = null, int userId = 0)
        {
            if (SessionHandler.Current.AppId != 0)
            {
                if (fdate == null)
                {
                    string dt = DateTime.Now.ToString("MM/dd/yyyy");
                    fdate = Convert.ToDateTime(dt + " " + "00:00:00");
                    tdate = Convert.ToDateTime(dt + " " + "23:59:59");
                }

                IEnumerable<DashBoardVM> obj;

                DashBoardRepository objRep = new DashBoardRepository();

                obj = objRep.getEmployeeTargetData(0, "", fdate, tdate, Convert.ToInt32(userId), SessionHandler.Current.AppId);
                return Json(obj, JsonRequestBehavior.AllowGet);
            }
            else
                return Redirect("/Account/Login");
        }

        //public class SessionExpireAttribute : ActionFilterAttribute
        //{
        //    public override void OnActionExecuting(ActionExecutingContext filterContext)
        //    {
        //        HttpContext ctx = System.Web.HttpContext.Current;
        //        // check  sessions here
        //        if (System.Web.HttpContext.Current.Session["AppId"] == null)
        //        {
        //            filterContext.Result = new RedirectResult("~/Home/Index");
        //            return;
        //        }
        //        base.OnActionExecuting(filterContext);
        //    }
        //}

        //by neha 13 june 2019
        public ActionResult EmployeeHouseCollectionType()
        {
            if (SessionHandler.Current.AppId != 0)
            {

                IEnumerable<EmployeeHouseCollectionType> obj;

                DashBoardRepository objRep = new DashBoardRepository();

                obj = objRep.getEmployeeHouseCollectionType(SessionHandler.Current.AppId);
                return Json(obj, JsonRequestBehavior.AllowGet);
            }
            else
                return Redirect("/Account/Login");
        }

        public ActionResult FeedBack(FeedBackVM feed)
        {
            if (SessionHandler.Current.AppId != 0)
            {
                
                return View(feed);
            }
            else
                return Redirect("/Account/Login");
        }

        public ActionResult MenuFeedBack(FeedBackVM feed)
        {
            if (SessionHandler.Current.AppId != 0)
            {
                return View(feed);
            }
            else
                return Redirect("/Account/Login");
        }
     
       
        [HttpPost]
        public ActionResult MenuFeedBackPreview(FeedBackVM Feed)
        {
            if (SessionHandler.Current.AppId != 0)
            {
                TempData["Name"] = Feed.Name;
                TempData["Address"] = Feed.Address;
                TempData["ContactNo"] = Feed.ContactNo;
                TempData["Email"] = Feed.Email;
                TempData["FeedBack"] = Feed.FeedBack;
                TempData.Keep("Name");
                TempData.Keep("Address");
                TempData.Keep("ContactNo");
                TempData.Keep("Email");
                TempData.Keep("FeedBack");
                return View(Feed);
            }
            else
                return Redirect("/Account/Login");
        }
        public ActionResult MenuFeedBackSuccess()
        {
            if (SessionHandler.Current.AppId != 0)
            {
            
                return View();
            }
            else
                return Redirect("/Account/Login");
        }
        [HttpPost]
        public ActionResult AddFeedBack(FeedBackVM feed)
        {
            if (SessionHandler.Current.AppId != 0)
            {
                feed.Name = TempData["Name"].ToString();
                feed.Address = TempData["Address"].ToString();
                feed.ContactNo = TempData["ContactNo"].ToString();
                feed.Email = TempData["Email"].ToString();
                feed.FeedBack = TempData["FeedBack"].ToString();
                MailMessage mail = new MailMessage();
                mail.To.Add(feed.Email);
                mail.From = new MailAddress("appynity@gmail.com");
                mail.Subject = "feedback form  submitted";
                string Body = "feedback form submitted SucessFully!";
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("appynity@gmail.com", "Appynitty@deve"); // Enter seders User name and password  
                smtp.EnableSsl = true;
                smtp.Send(mail);

                
                childRepository.SaveFeedback(feed);
                TempData["Feedmsg"] = "Feedback Message Send Successfully.";
                return Redirect("MenuFeedBackSuccess");
            }
            else
                return Redirect("/Account/Login");
        }


        public ActionResult ScreenReader()
        {
            if (SessionHandler.Current.AppId != 0)
            {

                return View();
            }
            else
                return Redirect("/Account/Login");
        }


        public ActionResult MenuScreenReader()
        {
            if (SessionHandler.Current.AppId != 0)
            {

                return View();
            }
            else
                return Redirect("/Account/Login");
        }

    }


}
