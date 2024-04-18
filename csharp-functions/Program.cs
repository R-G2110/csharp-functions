namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FUNCTIONS
            //Funzione che stampa l'array
            void StampaArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"[{array[i]}]");
                }
                Console.WriteLine();
            }

        }
    }
}
