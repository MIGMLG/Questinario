using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoBlue
{
    class Program
    {
        static void Main()
        {
            People You = new People();

            // Nome
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Whats your name ? R: ");
            Console.ForegroundColor = ConsoleColor.White;
            You.Nome = Console.ReadLine().Trim();

            // Loop Do Sexo
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Are you Male or Female ? R: ");
            Console.ForegroundColor = ConsoleColor.White;
            string sex = Console.ReadLine().Trim();
            string Wsex;

            while (true)
            {
                if ( sex.ToLower() == "male")
                {
                    Wsex = "Male";
                    break;
                }
                else if (sex.ToLower() == "female")
                {
                    Wsex = "Female";
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Invalid Input");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Are you Male or Female ? R: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    sex = Console.ReadLine().Trim();
                    continue;
                }
            }
            You.Sexo = Wsex;

            // Loop Da Idade

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("How old are you ? R: ");
            Console.ForegroundColor = ConsoleColor.White;
            
            string Ayou = Console.ReadLine().Trim();
            int ryou;

            while (true)
            {
                if (int.TryParse(Ayou, out ryou))
                {
                    if (ryou > 150)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Lies");
                        Console.Write("How old are you ? R: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Ayou = Console.ReadLine().Trim();
                        continue;
                    }
                    else if (ryou <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Lies");
                        Console.Write("How old are you ? R: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Ayou = Console.ReadLine().Trim();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Invalid Input.");
                    Console.Write("How old are you ? R: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Ayou = Console.ReadLine().Trim();
                    continue;
                }
            }
            You.Idade = ryou;

            // Loop Altura

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Whats is your Height in cm ? Ex: 168 R: ");
            Console.ForegroundColor = ConsoleColor.White;
            string Altura = Console.ReadLine().Trim();
            int Altura0;

            while (true)
            {
                if (int.TryParse(Altura, out Altura0))
                {
                    if ( Altura0 <= 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Lies");
                        Console.Write("Whats is your Height in cm ? Ex: 168 R: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Altura = Console.ReadLine().Trim();
                        continue;
                    }
                    else if ( Altura0 > 300)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Lies");
                        Console.Write("Whats is your Height in cm ? Ex: 168 R: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Altura = Console.ReadLine().Trim();
                        continue;
                    }
                    else
                    {

                        break;
                    }
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Invalid Input.");
                    Console.Write("Whats is your Height in cm ? Ex : 168 R: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Altura = Console.ReadLine().Trim();
                    continue;
                }
            }

            You.Altura = Altura0;


            // Resultados

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("All the data available :");
            Console.WriteLine();
            Console.Write("Name: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}", You.Nome);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Sex: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You are a {0}.", You.Sexo);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Age: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You have {0} year(s). You are {1}", You.Idade, You.estagiodevida());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Height: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0} cm. {1}", You.Altura, You.HollyShit());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key to leave.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

        }
    }

    class People
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public int Altura { get; set; }
        public string estagiodevida()
        {
            string estagio;

            if (Idade < 18)
            {
                if (Idade < 14)
                {
                    if (Idade < 3)
                    {
                        estagio = "a baby.";
                    }
                    else
                    {
                        estagio = "a child.";
                    }
                }

                else
                {
                    estagio = "a teenager.";
                }
            }
            else if (Idade > 40)
            {
                estagio = "a Velhote.";
            }
            else
            {
                estagio = "an adult.";
            }

            return estagio;
        }


        public string HollyShit()
        {
            string alt;

            if (Altura < 120)
            {
                alt = "You are smaller than an ant.";
            }
            else if (Altura > 180)
            {
                alt = "Holly Shit. You are a girafe.";
            }
            else
            {
                alt = "Just a normal person.";
            }

            return alt;
        }
    }
}

