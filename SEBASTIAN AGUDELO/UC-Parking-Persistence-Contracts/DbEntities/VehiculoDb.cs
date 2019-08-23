using System;
using System.Collections.Generic;
using System.Text;

namespace UC_Parking_Persistence_Contracts.DbEntities
{
    public class VehiculoDb
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

        private String marca;
        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private String color;

        public String Color
        {
            get { return color; }
            set { color = value; }
        }
        private String modelo;

        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private String motor;

        public String Motor
        {
            get { return motor; }
            set { motor = value; }
        }






    }
}