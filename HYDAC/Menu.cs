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

        public string[] Navn = new string[10]; // array til at holde navn på gæsten
        public string[] Virksomhed = new string[10]; // array til at holde på virksomheden på gæsten

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

                Navn[nr] = gæsten.GuestName; // putter navnet ind på et array 
                Virksomhed[nr] = gæsten.CompanyName; // putter virksomheden ind på et array
                Nr[nr] = nr + 1; // til test så vi kan se i udprintet hvad nr gæsten er i listen.


                Console.WriteLine($"gæstens navn er {Navn[nr]}, Virksomheden er {Virksomhed[nr]} og du er gæst nr {Nr[nr]}");
                nr++; // tæller en op så den næste gæst kan blive skrevet ind på en ny plads.
                Console.WriteLine("Tryk enter for at gå tilbage til menu");
                Console.ReadLine();
                Show();
            }
            

                
                Console.ReadLine();
                
                

                

                
                
            
            
        }

        
        

    }
}
