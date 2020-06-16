using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class Tank : WarUnit
    {
        public static List<IWeapon> TankWeaponsSet { get; set; } = new List<IWeapon>();
        
        public Tank(List<IWeapon> tankGunsSet, IWeapon _gun)
        {
            tankGunsSet.Add(_gun);            
        }        

        public string Shoot(List<IWeapon> tankGunsSet)
        {
            var output = "";
            
            foreach (var gun in tankGunsSet)
            {
                var shoot = gun.Shoot();
                output += "\n" + shoot;
            }

            return output;
        }

        public enum TankWeapons
        {
            Cannon,
            Grenade,
            Shotgun,
        }
    }
}
