using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class Soldier : Player
    {        
        protected IWeapon currentWeapon;

        protected INotifyWeaponChange notifyWeaponChange;

        public Soldier(IWeapon _currentWeapon, INotifyWeaponChange _notifyWeaponChange)
        {
            this.currentWeapon = _currentWeapon;
            this.notifyWeaponChange = _notifyWeaponChange;
            this.PlayerName = "soldat";
        }

        public string Shoot()
        {
            return this.currentWeapon.Shoot();
        }

        public string NotifyChange(IWeapon currentWeapon)
        {
            return "El " + this.PlayerName + this.notifyWeaponChange.NotifyChange(currentWeapon);
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
