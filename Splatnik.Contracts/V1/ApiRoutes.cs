﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Splatnik.Contracts.V1
{
	public class ApiRoutes
	{
		public const string Root = "api";
		public const string Version = "v1";
		public const string Base = Root + "/" + Version;

		public static class Identity
		{
			public const string Login = Base + "/identity/login";
			public const string Register = Base + "/identity/register";
			public const string Refresh = Base + "/identity/refresh";
			public const string CreateRole = Base + "/identity/createRole";
			public const string AssignRoleToUser = Base + "/identity/assignRole";

		}

		public static class Budget
		{
			public const string Create = Base + "/budget";
			public const string Get = Base + "/budget/{budgetId}";
		}
	}
}
