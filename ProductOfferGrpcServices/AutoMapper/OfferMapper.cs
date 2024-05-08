using AutoMapper;
using ProductOfferGrpcServices.Entities;
using ProductOfferGrpcServices.Protos;

namespace ProductOfferGrpcServices.AutoMapper
{
    public class OfferMapper: Profile
    {
        public OfferMapper()
        {
            CreateMap<Offer, OfferDetail>().ReverseMap();
        }
    }
}
