using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class Soldier
    {
        public static List<IGun> GunsSet { get; set; } = new List<IGun>();        
        
        public Soldier(List<IGun> gunsSet, IGun _gun)
        {
            gunsSet.Add(_gun);
        }        

        public string Shoot(List<IGun> gunsSet)
        {
            var output = "";
            
            foreach (var gun in gunsSet)
            {
                var shoot = gun.Shoot();
                output += "\n" + shoot;
            }

            return output;
        }

        public enum Guns
        {
            Revolver,
            Rifle,
            Shotgun,
            Gatling
        }
    }
}
