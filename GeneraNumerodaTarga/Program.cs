using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneraNumerodaTarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una targa (es. ABC123):");
            string targa = Console.ReadLine();

            // Verifica che la targa sia nel formato corretto (6 caratteri)
            if (targa.Length != 6)
            {
                Console.WriteLine("Formato targa non valido.");
                return;
            }

            // Verifica che i primi tre caratteri siano lettere maiuscole
            for (int i = 0; i < 3; i++)
            {
                if (!Char.IsLetter(targa[i]) || !Char.IsUpper(targa[i]))
                {
                    Console.WriteLine("Formato targa non valido.");
                    return;
                }
            }

            // Verifica che gli ultimi tre caratteri siano cifre
            for (int i = 3; i < 6; i++)
            {
                if (!Char.IsDigit(targa[i]))
                {
                    Console.WriteLine("Formato targa non valido.");
                    return;
                }
            }

            // Calcola un numero corrispondente alla targa (somma dei valori ASCII dei caratteri)
            int numero = 0;

            foreach (char c in targa)
            {
                numero += (int)c;
            }

            Console.WriteLine($"Il numero corrispondente alla targa {targa} è: {numero}");
            Console.ReadLine();
        }
    }
}

