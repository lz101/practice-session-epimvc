using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PracticeSession.Web.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Enter header here",
            Order = 1,
            GroupName = SystemTabNames.Content)]
        public virtual string Header { get; set; }
    }
}