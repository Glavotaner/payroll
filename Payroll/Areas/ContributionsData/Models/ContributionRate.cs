using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.CalculationData.Models
{
    public class ContributionRate
    {
        public int Id { get; set; }

        public virtual Contribution Contribution { get; set; } = default!;

        [Range(0, 100)]
        public float Rate { get; set; }

        [Display(Name = "Valid From")]
        [DataType(DataType.Date)]
        public DateTime ValidFrom { get; set; }
    }
}

