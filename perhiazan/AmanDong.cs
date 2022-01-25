using System;
using System.Collections.Generic;
using System.Text;

namespace perhiazan
{
    class AmanDong
    {
        private string isi = "perhiasan berharga";
        private string kombinasiOke = "12345";

        public string Buka (string kombinasi)
        {
            if (kombinasi == this.kombinasiOke) return this.isi;
            return "";

        }

        public void Maling (SmithKunci pencurikunci)
        {
            pencurikunci.Kombinasi = this.kombinasiOke;
        }

    }// END class
}
