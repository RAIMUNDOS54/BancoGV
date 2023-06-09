﻿using BancoGV.Repositories;

namespace BancoGV.Services
{
    public class UserService
    {
        private readonly UserRepository userRepository = new();

        internal async Task<string> GetUserAsync(User user)
        {
            return await userRepository.LoginAsync(user);
        }
    }
}
