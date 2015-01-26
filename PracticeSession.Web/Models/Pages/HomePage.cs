using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace PracticeSession.Web.Models.Pages
{
    [ContentType(
        DisplayName = "Home Page",
        GUID = "47262d94-0a44-451e-8c53-70e43fef73c4",
        Description = "This is the start page")]
    [AvailableContentTypes(Include = new[] { typeof(ArticlePage) })]
    public class HomePage : SitePageData
    {
        [Display(
            Name = "Teaser Areas", 
            Order = 200)]
        public virtual ContentArea TeaserArea { get; set; }
    }
}