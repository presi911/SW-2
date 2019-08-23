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


        private String tamanoM2;

        public String TamanoM2
        {
            get { return tamanoM2; }
            set { tamanoM2 = value; }
        }
        private String ubicacion;

        public String Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        private Boolean tipoEspecial;

        public Boolean TipoEspecial
        {
            get { return tipoEspecial; }
            set { tipoEspecial = value; }
        }



        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private String estadisticasOcupacion;

        public String EstadisticasOcupacion
        {
            get { return estadisticasOcupacion; }
            set { estadisticasOcupacion = value; }
        }

    }


}

