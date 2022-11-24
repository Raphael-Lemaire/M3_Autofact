using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
    class Customer
    {
        private int _Id;
        private string _FirstName;
        private string _LastName;
        private string _CompanyName;
        private int _Phone_Number;
        private string _Email_Address;
        private string _Address;
        public List<Customer> Customers = new List<Customer>();


        // construct


        public Customer(int anId, string aFirstName,string aLastName, string aCompagnyName,int aPhoneNumber, string anEmailAddress, string Address)
        {
            this._Id = anId;
            this._FirstName = aFirstName;
            this._LastName = aLastName;
            this._CompanyName = aCompagnyName;
            this._Phone_Number = aPhoneNumber;
            this._Email_Address = anEmailAddress;
            this._Address = Address;
        }

        //getter


        public int getId(){return this._Id;}
        public string getFirstName() {return this._FirstName;}
        public string getLastName() {return this._LastName;}

        public string getCompagnyName() {return this._CompanyName;}

        public int getPhoneNumber() {return this._Phone_Number;}

        public string getEmailAddress() {return this._Email_Address;}

        public string getAddress(){return this._Address;}

        //setter


        public void setName(string aFirstName) {this._FirstName=aFirstName;}

        public void setLastName(string aLastName) { this._LastName = aLastName; }

        public void setCompagnyName(string aCompagnyName) {this._CompanyName = aCompagnyName;}

        public void setPhoneNumber(int aPhoneNumber) {this._Phone_Number = aPhoneNumber;}

        public void setEmailAdress(string aEmailPhone) {this._Email_Address = aEmailPhone;}

        public void setAdress(string anAdress) {this._Address = anAdress;}


    }


}
