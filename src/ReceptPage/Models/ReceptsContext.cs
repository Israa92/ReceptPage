using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace ReceptPage.Models
{
    public class ReceptsContext : DbContext
    {
        public DbSet<Recept> Recepts { get; set; }
    }
}
