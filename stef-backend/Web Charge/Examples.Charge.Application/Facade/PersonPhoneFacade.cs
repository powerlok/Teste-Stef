using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;

namespace Examples.Charge.Application.Facade
{
	public class PersonPhoneFacade : IPersonPhoneFacade
	{
		public PersonPhoneFacade(IPersonPhoneService personPhoneService, IMapper mapper)
		{
			_personPhoneService = personPhoneService;
			_mapper = mapper;
		}

		private readonly IPersonPhoneService _personPhoneService;
		private readonly IMapper _mapper;

		public async Task<PersonPhoneResponse> FindAllAsync()
		{
			var result = await _personPhoneService.FindAllAsync();
			var response = new PersonPhoneResponse();
			response.PersonPhoneObjects = new List<PersonPhoneDto>();
			response.PersonPhoneObjects.AddRange(result.Select(x => _mapper.Map<PersonPhoneDto>(x)));
			return response;
		}

		public async Task<PersonPhoneResponse> FindAllByIdAsync(int businessEntityID)
		{
			var result = await _personPhoneService.FindAllByIdAsync(businessEntityID);
			var response = new PersonPhoneResponse();
			response.PersonPhoneObjects = new List<PersonPhoneDto>();
			response.PersonPhoneObjects.AddRange(result.Select(x => _mapper.Map<PersonPhoneDto>(x)));
			return response;
		}

        public async Task<PersonPhoneResponse> PutAsync(PersonPhoneRequest person)
        {
			var result = await _personPhoneService.PutAsync(_mapper.Map<PersonPhone>(person));
            var response = new PersonPhoneResponse();
            response.PersonPhoneObject = _mapper.Map<PersonPhoneDto>(result);
            return response;
		}
    }
}
