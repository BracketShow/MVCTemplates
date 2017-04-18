namespace MVCTemplates.ViewModels.Person
{
    public class PersonDetailViewModel
    {
        public PersonDetailViewModel()
        {
            Person = new Models.Person();
        }

        public Models.Person Person { get; set; }

    }
}