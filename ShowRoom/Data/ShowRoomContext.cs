using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShowRoom.Models;

namespace ShowRoom.Data
{
    public class ShowRoomContext : DbContext
    {
        public ShowRoomContext (DbContextOptions<ShowRoomContext> options)
            : base(options)
        {
        }

        public DbSet<ShowRoom.Models.Car> Car { get; set; } = default!;

        public DbSet<ShowRoom.Models.Company>? Company { get; set; }
    }
}
