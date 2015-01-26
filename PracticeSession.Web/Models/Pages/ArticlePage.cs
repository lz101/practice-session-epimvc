using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace PracticeSession.Web.Models.Pages
{
    [ContentType(DisplayName = "Article Page", GUID = "66ea44f5-f262-4aae-89a5-8b71bdb15cc4", Description = "")]
    public class ArticlePage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }

    }
}