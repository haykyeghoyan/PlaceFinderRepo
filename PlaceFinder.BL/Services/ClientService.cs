using AutoMapper;
using PlaceFinder.BL.DTOs;
using PlaceFinder.BL.ServiceInterfaces;
using PlaceFinder.DAL.Models;
using PlaceFinder.DAL.UoW;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.Services
{
    public class ClientService : IClientService
    {
        private IUnitOfWork unitOfWork;
        private IMapper _mapper;
        public ClientService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public ClientDTO GetClientById(int id)
        {
            var client = unitOfWork.ClientRepository.GetByID(id);
            ClientDTO _client = _mapper.Map<ClientDTO>(client);
            return _client;
            //return new ClientDTO{Id = client.Id,Name = client.Name};
        }

        public ClientDTO GetClientByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Insert(ClientDTO client)
        {
            Client _client = _mapper.Map<Client>(client);
            unitOfWork.ClientRepository.Insert(_client);
            unitOfWork.Save();
        }

        public void Update(ClientDTO client)
        {
            throw new NotImplementedException();
        }
        public void Delete(ClientDTO client)
        {
            throw new NotImplementedException();
        }
    }
}
