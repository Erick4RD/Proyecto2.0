using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EasyApplication.Models;

namespace EasyApplication.Data
{
    public class EasyApplicationContext : DbContext
    {
        public EasyApplicationContext (DbContextOptions<EasyApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<EasyApplication.Models.Categoria> Categoria { get; set; }
    }
}
