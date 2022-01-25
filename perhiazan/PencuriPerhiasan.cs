using System;
using System.Collections.Generic;
using System.Text;

namespace perhiazan
{
    class PencuriPerhiasan : SmithKunci
    {
        private string hasilJambretan;

        protected void KembalikanKonten (string kontenAman, PemainAman owner)
        {
            this.hasilJambretan = kontenAman;
            Console.WriteLine($"I steal jrewel, including: {this.hasilJambretan}");
        }
    }
}
