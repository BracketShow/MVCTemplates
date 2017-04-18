using System.Web.Mvc;
using MVCTemplates.Services;
using MVCTemplates.ViewModels.Home;

namespace MVCTemplates.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var persons = PersonService.Instance.Persons;
            var viewModel = new HomeIndexViewModel()
            {
                Persons = persons
            };

            return View(viewModel);
        }

        public ActionResult DisplayTemplates()
        {
            var persons = PersonService.Instance.Persons;
            var viewModel = new HomeIndexViewModel()
            {
                Persons = persons
            };

            return View(viewModel);
        }

    }
}