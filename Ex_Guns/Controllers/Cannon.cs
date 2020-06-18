using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns.Controllers
{
    public class Cannon : IWeapon
    {
        public string WeaponName { get; set; }
        public string Shoot()
        {
            return "PataPUUUUUUUUUM ..";
        }
    }
}
