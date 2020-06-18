using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Ex_Guns
{
    public class Player
    {
        public string PlayerName { get; set; }
        
        public static List<string> ShootSet = new List<string>();
        
        public Player()
        {
        }        

        public enum Types
        {
            Soldier,
            Tank            
        }
    }
}
