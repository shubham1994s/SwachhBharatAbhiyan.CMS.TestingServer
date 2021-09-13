using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace SwachhBharatAbhiyan.CMS
{
    public class MvcApplication : System.Web.HttpApplication
    {
         void Application_Start()
        {
           
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);                                   
            var userList = new List<string>();                
            Application["UserList"] = userList;
            MvcHandler.DisableMvcResponseHeader = true;
        }

        protected void Application_BeginRequest()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            Response.Cache.SetNoStore();
        }

        //void Session_Start(object sender, EventArgs e)
        //{
        //     var userName = Membership.GetUser().UserName;

        //    List<string> userList;
        //    if (Application["UserList"] != null)
        //    {
        //        userList = (List<string>)Application["UserList"];
        //    }
        //    else
        //        userList = new List<string>();
        //    userList.Add(userName);
        //    Application["UserList"] = userList;
        //}
    }
}
