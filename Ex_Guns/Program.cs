using Ex_Guns.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                    var objectOption = ShowPlayerMenu();

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
                            var notifychange = new NotifyWeaponChange();
                            var soldier = new Soldier(soldierWeapon, notifychange);
                            var notif = soldier.NotifyChange(soldierWeapon);
                            Console.WriteLine(notif);
                            var shoot = soldier.Shoot();
                            Player.ShootSet.Add(shoot);
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
                            var notifychange = new NotifyWeaponChange();
                            var tank = new Tank(tankWeapon, notifychange);
                            var notif = tank.NotifyChange(tankWeapon);
                            Console.WriteLine(notif);
                            var shoot = tank.Shoot();
                            Player.ShootSet.Add(shoot);
                        }
                    }
                    if (objectOption == "2")
                    {
                        foreach (var item in Player.ShootSet)
                        {
                            Console.WriteLine(item);
                        }

                        Player.ShootSet.Clear();

                        break;
                    }
                }
            }
        }

        #region Menus
        
        public static string ShowPlayerMenu()
        {
            Console.WriteLine("Escull el jugador que vols utilitzar o dispara:");
            Console.WriteLine($"0 - {Player.Types.Soldier}");
            Console.WriteLine($"1 - {Player.Types.Tank}");
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
                    return new Revolver {WeaponName = "Revolver" };
                case "1":
                    return new Rifle { WeaponName = "Rifle" };
                case "2":
                    return new Shotgun { WeaponName = "Shotgun" };
                case "3":
                    return new Gatling { WeaponName = "Gatling" };
                default:
                    return null;
            }
        }

        static IWeapon GetTankWeapon(string input)
        {
            switch (input)
            {
                case "0":
                    return new Cannon { WeaponName = "Cannon" };
                case "1":
                    return new Grenade { WeaponName = "Grenade" };
                case "2":
                    return new Shotgun { WeaponName = "Shotgun" };
                default:
                    return null;
            }
        }
    }    
}
