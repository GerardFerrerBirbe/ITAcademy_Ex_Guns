﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class Gatling : IWeapon
    {
        public string WeaponName { get; set; }
        public string Shoot()
        {
            return "Ra ta tatataaa ..";
        }
    }
}
