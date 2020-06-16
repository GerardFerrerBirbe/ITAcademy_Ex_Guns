using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns.Controllers
{
    public class Grenade : IWeapon
    {
        public string Shoot()
        {
            return " (Grenade) Rascapatapuuuum ..";
        }
    }
}
