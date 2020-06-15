using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class Soldier
    {
        protected IGun gun1;
        protected IGun gun2;
        protected IGun gun3;
        protected IGun gun4;
        
        public Soldier(IGun _gun1, IGun _gun2 = default, IGun _gun3 = default, IGun _gun4 = default)
        {
            this.gun1 = _gun1;
            this.gun2 = _gun2;
            this.gun3 = _gun3;
            this.gun4 = _gun4;
        }        

        public string Disparar(IGun gun1, IGun gun2 = default, IGun gun3 = default, IGun gun4 = default)
        {
            if (gun2 == default && gun3 == default && gun4 == default)
            {
                return this.gun1.Shoot();
            }
            else
            {
                if (gun3 == default && gun4 == default)
                {
                    return this.gun1.Shoot() + "\n" + this.gun2.Shoot();
                }
                else
                {
                    if (gun4 == default)
                    {
                        return this.gun1.Shoot() + "\n" + this.gun2.Shoot() + "\n" + this.gun3.Shoot();
                    }
                    else
                    {
                        return this.gun1.Shoot() + "\n" + this.gun2.Shoot() + "\n" + this.gun3.Shoot() + "\n" + this.gun4.Shoot();
                    }
                }
            }
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
