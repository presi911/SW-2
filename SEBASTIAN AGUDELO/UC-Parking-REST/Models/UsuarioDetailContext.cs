using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC_Parking_REST.Models
{
    public class UsuarioDetailContext : DbContext
    {

        public UsuarioDetailContext(DbContextOptions<UsuarioDetailContext> options) : base(options)
        {

        }

        public DbSet<UsuarioDetail> UsuarioDetails { get; set; }
    }
}
