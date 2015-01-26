using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace PracticeSession.Web.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : PageData
    {
        public PageViewModel()
        {

        }

        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; set; }
    }
}