using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class Soldier : WarUnit
    {
        public static List<IWeapon> SoldierWeaponsSet { get; set; } = new List<IWeapon>();
        
        public Soldier(List<IWeapon> soldierGunsSet, IWeapon _gun)
        {
            soldierGunsSet.Add(_gun);            
        }        

        public string Shoot(List<IWeapon> soldierGunsSet)
        {
            var output = "";
            
            foreach (var gun in soldierGunsSet)
            {
                var shoot = gun.Shoot();
                output += "\n" + shoot;
            }

            return output;
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
