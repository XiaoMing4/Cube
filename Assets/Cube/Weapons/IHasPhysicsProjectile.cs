﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Cube.Weapons
{
    public interface IHasPhysicsProjectile
    {
        public GameObject LastProjectile { get; }
    }
}
