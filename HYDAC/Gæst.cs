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

        private string guestName;
  
        private string companyName;
       
        private string date; //Dato for ankomst
        private string arrival; //Klokkeslæt for ankomst

        public string GuestName //Gæstens navn
        {
            get { return guestName; }
            set { guestName = value; }
        }

        public string CompanyName //Virksomhedsnavn
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






