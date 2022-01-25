using System;

namespace perhiazan
{
    class Program
    {
        static void Main(string[] args)
        {
            PemainAman siX = new PemainAman();

            AmanDong aman1 = new AmanDong();
            PencuriPerhiasan siY = new PencuriPerhiasan();
            siY.BukaAman(aman1, siX);
            Console.ReadKey(true);
        }
    }
}
