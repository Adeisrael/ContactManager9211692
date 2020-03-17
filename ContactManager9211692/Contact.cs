using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager9211692
{
    class Contact
    {
        private int ID { get; set; }
        private string contactFname { get; set; }
        private string contactLname { get; set; }
        private string contactTel { get; set; }
        private string contactAddr1 { get; set;}
        private string contactAddr2 { get; set; }
        private string contactCity { get; set; }
        private string contactPostcode { get;set; }

        public int getID () 
        { 
            return ID;
        }

        
        public string getcontactFname()
        {
            return contactFname;
        }

        public string getcontactLname()
        {
            return contactLname;
        }

        public string getcontactTel()
        {
            return contactTel;
        }

        public string getcontactAddr1()
        {
            return contactAddr1;
        }

        public string getcontactAddr2()
        {
            return contactAddr2;
        }

        public string getcontactCity()
        {
            return contactCity;
        }

        public string getcontactPostcode()
        {
            return contactPostcode;
        }

       
    }

    
}
