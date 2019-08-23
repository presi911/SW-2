using System;
using System.Collections.Generic;
using System.Text;
using UC_Parking_Domain_Contracts.DomainEntities;

namespace UC_Parking_Domain_Contracts.Contracts
{
    public interface IUsuarioDomain
    {
        Boolean GuardarUsuario(String Cedula, string tipo, string nombre, string correo);
    
        IEnumerable<UsuarioDomain> getListaUsuarios();
    }
}
