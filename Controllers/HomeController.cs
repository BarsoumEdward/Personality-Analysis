using PersonalityAnalysis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalityAnalysis.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home


        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Test()
        {
            return View();
        }
         
        [HttpPost]
        public ActionResult Test(PersonalityQuestion question)
        {
            if (ModelState.IsValid)
            {

                ViewBag.name = question.Name;
                int sum = question.BestFeeling + question.WalkWay + question.SpeakingWithOther + question.Relaxing + question.SmilingWay +
                         question.EnteringWay + question.ReactionWay + question.BestColor + question.SleepingWay + question.RepeatDream;
                return View("Result", sum);
            }
            else { return View(); }
        }

        public ActionResult Haha()
        {
            return View();
        }
    }
}