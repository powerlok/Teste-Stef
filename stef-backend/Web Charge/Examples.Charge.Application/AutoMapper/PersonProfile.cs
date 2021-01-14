using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Domain.Aggregates.PersonAggregate;

namespace Examples.Charge.Application.AutoMapper
{
	public class PersonProfile : Profile
	{
		public PersonProfile()
		{
			CreateMap<Person, PersonDto>()
				.ReverseMap()
				.ForMember(dest => dest.BusinessEntityID, opt => opt.MapFrom(src => src.BusinessEntityId))
				.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.Phones, opt => opt.MapFrom(src => src.Phones));

			CreateMap<Person, PersonRequest>()
				.ReverseMap()
				.ForMember(dest => dest.BusinessEntityID, opt => opt.MapFrom(src => src.businessEntityID))
				.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nome))
				.ForMember(dest => dest.Phones, opt => opt.MapFrom(src => src.Phones));

		}
	}
}
