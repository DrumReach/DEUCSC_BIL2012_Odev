﻿using System;
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
             
            foreach(IYarismaci cont in testYarismasi.yarismacilar)
            {
                System.Console.WriteLine(cont);
            }

            
            System.Console.WriteLine();

            



            testYarismasi.Baslat();
            testYarismasi.KonumlariYazdir();

            Console.Write("\n\nYENİDENA\n\n\n");

            testYarismasi.Baslat();
            testYarismasi.KonumlariYazdir();

        }
    }
}
