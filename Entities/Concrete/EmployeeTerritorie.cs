using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class EmployeeTerritory :IEntity
    {
        public int EmployeeId { get; set; }
        public int TerritoryId { get; set; }

    }
}
