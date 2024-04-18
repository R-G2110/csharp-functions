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

            

            //

            //Dati di prova
            int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };
            StampaArray(arrayNumeri);
        }
    }
}
