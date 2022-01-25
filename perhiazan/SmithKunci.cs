using System;
using System.Collections.Generic;
using System.Text;

namespace perhiazan
{
    class SmithKunci
    {
        public string Kombinasi
        {
             private get;  set;
        } 

        public void BukaAman (AmanDong aman, PemainAman pemilikzz)
        {
            aman.Maling(this);
            string kontenAman = aman.Buka(this.Kombinasi);
            KembalikanIsinya(kontenAman, pemilikzz);
        }//END void BukaAman 


        protected void KembalikanIsinya (string kontenAman, PemainAman owner)
        {
            owner.MenerimaKonten(kontenAman);
        }

    } //END class
}
