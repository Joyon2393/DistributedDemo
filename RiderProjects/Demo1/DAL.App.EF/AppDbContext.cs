using System;
using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.App.EF
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Contact> Contacts { get; set; }= default!;
        public DbSet<Person> Persons { get; set; }= default!;
        public DbSet<ContactType> ContactTypes { get; set; }= default!;
        
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
            
        }
    }
}