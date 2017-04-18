using System;
using System.ComponentModel.DataAnnotations;

namespace MVCTemplates.Models
{
    public class Person
    {
        public Guid Id { get; set; }

        [Display(Name = "Prénom")]
        public string FirstName { get; set; } 

        [Display(Name = "Nom")]
        public string LastName { get; set; }

        [Display(Name = "Ville")]
        public string City { get; set; }
    }
}