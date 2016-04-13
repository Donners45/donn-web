using DonnWeb.UiControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DonnWeb.Controllers
{
    public class BlogController : Controller
    {
        private readonly UIBlogItemController _uiController;

        public BlogController()
        {
            _uiController = IoC.IoCContainer.ContainerContext.GetInstance<UIBlogItemController>();
        }

        public ActionResult Index()
        {
            var model = _uiController.GetBlogItems();

            return PartialView("BlogSummaryListing", model);
        }

        public ActionResult ByUri(string uri)
        {
            var model = _uiController.GetBlogModelByUri(uri);
            return PartialView("BlogItem", model);
        }

    }
}
