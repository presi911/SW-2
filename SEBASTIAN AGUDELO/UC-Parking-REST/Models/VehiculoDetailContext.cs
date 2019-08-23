using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC_Parking_REST.Models
{
    public class VehiculoDetailContext : DbContext
    {

        public VehiculoDetailContext(DbContextOptions<VehiculoDetailContext> options) : base(options)
        {

        }

        public DbSet<VehiculoDetail> VehiculoDetails { get; set; }
    }
}
