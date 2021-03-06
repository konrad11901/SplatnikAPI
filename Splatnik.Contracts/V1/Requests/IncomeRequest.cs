﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Splatnik.Contracts.V1.Requests
{
	public class IncomeRequest
	{
		public DateTime IncomeDate { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal IncomeValue { get; set; }
		public int CurrencyId { get; set; }
		public int BudgetId { get; set; }
		public int PeriodId { get; set; }
	}
}
