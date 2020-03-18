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

        public void setID(int i)
        {
            ID = i;
        }
        public string getcontactFname()
        {
            return contactFname;
        }

        public void setcontactFname(string i)
        {
            contactFname = i;
        }

        public string getcontactLname()
        {
            return contactLname;
        }

        public void getcontactLname( string i)
        {
            contactLname = i;
        }
        public string getcontactTel()
        {
            return contactTel;
        }

        public void setcontactTel(string i)
        {
            contactTel = i;
        }
        public string getcontactAddr1()
        {
            return contactAddr1;
        }

        public void setcontactAddr1(string i)
        {
            contactAddr1 = i;
        }
        public string getcontactAddr2()
        {
            return contactAddr2;
        }

        public void setcontactAddr2(string i)
        {
            contactAddr2 = i;
        }
        public string getcontactCity()
        {
            return contactCity;
        }

        public void setcontactCity(string i)
        {
            contactCity = i;
        }
        public string getcontactPostcode()
        {
            return contactPostcode;
        }
        public void setcontactPostcode(string i)
        {
            contactPostcode = i;
        }
       
    }

    
}
