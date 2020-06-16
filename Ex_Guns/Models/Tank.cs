using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class Tank : WarObject
    {
        public static List<IWeapon> TankWeaponsSet { get; set; } = new List<IWeapon>();
        
        public Tank(List<IWeapon> tankGunsSet, IWeapon _gun)
        {
            tankGunsSet.Add(_gun);            
        }

        public void Shoot(IWeapon tankWeapon, List<string> weaponFireList)
        {
            var shoot = tankWeapon.Shoot();
            weaponFireList.Add(shoot);
        }

        public enum TankWeapons
        {
            Cannon,
            Grenade,
            Shotgun,
        }
    }
}
