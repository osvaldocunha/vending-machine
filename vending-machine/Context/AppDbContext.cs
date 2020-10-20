using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using vending_machine.Models;

namespace vending_machine.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
         : base(options)
        {}
        //Mapping Entities
        public DbSet<Drink> Drinks { set; get; }
    }
}
