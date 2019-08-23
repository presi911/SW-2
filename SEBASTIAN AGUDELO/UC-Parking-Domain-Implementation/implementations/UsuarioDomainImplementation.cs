using System;
using System.Collections.Generic;
using System.Text;
using UC_Parking_Domain_Contracts.Contracts;
using UC_Parking_Domain_Contracts.DomainEntities;
using UC_Parking_Persistence_Contracts.Contracts;
using UC_Parking_Persistence_Contracts.DbEntities;

namespace UC_Parking_Domain_Implementation.implementations
{
    public class UsuarioDomainImplementation :IUsuarioDomain
    {
        IUsuarioRepository _repository;
        public UsuarioDomainImplementation(IUsuarioRepository _repository)
        {
            this._repository = _repository;
        }

        public IEnumerable<UsuarioDomain> getListaUsuarios()
        {
              UsuarioDomain v1 = new UsuarioDomain() { Id = 1, Tipo = "UET551", Correo = "886787678", Cedula = "Pepito", Nombre = "886787678" };
            UsuarioDomain v2 = new UsuarioDomain() { Id = 1, Tipo = "UET551", Correo = "886787678", Cedula = "Pepito", Nombre = "886787678" };
            UsuarioDomain v3 = new UsuarioDomain() { Id = 1, Tipo = "UET551", Correo = "886787678", Cedula = "Pepito", Nombre = "886787678" };
            var list = new List<UsuarioDomain>();
            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            return list;
        }

        
        

        

        public bool GuardarUsuario(String Cedula,string tipo, string nombre, string correo)
        {
            UsuarioDB v = new UsuarioDB()
            {
                Tipo = tipo,
                Correo = correo,
                Cedula = Cedula,
                Nombre = nombre
            };
            return _repository.GuargarUsuario(v);
        }
    }
}