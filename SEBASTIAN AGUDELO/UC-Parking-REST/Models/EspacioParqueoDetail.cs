using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UC_Parking_REST.Models
{
    public class EspacioParqueoDetail
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(6)")]
        public string TamaoM2 { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string Ubicacion { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string TipoEspecial { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string EspacioLibre { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string Descripcion { get; set; }

    }
}
