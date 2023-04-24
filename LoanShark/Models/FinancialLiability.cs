using System;
namespace LoanShark.Models
{
	public abstract class FinancialLiability
	{
		public string Name { get; set; }
		public double Amount { get; set; }
	}
}
