using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ExampleContext _context;

        public PersonRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Person>> FindAllAsync() => await Task.Run(() => _context.Person.ToListAsync());

        public async Task<Person> FindAllByIdAsync(int businessEntityId)
        {
            return await Task.Run(() => _context.Person.Include(x => x.Phones).FirstOrDefault(x => x.BusinessEntityID.Equals(businessEntityId)));
        }

        public async Task<Person> PostAsync(Person person)
        {
            return await Task.Run(() => _context.Person.Add(person).Entity);
        }

        public async Task<Person> PutAsync(Person person)
        {
            person = await Task.Run(() => _context.Person.Update(person).Entity);
            await _context.SaveChangesAsync();
            return person;
        }
    }
}
