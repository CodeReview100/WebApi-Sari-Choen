﻿using Entities;

namespace Service
{
    public interface IUserService
    {
        User AddUser(User user);
        int CheckPwd(string password);
        User GetUserByEmailAndPassword(string email, string password);
        User GetUserById(int id);
        User UpdateUser(int id, User user);
    }
}