#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Anjeluzrazorpages.Pages.fashion;

namespace Anjeluzrazorpages.Data
{
    public class AnjeluzrazorpagesContext : DbContext
    {
        public AnjeluzrazorpagesContext (DbContextOptions<AnjeluzrazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<Anjeluzrazorpages.Pages.fashion.Class> Class { get; set; }
    }
}
