using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Classroom_supplies.Model;

namespace ClassSupplies.Data
{
    public class ClassSuppliesContext : DbContext
    {
        public ClassSuppliesContext (DbContextOptions<ClassSuppliesContext> options)
            : base(options)
        {
        }

        public DbSet<Classroom_supplies.Model.ClassroomSupply> ClassroomSupplies { get; set; } = default!;
    }
}
