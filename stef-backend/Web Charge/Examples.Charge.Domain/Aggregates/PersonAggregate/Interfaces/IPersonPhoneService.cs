using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
	public interface IPersonPhoneService
    {
	    Task<List<PersonPhone>> FindAllAsync();
	    Task<List<PersonPhone>> FindAllByIdAsync(int businessEntityID);
        Task<PersonPhone> PutAsync(PersonPhone person);
    }
}
