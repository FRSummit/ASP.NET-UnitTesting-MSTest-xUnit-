using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HumanResourceManagement.Dev.Models;

namespace HumanResourceManagement.Dev.Data
{
    public class HumanResourceManagementDevContext : DbContext
    {
        public HumanResourceManagementDevContext (DbContextOptions<HumanResourceManagementDevContext> options)
            : base(options)
        {
        }

        public DbSet<HumanResourceManagement.Dev.Models.Person> Person { get; set; }
        public DbSet<HumanResourceManagement.Dev.Models.Customer> Customer { get; set; }
    }
}
