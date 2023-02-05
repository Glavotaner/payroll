using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.EmploymentData.Models
{
    public class Workplace
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = default!;

        [DataType(DataType.Currency), Range(0, double.MaxValue)]
        public float Salary { get; set; }
        public bool Retired { get; set; } = false;
    }
}

