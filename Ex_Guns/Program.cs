using System;

namespace Ex_Guns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indica l'arma que vols utilitzar:");
            Console.WriteLine($"0 - {Guns.Revolver}");
            Console.WriteLine($"1 - {Guns.Rifle}");
            Console.WriteLine($"2 - {Guns.Escopeta}");
            Console.WriteLine($"3 - {Guns.Gatling}");

            while (true)
            {            
                var myGun = Console.ReadLine();

                switch (myGun)
                {
                    case "0":
                        var soldado0 = new Soldado(new Revolver());
                        Console.WriteLine(soldado0.Disparar());
                        break;
                    case "1":
                        var soldado1 = new Soldado(new Rifle());
                        Console.WriteLine(soldado1.Disparar());
                        break;
                    case "2":
                        var soldado2 = new Soldado(new Escopeta());
                        Console.WriteLine(soldado2.Disparar());
                        break;
                    case "3":
                        var soldado3 = new Soldado(new Gatling());
                        Console.WriteLine(soldado3.Disparar());
                        break;
                    default:
                        Console.WriteLine("Opció incorrecta");
                        break;
                }
            }
        }
    }
    
    public enum Guns
    {
        Revolver,
        Rifle,
        Escopeta,
        Gatling
    }
}
