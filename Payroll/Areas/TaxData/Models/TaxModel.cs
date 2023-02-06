using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.TaxData.Models
{
    public class TaxModel
    {
        public int Id { get; set; }

        [Display(Name = "Tax Brackets")]
        public virtual ICollection<TaxBracket> TaxBrackets { get; set; } = default!;

        [Display(Name = "Valid From")]
        [DataType(DataType.Date), Column(TypeName = "date")]
        public DateTime ValidFrom { get; set; }
    }
}

