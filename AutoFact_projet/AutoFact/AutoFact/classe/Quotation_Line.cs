using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
    abstract class Quotation_Line
    {
        private int _amount;

        //Construct


        public Quotation_Line(int anAmount)
        {
            this._amount = anAmount;
        }

        //Getter


        public int getAmount(){return this._amount;}

        //Setter

        public void setAmount(int anAmount) {this._amount = anAmount;} 

    }
}
