using FinalEvanyeline.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvanyeline.Data
{
    public class DBContext:DbContext
    {

        public DBContext(DbContextOptions<DBContext> op) : base(op)
        {

        }
        public DbSet<Autores> autores { get; set; }
        public DbSet<Libros> libros { get; set; }
        public DbSet<Usuario> UsuarioLibro { get; set; }
        public DbSet<Ventas> ventas { get; set; }
    }
}
