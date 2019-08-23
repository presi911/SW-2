using System;
using System.Collections.Generic;
using System.Text;
using UC_Parking_Domain_Contracts.DomainEntities;

namespace UC_Parking_Domain_Contracts.Contracts
{
    public interface IVigilanteDomain
    {
        Boolean GuardarVigilante(String cedula, String nombres, String apellidos, String telefono, String correo);

        IEnumerable<VigilanteDomain> GetListaVigilantes();
    }
}
