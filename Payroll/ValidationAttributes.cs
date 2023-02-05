using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp
{
	// TODO implement
	public class IBANAttribute : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			return ValidationResult.Success;
		}
	}

	// TODO implement
	public class PIDAttribute : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			return ValidationResult.Success;
		}
	}

	// TODO implement
	public class JOPPDAttribute : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			return ValidationResult.Success;
		}
	}

	// TODO implement
	public class TaxBracketLowerBoundAttribute : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			return ValidationResult.Success;
		}
	}

	// TODO implement
	public class TaxBracketUpperBoundAttribute : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			return ValidationResult.Success;
		}
	}

	// TODO implement
	public class StartDateAttribute : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			return ValidationResult.Success;
		}
	}

	// TODO implement
	public class EndDateAttribute : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			return ValidationResult.Success;
		}
	}
}

