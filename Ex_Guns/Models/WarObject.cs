using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Ex_Guns
{
    public class WarObject
    {
        private static List<string> weaponFireList = new List<string>();
        public static List<string> WeaponFireList
        {
            get
            {
                return weaponFireList;
            }
            set
            {
                weaponFireList = value;
                OnPropertyChanged("WeaponFireList");
            }
        }
        public static event PropertyChangedEventHandler PropertyChanged;

        private static void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(null, new PropertyChangedEventArgs(propertyName));
            }
        }

        public enum Types
        {
            Soldier,
            Tank            
        }
    }
}
