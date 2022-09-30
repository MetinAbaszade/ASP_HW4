using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_HW4.Entities;

namespace ASP_HW4.Data
{
    public class TeacherContext : DbContext
    {
        public TeacherContext (DbContextOptions<TeacherContext> options)
            : base(options)
        {
        }

        public DbSet<Teacher> Teacher { get; set; }
    }
}
