using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.HoursData.Models
{
    public class HourTypeCoefficient
    {
        public int Id { get; set; }

        public virtual HourType HourType { get; set; } = default!;

        [Range(0, 1)]
        public float Coefficient { get; set; }

        [Display(Name = "Valid From")]
        [DataType(DataType.Date), Column(TypeName = "date")]
        public DateTime ValidFrom { get; set; }
    }
}

