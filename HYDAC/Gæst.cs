using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HYDAC
{
    public class Gæst
    {
        // Private fields (backing fields) for hver propert 
        // skrevet med camelCase, starter med lille bogstav
        private string guestName;
        private string companyName;
        private string date; 
        private string arrival;

        //Property (skrevet med PascalCase, starter med stor bogstav)
        public string GuestName //Gæstens navn
        {
            get { return guestName; }
            set { guestName = value; }
        }

        public string CompanyName //Virksomhedsnavn Property
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string Date //Dato for ankomst
        {
            get { return date; }
            set { date = value; }
        }
        public string Arrival //klokkeslæt for ankomst
        {
            get { return arrival; }
            set { arrival = value; }
        }


    }
}






