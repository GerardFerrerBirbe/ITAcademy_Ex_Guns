using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class Rifle : IGun
    {
        public string Shoot()
        {
            return "Pum pum pum pum pum ..";
        }
    }
}
