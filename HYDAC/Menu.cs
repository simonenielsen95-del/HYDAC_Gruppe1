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

                Console.WriteLine("Intast navn:");
                string guestName = Console.ReadLine();  // gemmer det indtastede navn 

                Console.Clear();
                Console.WriteLine("Intast virksomhed:");
                string companyName = Console.ReadLine(); // gemmer det indtastede virksomhed

                Console.Clear();
                Console.WriteLine("Indtast dato for ankomst:");
                string date = Console.ReadLine(); // gemmer det indtastede dato

                Console.Clear();
                Console.WriteLine("Indtast klokkeslæt for ankomst:");
                string arival = Console.ReadLine(); // gemmer den indtastede ankomst tid

                Console.Clear();
                Console.WriteLine("skriv gem for at gemme"); // lige nu gemmes gæsten uanset hvad der bliver indtastet her
                string gem = Console.ReadLine();

                if (gem.ToLower() == "gem")
                {
                    bool ableToSave = false;
                    for (int i = 0; i < gæster.Length; i++)
                    {
                        if (gæster[i] == null)
                        {
                            gæster[i] = new Gæst();
                            ableToSave = true;
                            gæster[i].GuestName = guestName;
                            gæster[i].CompanyName = companyName;
                            gæster[i].Date = date;
                            gæster[i].Arrival = arival;

                            Console.Clear();
                            Console.WriteLine("Gæsten er gemt i gæstebogen");
                            Console.WriteLine("Tryk enter for at gå tilbage til menu");
                            Console.ReadLine();
                            Show();
                        }
                    }
                    if (!ableToSave)
                    {
                        Console.WriteLine("der er ikke plads til flere gæster");
                        Console.WriteLine("tast enter for at gå tilbage til menu");
                        Console.ReadLine();
                        Show();
                    }
                }
                else
                {
                    Console.WriteLine("intastede oplysninger er ikke gent i gæste bogen");
                    Console.WriteLine("Tryk enter for at gå tilbage til menu");
                    Console.ReadLine();
                    Show();
                }
            }

            if (MI == "2") // se i gæstebogen (printer alle gæsterne ud)
            {
                Console.WriteLine(" Gæstebog:");
                Console.WriteLine("-------------------------------------");
                for (int i = 0; i < gæster.Length; i++)
                {
                    if (gæster[i] != null)
                    {
                        Console.WriteLine(
                        " \n" +
                        $" Gæstens navn er {gæster[i].GuestName}\n " +
                        $"Virksomheden er {gæster[i].CompanyName}\n " +
                        $"Din ankomst dato er {gæster[i].Date}\n " +
                        $"Din akomst tid er {gæster[i].Arrival}\n " +
                        $"{i}"
                        );
                        Console.WriteLine("-------------------------------------");
                    }
                }
                Console.ReadLine();
                Show();
            }

            if (MI == "3") // forsøg på at slette gæsten igen (det virker hvis gæsten ER i gæstebogen ellers crasher det)
            {
                Console.WriteLine("Slet Gæst");
                Console.WriteLine("indtast navn:");
                string name = Console.ReadLine();
                bool foundName = false;
                Console.Clear();
               
                while (!foundName)
                {
                    for (int i = 0; i < gæster.Length; i++)
                    {
                        if (gæster[i]!=null && gæster[i].GuestName == name)
                        {
                            foundName = true;
                            gæster[i] = null;


                            Console.WriteLine("gæsten er nu slettet fra gæstebogen.");
                            Console.WriteLine("tast enter for at komme tilbage til menuen.");
                            Console.ReadLine();
                            Show();
                        }
                    }
                }
                if (!foundName)
                {
                    Console.WriteLine("gæsten kunne ikke findes i gæstebogen");
                    Console.WriteLine("tast enter for at komme tilbage til menuen.");
                    Console.ReadLine();
                    Show();
                }
            }
            if (MI=="0")
            {
                return;
            }
        }
    }
}
    

