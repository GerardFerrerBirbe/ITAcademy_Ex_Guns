using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public interface INotifyWeaponChange
    {
        string NotifyChange(IWeapon currentWeapon);
    }
}
