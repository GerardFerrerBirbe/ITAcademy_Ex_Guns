using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class Soldier : WarObject
    {
        public static List<IWeapon> SoldierWeaponsSet { get; set; } = new List<IWeapon>();        
        
        public Soldier(List<IWeapon> soldierGunsSet, IWeapon _gun)
        {
            soldierGunsSet.Add(_gun);
        }

        public void Shoot(IWeapon soldierWeapon, List<string> weaponFireList)
        {           
            var shoot = soldierWeapon.Shoot();
            weaponFireList.Add(shoot);
        }

        public enum SoldierWeapons
        {
            Revolver,
            Rifle,
            Shotgun,
            Gatling
        }
    }
}
