using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SpaceX.Models
{
    public class SpaceXContext : DbContext
    {
        public DbSet<Astronaut> Astronauts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseMySql(@"Server=localhost;Port=8889;database=spacex;uid=root;pwd=root;");
    }
}
