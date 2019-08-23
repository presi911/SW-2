using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC_Parking_REST.Models
{
    public class EspacioParqueoDetailContext : DbContext
    {

        public EspacioParqueoDetailContext(DbContextOptions<EspacioParqueoDetailContext> options) : base(options)
        {

        }

        public DbSet<EspacioParqueoDetail> EspacioParqueoDetails { get; set; }
    }
}
