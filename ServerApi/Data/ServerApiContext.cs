using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServerApi.Models;

namespace ServerApi.Data
{
    public class ServerApiContext : DbContext
    {
        public ServerApiContext (DbContextOptions<ServerApiContext> options)
            : base(options)
        {
        }

        public DbSet<ServerApi.Models.User>? User { get; set; }
    }
}
