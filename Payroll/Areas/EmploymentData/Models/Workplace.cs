using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.EmploymentData.Models
{
    public class Workplace
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = default!;

        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float Salary { get; set; }
        public bool Retired { get; set; } = false;
    }
}

