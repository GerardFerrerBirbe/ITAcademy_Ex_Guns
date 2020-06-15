using System;

namespace Ex_Guns
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Indica l'arma que vols utilitzar:");
                Console.WriteLine($"0 - {Guns.Revolver}");
                Console.WriteLine($"1 - {Guns.Rifle}");
                Console.WriteLine($"2 - {Guns.Escopeta}");
                Console.WriteLine($"3 - {Guns.Gatling}");

                while (true)
                {
                    var option = Console.ReadLine();

                    if (option != "0" && option != "1" && option != "2" && option != "3")
                    {
                        Console.WriteLine("Opcio incorrecta");
                    }
                    else
                    {
                        while (true)
                        {
                            var mygun1 = GetGun(option);

                            Console.WriteLine("En vols utilitzar alguna més? Sí és que sí, indica-la, si no, escriu 'no'");

                            var option2 = Console.ReadLine();

                            if (option2 != "no" && option2 != "0" && option2 != "1" && option2 != "2" && option2 != "3")
                            {
                                Console.WriteLine("Opcio incorrecta");
                            }
                            else
                            {
                                if (option2 == "0" || option2 == "1" || option2 == "2" || option2 == "3")
                                {
                                    while (true)
                                    {
                                        var mygun2 = GetGun(option2);

                                        Console.WriteLine("En vols utilitzar alguna més? Sí és que sí, indica-la, si no, escriu 'no'");

                                        var option3 = Console.ReadLine();

                                        if (option3 != "no" && option3 != "0" && option3 != "1" && option3 != "2" && option3 != "3")
                                        {
                                            Console.WriteLine("Opcio incorrecta");
                                        }
                                        else
                                        {
                                            if (option3 == "0" || option3 == "1" || option3 == "2" || option3 == "3")
                                            {
                                                while (true)
                                                {
                                                    var mygun3 = GetGun(option3);

                                                    Console.WriteLine("En vols utilitzar alguna més? Sí és que sí, indica-la, si no, escriu 'no'");

                                                    var option4 = Console.ReadLine();

                                                    if (option4 != "no" && option4 != "0" && option4 != "1" && option4 != "2" && option4 != "3")
                                                    {
                                                        Console.WriteLine("Opcio incorrecta");
                                                    }
                                                    else
                                                    {
                                                        if (option4 == "0" || option4 == "1" || option4 == "2" || option4 == "3")
                                                        {
                                                            var mygun4 = GetGun(option4);

                                                            var soldado = new Soldado(mygun1, mygun2, mygun3, mygun4);
                                                            Console.WriteLine(soldado.Disparar(mygun1, mygun2, mygun3, mygun4));
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            var soldado = new Soldado(mygun1, mygun2, mygun3);
                                                            Console.WriteLine(soldado.Disparar(mygun1, mygun2, mygun3));
                                                            break;
                                                        }
                                                    }
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                var soldado = new Soldado(mygun1, mygun2);
                                                Console.WriteLine(soldado.Disparar(mygun1, mygun2));
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                    var soldado = new Soldado(mygun1);
                                    Console.WriteLine(soldado.Disparar(mygun1));
                                    break;
                                }
                            }
                        }
                    }
                    break;
                }
            }

            static IArma GetGun(string input)
            {
                switch (input)
                {
                    case "0":
                        return new Revolver();
                    case "1":
                        return new Rifle();
                    case "2":
                        return new Escopeta();
                    case "3":
                        return new Gatling();
                    default:
                        return null;
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
