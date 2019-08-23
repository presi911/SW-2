using System;
using System.Collections.Generic;
using System.Text;

namespace UC_Parking_Domain_Contracts.DomainEntities
{
    public class UsuarioDomain

    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String tipo;

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String correo;

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private String cedula;

        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

    }
}

