using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager.Models;
namespace TaskManager.Data
{
    public class MvcJobContext : DbContext
    {
        public MvcJobContext(DbContextOptions<MvcJobContext> options)
                    : base(options)
        {
        }
        public DbSet<Job> Job { get; set; }

    }
}
