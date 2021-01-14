using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonPhoneService : IPersonPhoneService
    {
        private readonly IPersonPhoneRepository _personPhoneRepository;
        public PersonPhoneService(IPersonPhoneRepository personPhoneRepository)
        {
            _personPhoneRepository = personPhoneRepository;
        }

        public async Task<List<PersonPhone>> FindAllAsync() => (await _personPhoneRepository.FindAllAsync()).ToList();

		public async Task<List<PersonPhone>> FindAllByIdAsync(int businessEntityID) => (await _personPhoneRepository.FindAllByIdAsync(businessEntityID)).ToList();

        public async Task<PersonPhone> PutAsync(PersonPhone person)
        {
            return await _personPhoneRepository.PutAsync(person);
        }
    }
}
