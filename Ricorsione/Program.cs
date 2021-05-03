using System;

namespace Ricorsione
{
    class Program
    {
        static long Fattoriale(int n)   // Fattoriale è una funzione
        {
            long f = 1;

            while (n > 0)
                f *= n--;

            return f;
        }

        // n! = n * (n - 1) * (n - 2) ..... * 1

        //      1 se n == 0    
        // n! = 
        //      n * (n - 1)! altrimenti

        // 5! = 5 * 4!
        // 4! = 4 * 3!
        // 3! = 3 * 2!
        // 2! = 2 * 1!
        // 1! = 1 * 0!
        // 0! = 1

        static long FattRicorsivo(int n)
        {
            //if (n == 0)
            //    return 1;
            //return n * FattRicorsivo(n - 1);

            return n == 0 ? 1 : n * FattRicorsivo(n - 1);
        }

        // FR(3) => 3 * FR(2)
        //               2 * FR(1)
        //                     1 * FR(0)
        //                          1

        // a ^ b = a * a * a ... b volte
        static int Eleva(int a, int b)
        {
            int p = 1;

            while (b-- > 0)   //for (int i = 0; i < b; i++)
                p *= a;

            return p;
        }

        // una parola è palindroma... se ha al massimo 1 carattere
        // oppure
        // se la prima lettera è uguale all'ultima e
        // il resto della parola è... palindroma
        // "radar"

        static bool Palindroma(string s)
        {
            //if (s.Length <= 1)
            //    return true;

            //if (s[0] == s[s.Length - 1])
            //    return Palindroma(s.Substring(1, s.Length - 2));
            //else
            //    return false;

            return s.Length <= 1 || (s[0] == s[s.Length - 1] &&
                Palindroma(s.Substring(1, s.Length - 2)));
        }

        // a ^ b => 1 se b == 0 oppure a * a ^ (b - 1) 

        static int ElevaRic(int a, int b)
        {
            return b == 0 ? 1 : a * ElevaRic(a, b - 1);
        }

        // stampa tutti i numeri da n a 1: 5 4 3 2 1
        // stampa tutti i numeri da 1 a n: 1 2 3 4 5
        static void StampaNumeri(int n)
        {
            // while (n > 0)
            //    Console.WriteLine(n--);

            //for (int i = 1; i <= n; i++)
            //    Console.WriteLine(i);

            if (n > 0)
            {
                StampaNumeri(n - 1);
                Console.WriteLine(n);
            }
        }

        // restituisce l'ennesimo numero della serie di fibonacci
        // 0 1 1 2 3 5 8 13 21 34 55 89 144
        // 0 1 2 3 4 5 6 7  8  9  10 11 12
        static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            if (n == 0)
                return a;
            if (n == 1)
                return b;

            int c = a + b;  // calcolo il primo valore della serie

            for (int i = 2; i < n; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }

            return c;
        }

        static int FiboRic(int n)
        {
            return n <= 1 ? n : FiboRic(n - 2) + FiboRic(n - 1);
        }

        static void FunzioneCheFaSoloDanni()
        {
            int x, y, z;    // allocati nello stack

            int[] a = new int[100000];  // l'array allocato nell'heap

            // FunzioneCheFaSoloDanni();
        }

        static void Main(string[] args)
        {
            // condizione ? valore_se_vera : valore_se_falsa

            // FunzioneCheFaSoloDanni();

            int f = FiboRic(10);

            StampaNumeri(10);

            Console.WriteLine($"radar: {Palindroma("radar")}");
            Console.WriteLine($"pippo: {Palindroma("pippo")}");

            int n = 5;

            Console.WriteLine($"Il fattoriale di {n} è {FattRicorsivo(n)}");
        }
    }
}
