
using PlaceFinder.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.ServiceInterfaces
{
    public interface IClientService
    {
        ClientDTO GetClientById(int id);
        ClientDTO GetClientByName(string name);
        void Insert(ClientDTO client);
        void Update(ClientDTO client);
        void Delete(ClientDTO client);
    }
}
