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
        private string _Status;

        //construct


        public Quotation(int anID, string anName,float aTotal_Price, string aStatus)
        {
            this._Id = anID;
            this._Name = anName;
            this._Total_Price = aTotal_Price;
            this._Status = aStatus;
               
        }

        //getter


        public int getId() {return this._Id;}

        public string getName() {return (this._Name);}

        public float getTotalPrice() {return this._Total_Price;}
        public string getStatus() {return this._Status;}

        //setter


     
        public void setName(string anName) {this._Name=anName;}
        public void setTotalPrice( float aTotalPrice) {this._Total_Price = aTotalPrice;}
        public void setStatus(string aStatus) { this._Status = aStatus; }
    }
}
