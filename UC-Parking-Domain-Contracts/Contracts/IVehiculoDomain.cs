using System;
using System.Collections.Generic;
using System.Text;
using UC_Parking_Domain_Contracts.DomainEntities;

namespace UC_Parking_Domain_Contracts.Contracts
{
    public interface IVehiculoDomain
    {
        Boolean GuardarVehiculo(String placa, String propietario, String telefono);

        IEnumerable<VehiculoDomain> getListaVehiculos();
    }
}
