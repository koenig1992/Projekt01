using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MON_PROJEKT
{           

    
    internal class MonKlassen
    {

        // KLASSENWECHSEL BENÖTIGT:
        //        Aktuelle Klasse (default: Base)
        //        Neue Klasse
        //        KlassenOptionen
        //        Spieler wählt eine von 3 möglichen Optionen

        public object MonName; // damit Klasse "Klassen" MonName kennt 
        public object stats; // damit Klasse "Klassen" stats kennt
        public enum Stat; // damit Klasse "Klassen" enum Stat kennt

        public MonKlasse KlasseAktuell {  get; set; }

        public List<MonKlasse> KlassenOptionen { get; }




            
            public void WechselKlasse()
            {


            
    
        // EVTL BESSER: OVERRIDE, WEIL WERTE WIE HP UND MINA NEUES, PERMANENTES MAX BEKOMMEN, IM KAMPF WERTE ABER TEMPORÄR VERRINGERT WERDEN KÖNNEN
        // NEUES MAX != AKTUELLER WERT
        // ODER EVTL BESSER: CALL BY VALUE / CALL BY REFERENCE
            
            } 

        }
    }
