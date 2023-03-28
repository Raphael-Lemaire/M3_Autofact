using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
    class TypeStatus
    {
        private int _Id;
        private string _Libelle;

        //Construct

        public TypeStatus(int anId, string aLibelle)
        {
            this._Id = anId;
            this._Libelle = aLibelle;
        }

        //getter


        public int getId() {return this._Id;}

        public string getLibelle() {return this._Libelle;}

        //setter




        public void setLibelle(string aLibelle) {this._Libelle=aLibelle;}
    }
}
