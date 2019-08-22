using System;
using System.Collections.Generic;
using System.Text;
using UC_Parking_Domain_Contracts.DomainEntities;

namespace UC_Parking_Domain_Contracts.Contracts
{
    public interface IEspacioParqueoDomain
    {

        Boolean GuardarEspacioParqueo(string ubicacion, string descripcion);

        IEnumerable<EspacioParqueoDomain> GetlistaEspacios();
    }
}
