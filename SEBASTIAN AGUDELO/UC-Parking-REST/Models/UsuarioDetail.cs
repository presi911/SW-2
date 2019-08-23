using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UC_Parking_REST.Models
{
    public class UsuarioDetail
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(6)")]
        public string Tipo { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string Apellidos { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string Correo { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string Cedula { get; set; }

    }
}
