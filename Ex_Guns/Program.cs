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
                var unitOption = ShowWarUnitMenu();

                if (unitOption != "0" && unitOption != "1")
                {
                    Console.WriteLine("Opció incorrecta");
                }
                if (unitOption == "0")
                {
                    var soldierOption = ShowSoldierMenu();

                    var validresult = MenuValidation(soldierOption);

                    if (!validresult.IsSuccess)
                    {
                        Console.WriteLine($"{validresult.ErrorMessage}");
                    }
                    else
                    {
                        var soldierWeapon = GetSoldierWeapon(validresult.ValidatedResult);
                        var soldier = new Soldier(Soldier.SoldierWeaponsSet,soldierWeapon);

                        soldier.Shoot(soldierWeapon, Soldier.WeaponFireList);

                        foreach (var item in Soldier.WeaponFireList)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
                if (unitOption == "1")
                {
                    var tankOption = ShowTankMenu();

                    var validresult = MenuValidation(tankOption);

                    if (!validresult.IsSuccess)
                    {
                        Console.WriteLine($"{validresult.ErrorMessage}");
                    }
                    else
                    {
                        var tankWeapon = GetTankWeapon(validresult.ValidatedResult);
                        var tank = new Tank(Tank.TankWeaponsSet, tankWeapon);

                        Console.WriteLine(tank.Shoot(Tank.TankWeaponsSet));
                    }
                }
            }
        }

        #region Menus
        
        public static string ShowWarUnitMenu()
        {
            Console.WriteLine("Escull l'unitat de guerra que vols utilitzar:");
            Console.WriteLine($"0 - {WarUnit.Types.Soldier}");
            Console.WriteLine($"1 - {WarUnit.Types.Tank}");

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
