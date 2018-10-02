using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombok
{
    class Program
    {
        static void TombKiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                //Console.WriteLine("[" + i + "] => " + tomb[i]);
                Console.WriteLine("[{0}] => {1}", i, tomb[i]);
                //Console.WriteLine("[{1}] => {0}", tomb[i], i);
                //Console.WriteLine($"[{i}] => {tomb[i]}");         //Újabb verziókban
            }
        }

        static void TombKiir(double[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("[" + i + "] => " + tomb[i]);
            }
        }


        static void Main(string[] args)
        {
            // Tömb deklarálása
            int[] nullTomb;

            // Tömb létrehozása elemszám megadásával
            int[] otElemuTomb = new int[5];

            // Tömb létrehozása értékek megadásával
            int[] tomb = new int[] { 25, 50, 75, 100 };

            // Tömb értékeinek elérése
            otElemuTomb[0] = 5;
            Console.WriteLine(otElemuTomb[0]);

            // Tömb bejárása
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }

            // Feladat
            // Kérjünk be egy számot a felhasználótól és hozzunk létre egy akkora
            // méretű tömböt. Töltsük fel eggyel növekvő számokkal 1-től.
            Console.WriteLine("Mekkora legyen a tömb?");
            int elemszam = int.Parse(Console.ReadLine());
            int[] szamok = new int[elemszam];
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = i + 1;
            }

            TombKiir(szamok);

            double[] dTomb = { 0.1, 1.2, 1.5 };
            TombKiir(dTomb);
            

            Console.ReadKey();
        }
    }
}
