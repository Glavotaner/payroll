using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.EmploymentData.Models
{
    public class ContractType
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = default!;
        public bool Retired { get; set; } = false;
    }
}

