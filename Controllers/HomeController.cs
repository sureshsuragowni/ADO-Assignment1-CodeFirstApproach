using FootBallCodeFirstAppr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootBallCodeFirstAppr.Controllers
{
    public class HomeController : Controller
    {

        FootBallContext context = new FootBallContext();
        public ActionResult Index()
        {
            return View(context.FootBalls);
        }

        public ActionResult AddResult()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveResult(FootBall ft)
        {
            context.FootBalls.Add(ft);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}