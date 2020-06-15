using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class Revolver : IGun
    {
        public string Shoot()
        {
            return "Pum Pum ..";
        }
    }
}
