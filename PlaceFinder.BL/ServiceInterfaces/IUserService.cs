using PlaceFinder.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.ServiceInterfaces
{
    public interface IUserService
    {
        UserDTO GetUserById(int id);
        UserDTO GetUserByName(string name);
        void Insert(UserDTO user);
        void Update(UserDTO user);
        void Delete(UserDTO user);
    }
}
