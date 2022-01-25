using System;
using System.Collections.Generic;
using System.Text;

namespace perhiazan
{
    class PemainAman
    {
        private string barangBerharga = "";

        public void MenerimaKonten (string kontenAman)
        {
            this.barangBerharga = kontenAman;
            Console.WriteLine($"Haturnuhun for returning my {this.barangBerharga}");
        }

    }
}
