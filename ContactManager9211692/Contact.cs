using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager9211692
{
    class Contact
    {
        private int ID;
        private string contactFname;
        private string contactLname;
        private string contactTel;
        private string contactAddr1;
        private string contactAddr2;
        private string contactCity;
        private string contactPostcode; 

        public int getID () 
        { 
            return ID;
        }
        public void setID (int i)
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

        public void setcontactLname(string i)
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

        public void setcontactAddr1 (string i)
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
