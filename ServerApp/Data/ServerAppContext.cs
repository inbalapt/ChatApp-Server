using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServerApp.Models;

namespace ServerApp.Data
{
    public class ServerAppContext : DbContext
    {
        public ServerAppContext (DbContextOptions<ServerAppContext> options)
            : base(options)
        {
        }

        public DbSet<ServerApp.Models.Rate>? Rate { get; set; }

        public DbSet<ServerApp.Models.Contact>? Contact { get; set; }

        public DbSet<ServerApp.Models.Message>? Message { get; set; }
    }
}
