using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Ex_Guns
{
    public class NotifyGunChange
    {
        public WarUnit EntityName { get; set; }

        public IWeapon GunName { get; set; }
                
        public string GunStatus { get; set; }
                
        //public static string Alert()
        //{
        //    return "El soldat ha canviat d'arma";
        //}
    }
}
