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
       
        private string date;
        private string arrival;

        public string GuestName
        {
            get { return guestName; }
            set { guestName = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Arrival
        {
            get { return arrival; }
            set { arrival = value; }
        }
            
        
    }
}






