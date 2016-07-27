using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemo
{
    class Faehre
    {
        private String  name;
        private Decimal laenge;
        private int baujahr;

        public int Baujahr
        {
            get
            {
                return baujahr;
            }
            set
            {
                baujahr = value;
            }
        }

        public decimal Laenge
        {
            get
            {
                return laenge;
            }

            set
            {
                laenge = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Faehre()
        {
            Name = "Concordia";
            Laenge = 350;
            Baujahr = 2001;
        }
        public int MaxGewicht { get; set; }
        public int AnzahlPersonen { get; set; }


    }
}
