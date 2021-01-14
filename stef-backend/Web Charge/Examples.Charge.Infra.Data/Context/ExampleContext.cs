﻿using Microsoft.EntityFrameworkCore;
using Examples.Charge.Domain.Aggregates.ExampleAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using System.Reflection;

namespace Examples.Charge.Infra.Data.Context
{
    public sealed class ExampleContext : DbContext
    {
        public ExampleContext(DbContextOptions<ExampleContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ExampleContext)));
        }

        public DbSet<Example> Example { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonPhone> PersonPhone { get; set; }
        public DbSet<PhoneNumberType> PhoneNumberType { get; set; }
    }
}