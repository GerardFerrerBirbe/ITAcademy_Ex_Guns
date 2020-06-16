using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace Ex_Guns
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowSoldierMenu();
        }

        public static void ShowSoldierMenu()
        {
            while (true)
            {
                Console.WriteLine("Indica l'arma que vols utilitzar:");
                Console.WriteLine($"0 - {Soldier.Guns.Revolver}");
                Console.WriteLine($"1 - {Soldier.Guns.Rifle}");
                Console.WriteLine($"2 - {Soldier.Guns.Shotgun}");
                Console.WriteLine($"3 - {Soldier.Guns.Gatling}");

                var option = Console.ReadLine();

                var validresult = MenuValidation(option);

                if (!validresult.IsSuccess)
                {
                    Console.WriteLine($"{validresult.ErrorMessage}");
                }
                else
                {
                    var mygun = GetSoldierGun(validresult.ValidatedResult);
                    var soldier = new Soldier(Soldier.GunsSet, mygun);

                    Console.WriteLine(soldier.Shoot(Soldier.GunsSet));
                }
            }
        }
        
        static ValidationResult MenuValidation(string option)
        {
            var validResult = new ValidationResult();
                       
            if (option != "0" && option != "1" && option != "2" && option != "3")
            {
                validResult.ErrorMessage = "Opció incorrecta";
                validResult.IsSuccess = false;
            }
            else
            {
                validResult.IsSuccess = true;
                validResult.ValidatedResult = option;
            }

            return validResult;
        }

        static IGun GetSoldierGun(string input)
        {
            switch (input)
            {
                case "0":
                    return new Revolver();
                case "1":
                    return new Rifle();
                case "2":
                    return new Shotgun();
                case "3":
                    return new Gatling();
                default:
                    return null;
            }
        }         
    }    
}
