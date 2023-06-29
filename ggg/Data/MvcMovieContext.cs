using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ggg.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<ggg.Models.Lophoc> Lophoc { get; set; } = default!;

        public DbSet<ggg.Models.Sinhvien> Sinhvien { get; set; } = default!;
    }
}
