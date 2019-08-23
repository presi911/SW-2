using System;
using System.Collections.Generic;
using System.Text;
using UC_Parking_Domain_Contracts.Contracts;
using UC_Parking_Domain_Contracts.DomainEntities;
using UC_Parking_Persistence_Contracts.Contracts;
using UC_Parking_Persistence_Contracts.DbEntities;

namespace UC_Parking_Domain_Implementation.implementations
{
    public class EspacioParqueoImplementation : IEspacioParqueoDomain
    {


        IEspacioParqueoRepository _repository1;
      
        public EspacioParqueoImplementation(IEspacioParqueoRepository _repository)
        {
            this._repository1 = _repository;
        }

        public IEnumerable<EspacioParqueoDomain> GetlistaEspacios()
        {
            EspacioParqueoDomain v1 = new EspacioParqueoDomain() { Ubicacion = "parque", Descripcion = "es feo"};
            EspacioParqueoDomain v2 = new EspacioParqueoDomain() { Ubicacion = "parque", Descripcion = "es feo" };
            EspacioParqueoDomain v3 = new EspacioParqueoDomain() { Ubicacion = "parque", Descripcion = "es feo" };
            var list = new List<EspacioParqueoDomain>();
            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            return list;
        }


        public bool GuardarEspacioParqueo(string ubicacion, string descripcion)
        {
            EspacioParqueoDb v = new EspacioParqueoDb()
            {
                Ubicacion = ubicacion,
                Descripcion = descripcion
               
            };
            return this._repository1.GuardarEspacioParqueo(v);
        }

    }
}

