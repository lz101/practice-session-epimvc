using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using PracticeSession.Web.Models.Blocks;

namespace PracticeSession.Web.Controllers.Partials
{
    public class TeaserBlockController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            return PartialView("Blocks/TeaserBlock", currentBlock);
        }
    }
}
