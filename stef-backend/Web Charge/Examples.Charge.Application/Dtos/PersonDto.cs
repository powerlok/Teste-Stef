using Examples.Charge.Domain.Aggregates.PersonAggregate;
using System.Collections.Generic;

namespace Examples.Charge.Application.Dtos
{
	public class PersonDto
    {
		public int BusinessEntityId { get; set; }
	    public string Name { get; set; }
        public ICollection<PersonPhone> Phones { get; set; }
	}
}
