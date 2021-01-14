using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Domain.Aggregates.PersonAggregate;

namespace Examples.Charge.Application.Facade
{
	public class PersonFacade : IPersonFacade
	{
		private readonly IPersonService _personService;
		private readonly IMapper _mapper;

		public PersonFacade(IPersonService personService, IMapper mapper)
		{
			_personService = personService;
			_mapper = mapper;
		}

		public async Task<PersonResponse> FindAllAsync()
		{
			var result = await _personService.FindAllAsync();
			var response = new PersonResponse();
			response.PersonObjects = new List<PersonDto>();
			response.PersonObjects.AddRange(result.Select(x => _mapper.Map<PersonDto>(x)));
			return response;
		}

		public async Task<PersonObjectResponse> FindAllByIdAsync(int businessEntityId)
		{
			var result = await _personService.FindAllByIdAsync(businessEntityId);
			var response = new PersonObjectResponse();
            response.PersonObject = _mapper.Map<PersonDto>(result);
			return response;
		}

        public async Task<PersonObjectResponse> PutAsync(PersonRequest person)
		{
			var result = await _personService.PutAsync( _mapper.Map<Person>(person));
			var response = new PersonObjectResponse();
			response.PersonObject = _mapper.Map<PersonDto>(result);
			return response;
		}
	}
}
