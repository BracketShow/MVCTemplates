using System;
using System.Linq;
using System.Web.Mvc;
using MVCTemplates.Services;
using MVCTemplates.ViewModels.Person;

namespace MVCTemplates.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index(Guid personId)
        {
            var persons = PersonService.Instance.Persons;
            var current = persons.Single(x => x.Id == personId);

            var viewModel = new PersonDetailViewModel()
            {
                Person = current
            };
            return View(viewModel);
        }

        public ActionResult CustomDisplay(Guid personId)
        {
            var persons = PersonService.Instance.Persons;
            var current = persons.Single(x => x.Id == personId);

            var viewModel = new PersonCustomDetailViewModel()
            {
                Person = current
            };
            return View(viewModel);
        }

        public ActionResult Edit(Guid personId)
        {
            var persons = PersonService.Instance.Persons;
            var current = persons.Single(x => x.Id == personId);

            var viewModel = new PersonDetailViewModel()
            {
                Person = current
            };

            return View(viewModel);
        }

        public ActionResult Save(PersonDetailViewModel viewModel)
        {
            var persons = PersonService.Instance.Persons;
            var current = persons.Single(x => x.Id == viewModel.Person.Id);

            var personIndex = persons.IndexOf(current);

            persons[personIndex] = viewModel.Person;

            return RedirectToAction("DisplayTemplates", "Home");
        }

    }
}