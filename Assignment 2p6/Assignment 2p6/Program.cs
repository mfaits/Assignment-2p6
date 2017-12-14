using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2p6
{
    //maybe I added a comment here
    enum Classmates
    {
        Tamra,
        Jessica,
        Nadia,
        Meschele,
        Archana,
        Kristen,
        Michelle,
        Carla,
        Allison,
        Laura,
        Jade,
        Angela,
        Sai,
        Kristin,
        Neha,
        Angelina,
        Zohra
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a C# codergirl's first name: ");
            string FirstName = Console.ReadLine();

            var isMatch = Enum.TryParse<Classmates>(FirstName, out Classmates match);

            if (isMatch)
            {
                switch (match)
                {
                    case Classmates.Tamra:
                        {
                            Console.WriteLine("Berger");
                            break;
                        }
                    case Classmates.Jessica:
                        {
                            Console.WriteLine("Burnett");
                            break;
                        }
                    case Classmates.Nadia:
                        {
                            Console.WriteLine("Copeland");
                            break;
                        }
                    case Classmates.Meschele:
                        {
                            Console.WriteLine("Darden");
                            break;
                        }
                    case Classmates.Archana:
                        {
                            Console.WriteLine("Dixit");
                            break;
                        }
                    case Classmates.Kristen:
                        {
                            Console.WriteLine("Edgecomb");
                            break;
                        }
                    case Classmates.Carla:
                        {
                            Console.WriteLine("Green");
                            break;
                        }
                    case Classmates.Allison:
                        {
                            Console.WriteLine("Littman");
                            break;
                        }
                    case Classmates.Laura:
                        {
                            Console.WriteLine("Minster");
                            break;
                        }
                    case Classmates.Jade:
                        {
                            Console.WriteLine("Parker");
                            break;
                        }
                    case Classmates.Angela:
                        {
                            Console.WriteLine("Angela R or Angela T? Enter R or T.");
                            string WhichAngela = Console.ReadLine();
                            if (WhichAngela == "R")
                            {
                                Console.WriteLine("Reitenbach");
                            }
                            else if (WhichAngela == "T")
                            {
                                Console.WriteLine("Tibbs");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, I don't recognize that Angela.");
                            }
                            break;
                        }
                    case Classmates.Sai:
                        {
                            Console.WriteLine("Rudraraju");
                            break;
                        }
                    case Classmates.Kristin:
                        {
                            Console.WriteLine("Slechticky");
                            break;
                        }
                    case Classmates.Neha:
                        {
                            Console.WriteLine("Trivedi");
                            break;
                        }
                    case Classmates.Angelina:
                        {
                            Console.WriteLine("Zabala");
                            break;
                        }
                    case Classmates.Zohra:
                        {
                            Console.WriteLine("Zaimi");
                            break;
                        }
                    default:
                        {
                            // I'm the default
                            Console.WriteLine("Faits");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Input name doesn't match the roster, please try again");
            }
            Console.ReadLine();
        }
        
    }
}

