﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Splatnik.Contracts.V1.Requests
{
	public class CreateBudgetRequest
	{

		public string Name { get; set; }

		public string Description { get; set; }

		public string UserId { get; set; }
	}
}
