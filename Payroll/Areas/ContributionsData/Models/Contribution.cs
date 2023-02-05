using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.CalculationData.Models
{
    public class Contribution
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = default!;

        [Display(Name = "From Pay")]
        public bool FromPay { get; set; }

        public bool Retired { get; set; } = false;
    }
}

