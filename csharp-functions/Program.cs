using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FUNCTIONS
            //Funzione che stampa virgola e spazio
            void StampaVirgolaESpazio()
            {
                Console.Write(", ");
            }

            //Funzione che stampa l'array
            void StampaArray(int[] array)
            {
                Console.Write("(");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                        StampaVirgolaESpazio();
                }
                Console.Write(")");
            }

            //Funzione che eleva al quadrato un numero
            int Quadrato(int num)
            {
                return num * num;
            }

            //Funzione che eleva al quadrato l'array
            int[] ElevaArrayAlQuadrato(int[] array)
            {
                int[] newArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Quadrato(array[i]);
                }
                return newArray;
            }

            //Funzione che somma gli elementi dell'array
            int SommaElementiArray(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }

            //Dati di prova
            //int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };

            //Bonus
            int n;
            Console.Write("Inserisci un numero di elementi per l'array (solo numeri maggiore o uguale a zero): ");
            while (int.TryParse(Console.ReadLine(), out n) == false)
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            //Dichiarazione e definizione lunghezza dell'array
            int[] arrayNumeri = new int[n];

            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Inserisci il {i + 1}° elemento: ");
                arrayNumeri[i] = Convert.ToInt32(Console.ReadLine());
            }



            // Stampa l'array di numeri
            Console.WriteLine("\nStampa dell'array originale:");
            StampaArray(arrayNumeri);
            Console.WriteLine();

            // Stampa l'array dove ogni numero è stato elevato al quadrato
            Console.WriteLine("\nArray con elementi elevati al quadrato:");
            int[] arrQuadrato = ElevaArrayAlQuadrato(arrayNumeri);
            StampaArray(arrQuadrato);
            Console.WriteLine();

            // Calcola la somma di tutti i numeri nell'array
            Console.WriteLine("\nSomma dei numeri dell'array:");
            int sum = SommaElementiArray(arrayNumeri);
            Console.WriteLine($"La somma totale è {sum}");

            // Calcola la somma di tutti i numeri elevati al quadrato
            Console.WriteLine("\nSomma dei numeri elevati al quadrato:");
            int sumQuadrato = SommaElementiArray(arrQuadrato);
            Console.WriteLine($"La somma totale è {sumQuadrato}");
        }
    }
}
