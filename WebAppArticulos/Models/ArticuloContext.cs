using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppArticulos.Models
{
    public class ArticuloContext : DbContext{
        public ArticuloContext(DbContextOptions<ArticuloContext> options) : base(options){

        }

        public DbSet<Categoria> Categorias { get; set; } //nombre de la tabla

        public DbSet<Producto> Productos { get; set; }
    }
}

//
