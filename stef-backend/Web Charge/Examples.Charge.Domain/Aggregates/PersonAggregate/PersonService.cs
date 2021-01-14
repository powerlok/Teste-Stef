using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<List<Person>> FindAllAsync()
        {
          return (List<Person>) await _personRepository.FindAllAsync();
        } 

        public async Task<Person> FindAllByIdAsync(int businessEntityId)
        {
          return await _personRepository.FindAllByIdAsync(businessEntityId);
        } 

        public async Task<Person> PostAsync(Person person)
        {
            return await _personRepository.PostAsync(person);
        }

        public async Task<Person> PutAsync(Person person)
        {
            return await _personRepository.PutAsync(person);
        } 
    }
}
