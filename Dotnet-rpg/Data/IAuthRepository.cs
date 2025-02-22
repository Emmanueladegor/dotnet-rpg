﻿using System;
using System.Threading.Tasks;
using Dotnet_rpg.Models;

namespace Dotnet_rpg.Data
{
    public interface IAuthRepository
    { 
        Task<ServiceResponse<int>> Register(User user, string password);

        Task<ServiceResponse<string>> Login(string username, string password);

        Task<bool> UserExists(string username);
            
    }
}
