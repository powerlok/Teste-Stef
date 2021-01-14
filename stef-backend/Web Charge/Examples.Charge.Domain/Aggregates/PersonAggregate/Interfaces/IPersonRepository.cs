using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonRepository
    {
        Task<IEnumerable<PersonAggregate.Person>> FindAllAsync();
        Task<PersonAggregate.Person> FindAllByIdAsync(int businessEntityId);
        Task<PersonAggregate.Person> PostAsync(Person person);
        Task<PersonAggregate.Person> PutAsync(Person person);
    }
}
