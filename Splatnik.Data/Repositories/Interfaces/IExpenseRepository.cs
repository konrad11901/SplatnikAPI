﻿using Splatnik.Data.Database.DbModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Splatnik.Data.Repositories.Interfaces
{
	public interface IExpenseRepository
	{
		Task<IList<Expense>> GetExpensesForPeriodAsync(int periodId);

	}
}
