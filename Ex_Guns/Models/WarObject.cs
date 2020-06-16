using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class WarObject
    {
        public static List<string> WeaponFireList { get; set; } = new List<string>();

        public enum Types
        {
            Soldier,
            Tank            
        }
    }
}
