using System;
using System.Collections.Generic;
using System.Text;

namespace UC_Parking_Persistence_Contracts.DbEntities
{
    public class UsuarioDB
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
            get { return Tipo; }
            set { Tipo = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private String correo;

        public String Correo
        {
            get { return Correo; }
            set { Correo = value; }
        }
        private String cedula;

        public String Cedula
        {
            get { return Cedula; }
            set { Cedula = value; }
        }

    }
}