using System.Collections.Generic;

namespace Examples.Charge.Application.Messages.Request
{
	public class PersonRequest
    {
	    public int businessEntityID { get; set; }
        public string Nome { get; set; }
        public ICollection<PersonPhoneListRequest> Phones { get; set; }
    }
}
