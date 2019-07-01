using PlaceFinder.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.ServiceInterfaces
{
    public interface IPlaceService
    {
        PlaceDTO GetPlaceById(int id);
        PlaceDTO GetPlaceByName(string name);
        void Insert(PlaceDTO place);
        void Update(PlaceDTO place);
        void Delete(PlaceDTO place);
    }
}
