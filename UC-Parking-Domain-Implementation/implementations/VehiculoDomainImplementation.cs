using System;
using System.Collections.Generic;
using System.Text;
using UC_Parking_Domain_Contracts.Contracts;
using UC_Parking_Domain_Contracts.DomainEntities;
using UC_Parking_Persistence_Contracts.Contracts;
using UC_Parking_Persistence_Contracts.DbEntities;

namespace UC_Parking_Domain_Implementation.implementations
{
    public class VehiculoDomainImplementation : IVehiculoDomain
    {


        IVehiculoRepository _repository;
        public VehiculoDomainImplementation(IVehiculoRepository _repository)
        {
            this._repository = _repository;
        }

        public IEnumerable<VehiculoDomain> getListaVehiculos()
        {
            VehiculoDomain v1 = new VehiculoDomain() { Id=1, Placa="UET551", Propietario="Pepito", Telefono="886787678" };
            VehiculoDomain v2 = new VehiculoDomain() { Id = 2, Placa = "UET551", Propietario = "Pepito", Telefono = "886787678" };
            VehiculoDomain v3 = new VehiculoDomain() { Id = 3, Placa = "UET551", Propietario = "Pepito", Telefono = "886787678" };
            var list = new List<VehiculoDomain>();
            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            return list;

        }

        public bool GuardarVehiculo(string placa, string propietario, string telefono)
        {
            VehiculoDb v = new VehiculoDb()
            {
                Placa = placa,
                Propietario = propietario,
                Telefono = telefono
            };
            return this._repository.GuardarVehiculo(v);
        }
    }
}
