﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splatnik.API.Dtos
{
	public class ExpenseDto
	{
		public string UserId { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime ExpenseDate { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal ExpenseValue { get; set; }
		public int CurrencyId { get; set; }

		public int PeriodId { get; set; }
	}
}
