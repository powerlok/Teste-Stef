using System.Collections.Generic;
using Examples.Charge.Application.Common.Messages;
using Examples.Charge.Application.Dtos;

namespace Examples.Charge.Application.Messages.Response
{
	public class PersonPhoneResponse : BaseResponse
	{
		public List<PersonPhoneDto> PersonPhoneObjects { get; set; }
		public PersonPhoneDto PersonPhoneObject { get; set; }
	}
}
