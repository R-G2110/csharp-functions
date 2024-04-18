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


            //

            //Dati di prova
            int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };

            // Stampa l'array di numeri
            Console.WriteLine("Stampa dell'array originale:");
            StampaArray(arrayNumeri);

            // Stampa l'array dove ogni numero è stato elevato al quadrato
            Console.WriteLine("Array con elementi elevati al quadrato:");
            int[] arrQuadrato = ElevaArrayAlQuadrato(arrayNumeri);
            StampaArray(arrQuadrato);
        }
    }
}
