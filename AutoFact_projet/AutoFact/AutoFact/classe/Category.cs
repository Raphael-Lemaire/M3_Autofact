﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
    class Category
    {
        private int _Id;
        private string _Libelle;
        

        //construct


        public Category(int anId,string aLibelle)
        {
            this._Id = anId;
            this._Libelle = aLibelle;
        }

        //getter


        public int getId() {return this._Id;}
        public string getLibelle() {return this._Libelle;}

        //setter
        
        public void setId(int id) {this._Id = id;}
        public void getlibelle(string aLibelle){this._Libelle=aLibelle;}

    }

}
