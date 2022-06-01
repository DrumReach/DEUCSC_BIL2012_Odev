using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarisma
{
    class YarismaTest
    {
        static void Main(string[] args)
        {
            Yarisma testYarismasi = new Yarisma("yarismacilar.txt", 45);

            // ##DEBUG
            
            Console.WriteLine("## CONTESTANTS ##");
            foreach(IYarismaci cont in testYarismasi.yarismacilar)
                Console.WriteLine(cont);

            Console.WriteLine();

            

            testYarismasi.Baslat();
            testYarismasi.KonumlariYazdir();

            Console.Write("\n\nYENİDEN\n\n\n");

            testYarismasi.Baslat();
            testYarismasi.KonumlariYazdir();

        }
    }
}
