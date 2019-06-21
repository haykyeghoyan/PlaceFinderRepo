using AutoMapper;
using PlaceFinder.BL.DTOs;
using PlaceFinder.VMs;

namespace PlaceFinder.Profiles
{
    public class ClientProfilePL : Profile
    {
        public ClientProfilePL()
        {
            CreateMap<ClientDTO, ClientVM>();
        }
    }
}
