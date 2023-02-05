using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.TaxData.Models
{
    public class TaxBreak
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = default!;

        [Range(0, 100)]
        public float Rate { get; set; }
        public bool Retired { get; set; } = false;
    }
}

