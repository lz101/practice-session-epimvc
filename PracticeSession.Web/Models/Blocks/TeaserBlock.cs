using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PracticeSession.Web.Models.Blocks
{
    [ContentType(DisplayName = "Teaser Block", GUID = "850f7fb1-90bb-4e01-8250-dd9eed8e7dff", Description = "")]
    public class TeaserBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Name { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main Body",
            Description = "Write something",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }
    }
}