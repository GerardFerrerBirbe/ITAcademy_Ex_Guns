using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class Soldado
    {
        protected IArma arma;

        public Soldado(IArma _arma)
        {
            this.arma = _arma;
        }

        public string Disparar()
        {
            return this.arma.Disparar();
        }
        
    }
}
