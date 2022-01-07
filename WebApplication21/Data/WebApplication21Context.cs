using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication21.Model;

namespace WebApplication21.Data
{
    public class WebApplication21Context : DbContext
    {
        public WebApplication21Context (DbContextOptions<WebApplication21Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication21.Model.Employee> Employee { get; set; }
    }
}
