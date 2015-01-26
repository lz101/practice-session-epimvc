using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using PracticeSession.Web.Models.Pages;
using PracticeSession.Web.Models.ViewModels;

namespace PracticeSession.Web.Controllers
{
    public class HomePageController : PageController<HomePage>
    {
        public ActionResult Index(HomePage currentPage)
        {
            var model = new PageViewModel<HomePage>(currentPage);
            
            return View(model);
        }
    }
}