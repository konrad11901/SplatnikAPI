﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Splatnik.Contracts.V1.Requests
{
    public class UpdateDebtRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal InitialValue { get; set; }
        public int BudgetId { get; set; }
    }
}
