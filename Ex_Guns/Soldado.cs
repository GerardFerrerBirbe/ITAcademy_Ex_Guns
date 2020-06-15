using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class Soldado
    {
        protected IArma arma1;
        protected IArma arma2;
        protected IArma arma3;
        protected IArma arma4;
        
        public Soldado(IArma _arma1, IArma _arma2 = default, IArma _arma3 = default, IArma _arma4 = default)
        {
            this.arma1 = _arma1;
            this.arma2 = _arma2;
            this.arma3 = _arma3;
            this.arma4 = _arma4;
        }        

        public string Disparar(IArma arma1, IArma arma2 = default, IArma arma3 = default, IArma arma4 = default)
        {
            if (arma2 == default && arma3 == default && arma4 == default)
            {
                return this.arma1.Disparar();
            }
            else
            {
                if (arma3 == default && arma4 == default)
                {
                    return this.arma1.Disparar() + "\n" + this.arma2.Disparar();
                }
                else
                {
                    if (arma4 == default)
                    {
                        return this.arma1.Disparar() + "\n" + this.arma2.Disparar() + "\n" + this.arma3.Disparar();
                    }
                    else
                    {
                        return this.arma1.Disparar() + "\n" + this.arma2.Disparar() + "\n" + this.arma3.Disparar() + "\n" + this.arma4.Disparar();
                    }
                }
            }
        }

        

    }
}
