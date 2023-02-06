using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.TaxData.Models
{
    public class TaxBracket
    {
        public int Id { get; set; }

        [Display(Name = "Lower Bound")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [TaxBracketLowerBound]
        public float LowerBound { get; set; }

        [Display(Name = "Upper Bound")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [TaxBracketUpperBound]
        public float? UpperBound { get; set; }

        [Range(0, 100)]
        public float Rate { get; set; }
    }
}

