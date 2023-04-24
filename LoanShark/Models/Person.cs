using System;
namespace LoanShark.Models
{
	public class Person
	{
        private List<FinancialLiability> _financialLiabilities = new List<FinancialLiability>();
		public string Name { get; set; }
		public string Mobile { get; set; }
		public void AddLiability(FinancialLiability liability)
		{
			_financialLiabilities.Add(liability);
		}
		public double GetNetLiabilityAmount()
		{
			double total = 0;
			foreach(FinancialLiability liability in _financialLiabilities)
			{
				switch (liability)
				{
					case Debt:
						total += liability.Amount;
						break;
					case Loan:
						total -= liability.Amount;
						break;
					default:
						break;
				}
			}
			return total;
		}
	}
}