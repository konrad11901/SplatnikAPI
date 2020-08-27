﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Splatnik.Contracts.V1.Requests
{
	public class UserRegistrationRequest
	{
		[EmailAddress]
		public string Email { get; set; }
		public string Password { get; set; }
	}
}
