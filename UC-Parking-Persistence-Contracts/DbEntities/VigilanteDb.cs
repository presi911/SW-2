using System;
using System.Collections.Generic;
using System.Text;

namespace UC_Parking_Persistence_Contracts.DbEntities
{
    public class VigilanteDb
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String cedula;

        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }   

        private String nombres;

        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private String apellidos;

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }


        private String telefono;

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private String correo;

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }


    }
}
