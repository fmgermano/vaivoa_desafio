using AutoMapper;
using vvef.Domain.Models;
using vvef.Resources;

namespace vvef.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Cliente, ClienteResource>();
        }
    }
}