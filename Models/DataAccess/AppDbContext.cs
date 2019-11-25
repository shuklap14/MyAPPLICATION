using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models.DataAccess
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Recall> Recall { get; set; }
        // public object Recall { get; internal set; }
    }
}
