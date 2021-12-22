#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GrxTest2.Models;

namespace GrxTest2.Data
{
    public class GrxTest2Context : DbContext
    {
        public GrxTest2Context (DbContextOptions<GrxTest2Context> options)
            : base(options)
        {
        }

        public DbSet<GrxTest2.Models.Person> Person { get; set; }
    }
}
