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
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public ClientService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public ClientDTO GetClientById(int id)
        {
            var client = _unitOfWork.ClientRepository.GetByID(id);
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
            _unitOfWork.ClientRepository.Insert(_client);
            _unitOfWork.Save();
        }

        public void Update(ClientDTO client)
        {
            Client _client = _mapper.Map<Client>(client);
            _unitOfWork.ClientRepository.Update(_client);
            _unitOfWork.Save();
        }
        public void Delete(ClientDTO client)
        {
            Client _client = _mapper.Map<Client>(client);
            _unitOfWork.ClientRepository.Delete(_client);
            _unitOfWork.Save();
        }
    }
}
