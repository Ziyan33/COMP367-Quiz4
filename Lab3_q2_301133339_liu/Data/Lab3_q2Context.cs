using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab3_q2_301133339_liu.Models;

namespace Lab3_q2_301133339_liu.Data
{
    public class Lab3_q2Context : DbContext
    {
        public Lab3_q2Context (DbContextOptions<Lab3_q2Context> options)
            : base(options)
        {
        }

        public DbSet<Lab3_q2_301133339_liu.Models.Movie> Movie { get; set; } = default!;
    }
}
