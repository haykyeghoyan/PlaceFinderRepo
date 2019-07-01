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
    public class PlaceService : IPlaceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PlaceService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public PlaceDTO GetPlaceByName(string name)
        {
            throw new NotImplementedException();
        }

        public PlaceDTO GetPlaceById(int id)
        {
            var place = _unitOfWork.PlaceRepository.GetByID(id);
            PlaceDTO _place = _mapper.Map<PlaceDTO>(place);
            return _place;
        }

        public void Insert(PlaceDTO place)
        {
            Place _place = _mapper.Map<Place>(place);
            _unitOfWork.PlaceRepository.Insert(_place);
            _unitOfWork.Save();
        }
              
        public void Update(PlaceDTO place)
        {
            Place _place = _mapper.Map<Place>(place);
            _unitOfWork.PlaceRepository.Update(_place);
            _unitOfWork.Save();
        }

        public void Delete(PlaceDTO place)
        {
            Place _place = _mapper.Map<Place>(place);
            _unitOfWork.PlaceRepository.Delete(_place);
            _unitOfWork.Save();
        }



    }
}
