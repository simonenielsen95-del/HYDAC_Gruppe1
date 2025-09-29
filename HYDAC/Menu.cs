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
        public GæsteBog gæsteListe = new GæsteBog(); // BLIVER IKKE BRUGT TIL NOGET (OBS!!!)
        public Gæst Gæst = new Gæst(); // Bliver ikke brugt til noget (tror jeg) da vi opretter et nyt instance når der bliver valgt "1" fra menyen.
        public string Title;
        public MenuItem[] MenuItems;
        public int ItemCount = 0;

        public string[] Name = new string[10]; // array til at holde navn på gæsten
        public string[] Company = new string[10]; // array til at holde på virksomheden på gæsten
        public string[] Date = new string[10]; // array til at holde på datoen på gæsten
        public string[] Arrival = new string[10]; // array til at holde på ankomst tiden på gæsten

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
                Gæst gæsten = new Gæst(); // laver en ny instance af Gæst under gæsten.

                if (nr > 9)
                {
                    Console.WriteLine("der er ikke plads til flere gæster");
                    Console.WriteLine("tast enter for at gå tilbage til menu");
                    Console.ReadLine();
                    Show();
                }
                Console.WriteLine("Intast navn:");
                gæsten.GuestName = Console.ReadLine();  // gemmer det indtastede navn 
                
                Console.WriteLine("Intast virksomhed:");
                gæsten.CompanyName = Console.ReadLine(); // gemmer det indtastede virksomhed

                Console.WriteLine("Indtast dato for ankomst:");
                gæsten.Date = Console.ReadLine(); // gemmer det indtastede dato

                Console.WriteLine("Indtast klokkeslæt for ankomst:");
                gæsten.Arrival = Console.ReadLine(); // gemmer den indtastede ankomst tid

                Console.WriteLine("skriv gem for at gemme");
                string gem = Console.ReadLine();

                if (gem.ToLower() == "gem")
                {
                    Name[nr] = gæsten.GuestName; // putter navnet ind på et array 
                    Company[nr] = gæsten.CompanyName; // putter virksomheden ind på et array
                    Date[nr] = gæsten.Date; // putter datoen ind på et array
                    Arrival[nr] = gæsten.Arrival; // putter ankomst tiden ind på et array
                    Nr[nr] = nr + 1; // til test så vi kan se i udprintet hvad nr gæsten er i listen.

                    Console.Clear();
                    Console.WriteLine(
                        $" Gæstens navn er {Name[nr]}\n " +
                        $"Virksomheden er {Company[nr]}\n " +
                        $"Din ankomst dato er {Date[nr]}\n " +
                        $"Din akomst tid er {Arrival[nr]}\n " +
                        $"Du er gæst nr {Nr[nr]}\n"
                        );
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

            if (MI == "2")
            {
                Console.WriteLine(" Gæstebog:");
                Console.WriteLine("-------------------------------------");
                for (int i = 0; i < nr;)
                {
                    Console.WriteLine(
                        " \n" +
                        $" Gæstens navn er {Name[i]}\n " +
                        $"Virksomheden er {Company[i]}\n " +
                        $"Din ankomst dato er {Date[i]}\n " +
                        $"Din akomst tid er {Arrival[i]}\n " +
                        $"Du er gæst nr {Nr[i]}\n"
                        );
                    Console.WriteLine("-------------------------------------");
                    i++;                
                }
                Console.ReadLine();
                Show();


                    Console.ReadLine();




            }
                
                
            
            
        }

        
        

    }
}
