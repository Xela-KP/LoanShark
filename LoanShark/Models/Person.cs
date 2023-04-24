using System;
namespace LoanShark.Models
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Mobile { get; set; }
		public string Email { get; set; }
		LinkedList<FinancialLiability> FinancialLiabilities = new LinkedList<FinancialLiability>();
	}
}
