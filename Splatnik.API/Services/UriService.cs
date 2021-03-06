﻿using Splatnik.API.Services.Interfaces;
using Splatnik.Contracts.V1;
using Splatnik.Data.Database.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splatnik.API.Services
{
	public class UriService : IUriService
	{
		private readonly string _baseUri;

		public UriService(string baseUri)
		{
			_baseUri = baseUri;
		}

		public Uri GetBudgetUri(int budgetId)
		{
			return new Uri(_baseUri + ApiRoutes.UserBudget.Budget
				.Replace("{budgetId}", budgetId.ToString()));
		}

		public Uri GetPeriodUri(int budgetId, int periodId)
		{
			return new Uri(_baseUri + ApiRoutes.UserBudget.BudgetPeriod
				.Replace("{budgetId}", budgetId.ToString())
				.Replace("{periodId}", periodId.ToString()));
		}

		public Uri GetConfirmationLink(string email, string token)
		{
			return new Uri(_baseUri + ApiRoutes.Identity.ConfirmEmail + "/" + email + "/" + token);
		}

		public Uri GetExpenseUri(int expenseId)
		{
			return new Uri(_baseUri + ApiRoutes.UserExpenses.BudgetPeriodExpense
				.Replace("{expenseId}", expenseId.ToString()));
		}

		public Uri GetIncomeUri(int incomeId)
		{
			return new Uri(_baseUri + ApiRoutes.UserExpenses.BudgetPeriodExpense
				.Replace("{incomeId}", incomeId.ToString()));
		}

		public Uri GetDebtUri(int debtId)
		{
			return new Uri(_baseUri + ApiRoutes.UserDebts.BudgetDebt
				.Replace("{debtId}", debtId.ToString()));
		}

		public Uri GetDebtPaymentUri(int debtId, int debtPaymentId)
		{
			return new Uri(_baseUri + ApiRoutes.UserDebts.BudgetDebtPayments
				.Replace("{debtId}", debtId.ToString())
				.Replace("{debtPaymentId}", debtPaymentId.ToString()));
		}

		public Uri GetCreditUri(int creditId)
		{
			return new Uri(_baseUri + ApiRoutes.UserCredits.BudgetCredit
				.Replace("{creditId}", creditId.ToString()));
		}

		public Uri GetCreditPaymentUri(int creditId, int creditPaymentId)
		{
			return new Uri(_baseUri + ApiRoutes.UserCredits.BudgetCreditPayments
				.Replace("{creditId}", creditId.ToString())
				.Replace("{creditPaymentId}", creditPaymentId.ToString()));
		}
	}
}
