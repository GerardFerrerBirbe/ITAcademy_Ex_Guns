﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public interface IWeapon
    {
        string WeaponName { get; set; }
        string Shoot();
    }
}
