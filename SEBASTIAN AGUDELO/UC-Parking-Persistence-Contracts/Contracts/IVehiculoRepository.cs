﻿using System;
using System.Collections.Generic;
using System.Text;
using UC_Parking_Persistence_Contracts.DbEntities;

namespace UC_Parking_Persistence_Contracts.Contracts
{
    public interface IVehiculoRepository
    {
        Boolean GuardarVehiculo(VehiculoDb v);
    }
}
