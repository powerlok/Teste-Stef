using System.Collections.Generic;
using Examples.Charge.Application.Common.Messages;
using Examples.Charge.Application.Dtos;

namespace Examples.Charge.Application.Messages.Response
{
	public class PhoneNumberTypeResponse : BaseResponse
	{
		public List<PhoneNumberTypeDto> PhoneNumberObjects { get; set; }
        public PhoneNumberTypeDto PhoneNumberType { get; set; }
    }
}
