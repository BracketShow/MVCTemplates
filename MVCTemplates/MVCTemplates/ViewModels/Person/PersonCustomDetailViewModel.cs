using System.ComponentModel.DataAnnotations;

namespace MVCTemplates.ViewModels.Person
{
    public class PersonCustomDetailViewModel
    {
        public PersonCustomDetailViewModel()
        {
            Person = new Models.Person();
        }

        [UIHint("CustomPerson")]
        public Models.Person Person { get; set; }

    }
}