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
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public UserDTO GetUserByName(string name)
        {
            throw new NotImplementedException();
        }

        public UserDTO GetUserById(int id)
        {
            var user = _unitOfWork.UserRepository.GetByID(id);
            UserDTO _user = _mapper.Map<UserDTO>(user);
            return _user;
        }

        public void Insert(UserDTO user)
        {
            User _user = _mapper.Map<User>(user);
            _unitOfWork.UserRepository.Insert(_user);
            _unitOfWork.Save();
        }

        public void Update(UserDTO user)
        {
            User _user = _mapper.Map<User>(user);
            _unitOfWork.UserRepository.Update(_user);
            _unitOfWork.Save();
        }

        public void Delete(UserDTO user)
        {
            User _user = _mapper.Map<User>(user);
            _unitOfWork.UserRepository.Delete(_user);
            _unitOfWork.Save();
        }
    }
}
