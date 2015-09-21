using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjektHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            //int TotalNumberOfPupils = 0;
            //Console.WriteLine("Venligst indtast antallet af elever: ");
            //TotalNumberOfPupils = Convert.ToInt32(Console.ReadLine());
            string[] klasseListe = new string[29];
            Filler(ref klasseListe);
            double NumberOfGroups = 0;
            double NumberOfGroupMembers = 0;
            double GroupNumber = 0;
            Console.Write("Venligst indtast antallet af medlemmer per gruppe: ");
            NumberOfGroupMembers = Convert.ToInt32(Console.ReadLine());
            //NumberOfGroups = Math.Ceiling(klasseListe.Length / NumberOfGroupMembers);
            if (NumberOfGroupMembers == 2)
            {
                NumberOfGroups = klasseListe.Length / NumberOfGroupMembers;
                if (klasseListe.Length % NumberOfGroupMembers == 0)
                {
                    for (int i = 0; i < klasseListe.Length / NumberOfGroupMembers; i++)
                    {
                        GroupNumber += 1;
                        if (GroupNumber <= klasseListe.Length / NumberOfGroupMembers)
                        {
                            Console.WriteLine("Group #{0}", GroupNumber);
                            Group(ref klasseListe, 2);
                        }
                        else
                            break;
                    }
                }
                else if (klasseListe.Length % NumberOfGroupMembers == 1)
                {
                    GroupNumber += 1;
                    Console.WriteLine("Group #{0}", GroupNumber);
                    Group(ref klasseListe, 3);
                    for (int i = 0; i < klasseListe.Length / NumberOfGroupMembers - 1; i++)
                    {
                        GroupNumber += 1;
                        if (GroupNumber <= klasseListe.Length / NumberOfGroupMembers)
                        {
                            Console.WriteLine("Group #{0}", GroupNumber);
                            Group(ref klasseListe, 2);
                        }
                        else
                            break;
                    }
                }
            }
            else if (NumberOfGroupMembers == 3)
            {
                if (klasseListe.Length % NumberOfGroupMembers == 0)
                {
                    for (int i = 0; i < klasseListe.Length / NumberOfGroupMembers; i++)
                    {
                        GroupNumber += 1;
                        if (GroupNumber <= klasseListe.Length / NumberOfGroupMembers)
                        {
                            Console.WriteLine("Group #{0}", GroupNumber);
                            Group(ref klasseListe, 3);
                        }
                        else
                            break;
                    }
                }
                else if (klasseListe.Length % NumberOfGroupMembers == 1)
                {
                    GroupNumber += 1;
                    Console.WriteLine("Group #{0}", GroupNumber);
                    Group(ref klasseListe, 4);
                    for (int i = 0; i < klasseListe.Length / NumberOfGroupMembers - 1; i++)
                    {
                        GroupNumber += 1;
                        if (GroupNumber <= klasseListe.Length / NumberOfGroupMembers)
                        {
                            Console.WriteLine("Group #{0}", GroupNumber);
                            Group(ref klasseListe, 3);
                        }
                        else
                            break;
                    }
                }
                else if (klasseListe.Length % NumberOfGroupMembers == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        GroupNumber += 1;
                        if (GroupNumber <= klasseListe.Length / NumberOfGroupMembers)
                        {
                            Console.WriteLine("Group #{0}", GroupNumber);
                            Group(ref klasseListe, 4);
                        }
                        else
                            break;
                    }
                    for (int i = 0; i < klasseListe.Length / NumberOfGroupMembers - 2; i++)
                    {
                        GroupNumber += 1;
                        if (GroupNumber <= klasseListe.Length / NumberOfGroupMembers)
                        {
                            Console.WriteLine("Group #{0}", GroupNumber);
                            Group(ref klasseListe, 3);
                        }
                        else
                            break;
                    }
                }
            }
            else if (NumberOfGroupMembers == 4)
            {
                if (klasseListe.Length % NumberOfGroupMembers == 0)
                {
                    for (int i = 0; i < klasseListe.Length / NumberOfGroupMembers; i++)
                    {
                        GroupNumber += 1;
                        if (GroupNumber <= klasseListe.Length / NumberOfGroupMembers)
                        {
                            Console.WriteLine("Group #{0}", GroupNumber);
                            Group(ref klasseListe, 4);
                        }
                        else
                            break;
                    }
                }
                else if (klasseListe.Length % NumberOfGroupMembers == 1)
                {
                    GroupNumber += 1;
                    Console.WriteLine("Group #{0}", GroupNumber);
                    Group(ref klasseListe, 5);
                    for (int i = 0; i < klasseListe.Length / NumberOfGroupMembers -1; i++)
                    {
                        GroupNumber += 1;
                        if (GroupNumber <= klasseListe.Length / NumberOfGroupMembers)
                        {
                            Console.WriteLine("Group #{0}", GroupNumber);
                            Group(ref klasseListe, 4);
                        }
                        else
                            break;
                    }
                }
                else if (klasseListe.Length % NumberOfGroupMembers == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        GroupNumber += 1;
                        Console.WriteLine("Group #{0}", GroupNumber);
                        Group(ref klasseListe, 5);
                    }
                    for (int i = 0; i < klasseListe.Length / NumberOfGroupMembers - 2; i++)
                    {
                        GroupNumber += 1;
                        if (GroupNumber <= klasseListe.Length / NumberOfGroupMembers)
                        {
                            Console.WriteLine("Group #{0}", GroupNumber);
                            Group(ref klasseListe, 4);
                        }
                        else
                            break;
                    }
                }
                else if (klasseListe.Length % NumberOfGroupMembers == 3)
                {
                    GroupNumber += 1;
                    Console.WriteLine("Group #{0}", GroupNumber);
                    Group(ref klasseListe, 3);
                    for (int i = 0; i < klasseListe.Length / NumberOfGroupMembers -1; i++)
                    {
                        GroupNumber += 1;
                        if (GroupNumber <= klasseListe.Length / NumberOfGroupMembers)
                        {
                            Console.WriteLine("Group #{0}", GroupNumber);
                            Group(ref klasseListe, 4);
                        }
                        else
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong Input!");
            }

            Console.ReadLine();
        }
        static void Filler(ref string[] klasseListe1)
        {
            klasseListe1[0] = "Esben Balle Andersen";
            klasseListe1[1] = "Matias Jonas Bjørstop";
            klasseListe1[2] = "Mads Foged Christensen";
            klasseListe1[3] = "Michael Gregers Davis";
            klasseListe1[4] = "Andres Vestergaard Fomsgaard";
            klasseListe1[5] = "Christian Fredriksen";
            klasseListe1[6] = "Nadia Guldfeldt";
            klasseListe1[7] = "Andre Hansen";
            klasseListe1[8] = "Brian Melgaard Hansen";
            klasseListe1[9] = "Brian Felthaus Hansen";
            klasseListe1[10] = "Patrick Nebel Højgaard";
            klasseListe1[11] = "Mathias Blaaber Jensen";
            klasseListe1[12] = "Mikkel Johansen";
            klasseListe1[13] = "Kristoffer Nøddebo Knudsen";
            klasseListe1[14] = "Mogens Kristensen";
            klasseListe1[15] = "Nicolai Kristensen";
            klasseListe1[16] = "Ole Juul Lajgaard";
            klasseListe1[17] = "Nikolaj Larsen";
            klasseListe1[18] = "Niels Høy Mikkelsen";
            klasseListe1[19] = "Alexander Houlind Mortensen";
            klasseListe1[20] = "Michael Nygaard";
            klasseListe1[21] = "Henrik Lilleris Nielsen";
            klasseListe1[22] = "Rasmus Nielsen";
            klasseListe1[23] = "Søren Møller Nielsen";
            klasseListe1[24] = "Tobias Mølgård Pedersen";
            klasseListe1[25] = "Thomas Lucas Skov";
            klasseListe1[26] = "Kasper Kaas Søderberg";
            klasseListe1[27] = "Anders Odgaard Sørensen";
            klasseListe1[28] = "Stefan Rolf Østergaard";

        }
        static void Group(ref string[] klasseListe,int AmountOfPupilsInGroup)
        {
            Random rng = new Random();
            for (int i = 0; i < AmountOfPupilsInGroup; i++)
            {
                int rng1 = rng.Next(klasseListe.Length);
                bool allBlank = true;
                for (int j = 0; j < klasseListe.Length; j++)
                {
                    if (klasseListe[j] != string.Empty)
                    {
                        allBlank = false;
                    }
                }
                if (allBlank)
                {
                    Console.WriteLine("End of List");
                    break;
                }

                else if (klasseListe[rng1] != "")
                {
                    Console.WriteLine(klasseListe[rng1]);
                    klasseListe[rng1] = "";
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine();
        }
       
    }
}
