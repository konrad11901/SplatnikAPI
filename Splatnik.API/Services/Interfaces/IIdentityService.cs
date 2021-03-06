﻿using Microsoft.AspNetCore.Identity;
using Splatnik.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splatnik.API.Services.Interfaces
{
	public interface IIdentityService
	{
		Task<AuthenticationResult> RegisterAsync(string email, string password);
		Task<AuthenticationResult> LoginAsync(string email, string password);
		Task<AuthenticationResult> RefreshTokenAsync(string token, string refreshToken);
		Task<IdentityResult> ConfirmEmail(string username, string identityToken);
		Task<bool> CheckIfUserExists(string userId);
	}
}
