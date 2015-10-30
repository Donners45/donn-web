using DonnWeb.IoC;
using DonnWeb.UiControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DonnWeb.Controllers
{
    public class ScoreController : Controller
    {

        UiScoreController _UiController;

        public ScoreController()
        {
            _UiController = IoCContainer.ContainerContext.GetInstance<UiScoreController>();
        }

        //
        // GET: /Score/
        public ActionResult Index()
        {
            var m = _UiController.GetModel();

            return PartialView("TotalScore", m);
        }

    }
}
