using System.Collections.Generic;

namespace MVCTemplates.ViewModels.Home
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel()
        {
            Persons = new List<Models.Person>();
        } 

        public IList<Models.Person> Persons { get; set; }

    }
}