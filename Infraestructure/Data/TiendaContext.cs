using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data
{
    public class TiendaContext : DbContext
    {
        public TiendaContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Producto> Productos { get; set; }
    }
}