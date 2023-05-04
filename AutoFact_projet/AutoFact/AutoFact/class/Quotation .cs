using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
    class Quotation
    {
        private int _Id;
        private string _Name;
        private float _Total_Price;
        private int _CustomerId;

        //construct


        public Quotation(int anID, string anName,float aTotal_Price, int aCustomerId)
        {
            this._Id = anID;
            this._Name = anName;
            this._Total_Price = aTotal_Price;
            this._CustomerId = aCustomerId;
               
        }

        //getter


        public int getId() {return this._Id;}

        public string getName() {return (this._Name);}

        public float getTotalPrice() {return this._Total_Price;}
        public int getCustomerId() {return this._CustomerId;}

        //setter


     
        public void setName(string anName) {this._Name=anName;}
        public void setTotalPrice( float aTotalPrice) {this._Total_Price = aTotalPrice;}
        public void setStatus(int aCustomerId) { this._CustomerId = aCustomerId; }
    }
}
