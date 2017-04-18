using System;
using System.Collections.Generic;
using MVCTemplates.Models;

namespace MVCTemplates.Services
{
    public class PersonService
    {
        private static readonly Lazy<PersonService> Lazy =
            new Lazy<PersonService>(() => new PersonService());

        public static PersonService Instance => Lazy.Value;

        private PersonService()
        {
            Persons = new List<Person>()
            {
                new Person()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Bruno",
                    LastName = "Barrette",
                    City = "Laval"
                },
                new Person()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Éric",
                    LastName = "De Carufel",
                    City = "Laval"
                }
            };
        }

        public IList<Person> Persons { get; set; }

    }
}