using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ControleDeUsuario.Models
{
    public class ControleUsuarioContext : DbContext
    {
        public ControleUsuarioContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ControleUsuario> ControleUsuarios { get; set; }
    }
}