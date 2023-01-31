using System;
namespace Payroll.Areas.ReimbursementsData.Models
{
	public class Deductibles
	{
		public int Id { get; set; }
		public float Base { get; set; }
		public float Personal { get; set; }
		public float Dependent { get; set; }
		public float DisabledDependentPartial { get; set; }
		public float DisabledDependentFull { get; set; }
		public float FirstChild { get; set; }
        public float SecondChild { get; set; }
        public float ThirdChild { get; set; }
        public float FourthChild { get; set; }
        public float FifthChild { get; set; }
        public float SixthChild { get; set; }
        public float SeventhChild { get; set; }
        public float EighthChild { get; set; }
        public float NinthChild { get; set; }
        public float MultiplicationCoefficient { get; set; }
		public DateTime ValidFrom { get; set; }
	}
}

