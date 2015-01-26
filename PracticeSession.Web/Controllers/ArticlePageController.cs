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
    public class ArticlePageController : PageController<ArticlePage>
    {
        public ActionResult Index(ArticlePage currentPage)
        {
            var model = new PageViewModel<ArticlePage>(currentPage);
            return View(model);
        }
    }
}