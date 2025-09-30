using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HYDAC;



namespace HYDAC
{
    internal class Menu //stilesering?

    {
        
        public string Title;
        public MenuItem[] MenuItems;
        public int ItemCount = 0;

        Gæst[] gæster = new Gæst[10]; // array der kan indeholde class Gæst



        public int[] Nr = new int[10]; // til test for at printe hvad nr personen er blevet skrevet ind som 
        int nr = 0; // holder for at kontrolere index

        public void Show()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine();
            for (int i = 0; i < ItemCount; i++)
            {
                Console.WriteLine("   " + MenuItems[i].Title);

            }
            Console.WriteLine();
            Console.WriteLine("(Tryk menupunkt eller 0 for at afslutte)");
            string MI = Console.ReadLine();
            Console.Clear();

            if (MI == "1")
            {

                
                gæster[nr] = new Gæst(); // indsætter en ny gæst ind på et index af Gæst arrayet

                if (nr > 9) // tjekker om der kan være flere gæster i array
                {
                    Console.WriteLine("der er ikke plads til flere gæster");
                    Console.WriteLine("tast enter for at gå tilbage til menu");
                    Console.ReadLine();
                    Show();
                }
                Console.WriteLine("Intast navn:");
                gæster[nr].GuestName = Console.ReadLine();  // gemmer det indtastede navn 

                Console.WriteLine("Intast virksomhed:");
                gæster[nr].CompanyName = Console.ReadLine(); // gemmer det indtastede virksomhed

                Console.WriteLine("Indtast dato for ankomst:");
                gæster[nr].Date = Console.ReadLine(); // gemmer det indtastede dato

                Console.WriteLine("Indtast klokkeslæt for ankomst:");
                gæster[nr].Arrival = Console.ReadLine(); // gemmer den indtastede ankomst tid

                Console.WriteLine("skriv gem for at gemme"); // lige nu gemmes gæsten uanset hvad der bliver indtastet her
                string gem = Console.ReadLine();

                if (gem.ToLower() == "gem")
                {

                    nr++; // tæller en op så den næste gæst kan blive skrevet ind på en ny plads.

                    Console.WriteLine("Tryk enter for at gå tilbage til menu");
                    Console.ReadLine();
                    Show();

                }

                else
                    Console.WriteLine("intastede oplysninger er ikke gent i gæste bogen");
                Console.WriteLine("Tryk enter for at gå tilbage til menu");
                Console.ReadLine();
                Show();
            }

            if (MI == "2") // se i gæstebogen (printer alle gæsterne ud)
            {
                Console.WriteLine(" Gæstebog:");
                Console.WriteLine("-------------------------------------");
                for (int i = 0; i < nr; i++)
                {

                    Console.WriteLine(
                        " \n" +
                        $" Gæstens navn er {gæster[i].GuestName}\n " +
                        $"Virksomheden er {gæster[i].CompanyName}\n " +
                        $"Din ankomst dato er {gæster[i].Date}\n " +
                        $"Din akomst tid er {gæster[i].Arrival}\n " +
                        $"Du er gæst nr {i + 1}\n"
                        );
                    Console.WriteLine("-------------------------------------");
                }
                Console.ReadLine();
                Show();
            }
            if (MI == "3") // forsøg på at slette gæsten igen
            {
                Console.WriteLine("Slet Gæst");

                Console.WriteLine("indtast navn:");

                bool foundName = false;

                string name = Console.ReadLine();
                while (!foundName)
                    for (int i = 0; i < nr; i++)
                    {
                        if (gæster[i].GuestName == name)
                        {
                            foundName = true; break;
                        }
                        else
                        {

                        }





                       
                        Console.ReadLine();




                    }




            }




        }
    }
}
