using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HYDAC;

namespace HYDAC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu();

            mainMenu.Title = "HYDAC Gæste Bog";
            mainMenu.MenuItems = new MenuItem[10];

            // First menu item
            MenuItem mi = new MenuItem();
            mi.Title = "1. Tilføj Gæst";
            mainMenu.MenuItems[0] = mi;
            mainMenu.ItemCount++; // Increment with one; same as: ItemCount = ItemCount + 1

            // Second menu item
            //mi = new MenuItem();
            //mi.Title = "2. Gør dat";
            //mainMenu.MenuItems[1] = mi;
            //mainMenu.ItemCount++;

            // Third menu item
            //mi = new MenuItem();
            //mi.Title = "3. Gør noget";
            //mainMenu.MenuItems[2] = mi;
            //mainMenu.ItemCount++;

            // Last menu item
            //mi = new MenuItem();
            //mi.Title = "4. Få svaret på livet, universet og alting";
            //mainMenu.MenuItems[3] = mi;
            //mainMenu.ItemCount++;

            mainMenu.Show();

            Console.ReadLine();
            Console.ReadLine();
        }

    }
}
