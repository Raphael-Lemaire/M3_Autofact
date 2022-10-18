using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
    internal class Product
    {
        private int _Id;
        private string _Name;
        private float _Unit_Price;

        //construct



        public Product(int anId, string aName, float aUnit_Price)
        {
            this._Id = anId;
            this._Name = aName;
            this._Unit_Price = aUnit_Price;
        }

        //getter

        public int getId() { return this._Id;}

        public string getName() {return this._Name;}


        public float getUnit_Price() { return this._Unit_Price; }

        //setter




        public void setName(string aName) {this._Name=aName;}

        public void setPriceUnit(float aPrice_Unit) {this._Unit_Price=aPrice_Unit;}

    }

}
