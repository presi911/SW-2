using System;
using System.Collections.Generic;
using System.Text;
using UC_Parking_Domain_Contracts.Contracts;
using UC_Parking_Domain_Contracts.DomainEntities;
using UC_Parking_Persistence_Contracts.Contracts;
using UC_Parking_Persistence_Contracts.DbEntities;

namespace UC_Parking_Domain_Implementation.implementations
{
    public class VigilanteDomainImplementation : IVigilanteDomain
    {
        
        IVigilanteRepository _repository1;
      
        public VigilanteDomainImplementation(IVigilanteRepository _repository)
        {
            this._repository1 = _repository;
        }

      
      

        
     

        public bool GuardarVigilante(String cedula,String nombres,String apellidos,String telefono,String correo)
        {
            VigilanteDb v = new VigilanteDb()
            {
                Cedula = cedula,Nombres=nombres,Apellidos=apellidos,Telefono=telefono,Correo=correo
            };
            return this._repository1.GuardarVigilante(v);
        }

      

        IEnumerable<VigilanteDomain> IVigilanteDomain.GetListaVigilantes()
        {
            VigilanteDomain v1 = new VigilanteDomain() { Cedula = "1", Nombres="juan", Apellidos = "rober" ,Correo="gmail.com"};
            VigilanteDomain v2 = new VigilanteDomain() { Cedula = "2", Nombres = "juan1", Apellidos = "rober1", Correo = "gmail.com" };
            VigilanteDomain v3 = new VigilanteDomain() { Cedula = "3", Nombres = "juan2", Apellidos = "rober2", Correo = "gmail.com" };



            var list = new List<VigilanteDomain>();
            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            return list;
        }
    }
}

