﻿using Splatnik.Contracts.V1.Requests;
using Splatnik.Data.Database.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splatnik.API.Services.Interfaces
{
	public interface IIncomeService
	{
		Task<Income> NewIncomeAsync(IncomeRequest request, string userId);
		Task<Income> GetIncomeAsync(int incomeId);
		Task<IList<Income>> GetIncomesAsync(int periodId);
		Task<bool> UpdateIncomeAsync(int incomeId, UpdateIncomeRequest request);
		Task<bool> DeleteIncomeAsync(Income income);
	}
}
