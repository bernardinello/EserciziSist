using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string targa, targa1, targa2, targa3, targafinale;
            int posizione2 = 0;
            double posizione = 0, valore1 = 0, valore2 = 0;
            double temp = 0, valore = 0;
            char[] alfabetoInglese = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Console.WriteLine("Inserisci una targa a piacere");
            targa = Console.ReadLine();
            targa1 = targa.Substring(2, 3);
            targa2 = targa.Substring(0, 2);
            targa3 = targa.Substring(5);
            targafinale = targa2 + targa3; //vado a creare le prime 4 lettere della targa
            for (int i = 0; i < targa1.Length; i++)
            {
                valore1 += Convert.ToInt32(targa1[i]) * Math.Pow(10, i);//math.pow viene utilizzato per calcolare una potenza di un numero.
            }
            for (int i = 0; i < targafinale.Length; i++)
            {

                posizione2 = Array.IndexOf(alfabetoInglese, targafinale[i]);

                if (posizione2 != -1)
                {
                    temp = posizione * Math.Pow(26, i);
                    posizione = temp + posizione2;
                }
            }
            valore2 = posizione * Math.Pow(10, 3); 
            valore = valore2 + valore1;
            Console.WriteLine("Ecco il numero corrispondente");
            Console.WriteLine(valore2);
            
            Console.ReadLine();
        }
    }
}
