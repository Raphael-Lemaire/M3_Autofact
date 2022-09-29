﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
    class Type_Status
    {
        private int _Id;
        private string _Libelle;

        //Construct

        public Type_Status(int anId, string aLibelle)
        {
            this._Id = anId;
            this._Libelle = aLibelle;
        }

        //getter


        public int getId() {return this._Id;}

        public string getLibelle() {return this._Libelle;}

        //setter

        public void setId(int anId)
        {this._Id=anId;}

        public void setLibelle(string aLibelle) {this._Libelle=aLibelle;}
    }
}