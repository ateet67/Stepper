using Stepper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stepper.Controllers
{
    public class HomeController : Controller
    {
        public static List<question> questions = new questionList().questionsList;
        public ActionResult Index()
        {
            return View(questions);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult OnAnswer(question quesns)
        {
            question question = questions.Find(x => x.id == quesns.id);
            questions[questions.FindIndex(x => x.id == quesns.id)].isAnswered = true;
            questions[questions.FindIndex(x => x.id == quesns.id)].selectedOption = quesns.selectedOption;
            return RedirectToAction("Index");
        }
    }
}