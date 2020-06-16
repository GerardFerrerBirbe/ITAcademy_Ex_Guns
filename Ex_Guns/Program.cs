using Ex_Guns.Controllers;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace Ex_Guns
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("--Inici--");
                Console.WriteLine("");

                while (true)
                {
                    var objectOption = ShowWarObjectMenu();

                    if (objectOption != "0" && objectOption != "1" && objectOption != "2")
                    {
                        Console.WriteLine("Opció incorrecta");
                    }
                    if (objectOption == "0")
                    {
                        var soldierOption = ShowSoldierMenu();

                        var validresult = SoldierMenuValidation(soldierOption);

                        if (!validresult.IsSuccess)
                        {
                            Console.WriteLine($"{validresult.ErrorMessage}");
                        }
                        else
                        {
                            var soldierWeapon = GetSoldierWeapon(validresult.ValidatedResult);
                            var soldier = new Soldier(Soldier.SoldierWeaponsSet, soldierWeapon); 
                                                        
                            soldier.Shoot(soldierWeapon, WarObject.WeaponFireList);
                        }
                    }
                    if (objectOption == "1")
                    {
                        var tankOption = ShowTankMenu();

                        var validresult = TankMenuValidation(tankOption);

                        if (!validresult.IsSuccess)
                        {
                            Console.WriteLine($"{validresult.ErrorMessage}");
                        }
                        else
                        {
                            var tankWeapon = GetTankWeapon(validresult.ValidatedResult);
                            var tank = new Tank(Tank.TankWeaponsSet, tankWeapon);

                            tank.Shoot(tankWeapon, WarObject.WeaponFireList);
                        }
                    }
                    if (objectOption == "2")
                    {
                        foreach (var item in WarObject.WeaponFireList)
                        {
                            Console.WriteLine(item);
                        }

                        WarObject.WeaponFireList.Clear();
                        
                        break;
                    }
                }
            }
        }

        #region Menus
        
        public static string ShowWarObjectMenu()
        {
            Console.WriteLine("Escull l'objecte que vols utilitzar o dispara:");
            Console.WriteLine($"0 - {WarObject.Types.Soldier}");
            Console.WriteLine($"1 - {WarObject.Types.Tank}");
            Console.WriteLine("2 - per disparar");

            return Console.ReadLine();
        }

        public static string ShowSoldierMenu()
        {          
            Console.WriteLine("Escull l'arma que vols utilitzar:");
            Console.WriteLine($"0 - {Soldier.SoldierWeapons.Revolver}");
            Console.WriteLine($"1 - {Soldier.SoldierWeapons.Rifle}");
            Console.WriteLine($"2 - {Soldier.SoldierWeapons.Shotgun}");
            Console.WriteLine($"3 - {Soldier.SoldierWeapons.Gatling}");

            return Console.ReadLine();           
        }

        public static string ShowTankMenu()
        {
            Console.WriteLine("Escull l'arma que vols utilitzar:");
            Console.WriteLine($"0 - {Tank.TankWeapons.Cannon}");
            Console.WriteLine($"1 - {Tank.TankWeapons.Grenade}");
            Console.WriteLine($"2 - {Tank.TankWeapons.Shotgun}");

            return Console.ReadLine();
        }
        #endregion

        static ValidationResult SoldierMenuValidation(string option)
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

        static ValidationResult TankMenuValidation(string option)
        {
            var validResult = new ValidationResult();

            if (option != "0" && option != "1" && option != "2")
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

        static IWeapon GetSoldierWeapon(string input)
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

        static IWeapon GetTankWeapon(string input)
        {
            switch (input)
            {
                case "0":
                    return new Cannon();
                case "1":
                    return new Grenade();
                case "2":
                    return new Shotgun();
                default:
                    return null;
            }
        }
    }    
}
