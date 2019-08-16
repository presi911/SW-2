using System;
using System.Collections.Generic;
using System.Text;

namespace UC_Parking_Domain_Contracts.DomainEntities
{
    public class VehiculoDomain
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String placa;

        public String Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private String propietario;

        public String Propietario
        {
            get { return propietario; }
            set { propietario = value; }
        }

        private String telefono;

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


    }
}
