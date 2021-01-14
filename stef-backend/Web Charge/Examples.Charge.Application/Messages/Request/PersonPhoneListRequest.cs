using System.Collections.Generic;

namespace Examples.Charge.Application.Messages.Request
{
	public class PersonPhoneListRequest
	{
		public ICollection<PersonPhoneRequest> Phones { get; set; }
	}
}
