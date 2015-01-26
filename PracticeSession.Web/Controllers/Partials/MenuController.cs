using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using PracticeSession.Web.Models.Pages;
using PracticeSession.Web.Models.ViewModels;

namespace PracticeSession.Web.Controllers.Partials
{
    public class MenuController : Controller
    {
        [ChildActionOnly]
        public ActionResult Index()
        {
            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
            //var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();
            var menuItems = contentLoader.GetChildren<SitePageData>(ContentReference.StartPage);

            var model = new MenuViewModel
            {
                MenuItems = menuItems
            };
            
            return PartialView("Partials/_Menu", model);
        }
    }
}