using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.Core;
using PracticeSession.Web.Models.Pages;

namespace PracticeSession.Web.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : PageData
    {
        T CurrentPage { get; }
    }
}
