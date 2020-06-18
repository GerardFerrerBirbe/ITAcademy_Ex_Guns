using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class Tank : Player
    {
        protected IWeapon currentWeapon;

        protected INotifyWeaponChange notifyWeaponChange;

        public Tank(IWeapon _currentWeapon, INotifyWeaponChange _notifyWeaponChange)
        {
            this.currentWeapon = _currentWeapon;
            this.notifyWeaponChange = _notifyWeaponChange;
            this.PlayerName = "tank";
        }

        public string Shoot()
        {
            return this.currentWeapon.Shoot();
        }

        public string NotifyChange(IWeapon currentWeapon)
        {
            return "El " + this.PlayerName + this.notifyWeaponChange.NotifyChange(currentWeapon);
        }        

        public enum TankWeapons
        {
            Cannon,
            Grenade,
            Shotgun,
        }
    }
}
