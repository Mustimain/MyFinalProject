﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Region : IEntity
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }

    }
}
