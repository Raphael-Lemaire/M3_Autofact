using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
    class Date_Modif
    {
        public DateTime _DateModif;

        //construct

        public Date_Modif(DateTime aDateModif)
        {
            this._DateModif = aDateModif;
        }

        //getter

        public DateTime getDateModif()
        {
            return this._DateModif;
        }

        
        //setter

        public void setDateModif(DateTime aDateModif)
        {
            this._DateModif = aDateModif;
        }
    }
}
