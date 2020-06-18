using Ex_Guns.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class Revolver : IWeapon
    {
        public string WeaponName { get ; set; }
        public string Shoot()
        {
            return "Pum Pum ..";
        }
    }
}
