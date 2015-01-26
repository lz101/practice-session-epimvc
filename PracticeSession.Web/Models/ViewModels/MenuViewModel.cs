using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace PracticeSession.Web.Models.ViewModels
{
    public class MenuViewModel
    {
        public IEnumerable<IContent> MenuItems { get; set; } 
    }
}