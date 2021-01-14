using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;

namespace Examples.Charge.Application.Facade
{
	public class PhoneNumberTypeFacade : IPhoneNumberTypeFacade
	{
		public PhoneNumberTypeFacade(IPhoneNumberTypeService phoneNumberTypeService, IMapper mapper)
		{
			_phoneNumberTypeService = phoneNumberTypeService;
			_mapper = mapper;
		}

		private readonly IPhoneNumberTypeService _phoneNumberTypeService;
		private readonly IMapper _mapper;

		public async Task<PhoneNumberTypeResponse> FindAllAsync()
		{
			var result = await _phoneNumberTypeService.FindAllAsync();
			var response = new PhoneNumberTypeResponse();
			response.PhoneNumberObjects = new List<PhoneNumberTypeDto>();
			response.PhoneNumberObjects.AddRange(result.Select(x => _mapper.Map<PhoneNumberTypeDto>(x)));
			return response;
		}

        public async Task<PhoneNumberTypeResponse> FindAllByIdAsync(int phoneNumberTypeId)
        {
			var result = await _phoneNumberTypeService.FindAllByIdAsync(phoneNumberTypeId);
            var response = new PhoneNumberTypeResponse();
            response.PhoneNumberType = _mapper.Map<PhoneNumberTypeDto>(result);
            return response;
		}
    }
}
