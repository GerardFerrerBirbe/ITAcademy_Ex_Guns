using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Ex_Guns
{
    public class NotifyWeaponChange : INotifyWeaponChange
    {
        public string NotifyChange(IWeapon currentWeapon)
        {
            return $" ha afegit un {currentWeapon.WeaponName}";
        }
    }
}
