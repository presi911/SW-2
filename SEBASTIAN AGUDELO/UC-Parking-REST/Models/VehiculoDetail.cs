using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UC_Parking_REST.Models
{
    public class VehiculoDetail
    {

        [Key]
        public int VHid { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(6)")]
        public string Placa { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string Propietario { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Phone { get; set; }

    }
}
