using AutoMapper;
using ProductOfferGrpcServices.Entities;
using ProductOfferGrpcServices.Protos;

namespace ProductOfferGrpcServices.AutoMapper
{
    public class UserOfferMapper: Profile
    {
        public UserOfferMapper()
        {
            CreateMap<Offer, UserOfferDetail>().ReverseMap();
        }
    }
}
