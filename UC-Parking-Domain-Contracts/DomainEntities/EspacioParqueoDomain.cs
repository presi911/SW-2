using System;
using System.Collections.Generic;
using System.Text;

namespace UC_Parking_Domain_Contracts.DomainEntities
{
    public class EspacioParqueoDomain
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String ubicacion;

        public String Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        private String descripcion;

        public String Descripcion 
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private String estadisticas;

        public String Estadisticas
        {
            get { return estadisticas; }
            set { estadisticas = value; }
        }


    }


}

