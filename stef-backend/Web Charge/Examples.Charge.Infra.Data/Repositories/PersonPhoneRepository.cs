using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonPhoneRepository : IPersonPhoneRepository
    {
        private readonly ExampleContext _context;

        public PersonPhoneRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<PersonPhone>> FindAllAsync() => await Task.Run(() => _context.PersonPhone);
        public async Task<IEnumerable<PersonPhone>> FindAllByIdAsync(int businessEntityID) => await Task.Run(() => _context.PersonPhone.Where(x => x.BusinessEntityID.Equals(businessEntityID)));

        public async Task<PersonPhone> PutAsync(PersonPhone personPhone)
        {
            personPhone = await Task.Run(() => _context.PersonPhone.Update(personPhone).Entity);
            await _context.SaveChangesAsync();
            return personPhone;
        }
    }
}
