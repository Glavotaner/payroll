using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.PersonData.Models
{
    public class Person
    {
        [MaxLength(13), PID]
        public string PID { get; set; } = default!;

        [Display(Name = "First Name")]
        public string FirstName { get; set; } = default!;

        [Display(Name = "Last Name")]
        public string LastName { get; set; } = default!;

        [Display(Name = "Date of Birth"), DataType(DataType.Date), Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        public Disability? Disability { get; set; }
    }

    public enum Disability
    {
        Partial, Full
    }
}

