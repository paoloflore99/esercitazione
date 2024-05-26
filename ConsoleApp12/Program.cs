using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Puoi spiegarmi la differenza tra il passaggio di parametri per valore e per riferimento in C# e fornire un esempio di ciascuno?

                void numero(int n)
                {
                    n++;
                    Console.WriteLine(n);
                }
                //il risultato dovre essere 11
                numero(10);

                int e = 10;
                numero(e);
                Console.WriteLine(e);//la stampa sara 10 ma adesso il valore di n dentro numero sará 11
            }

            {
                // Asegnazione valore 
                int n = 10;
                int b = n - 1;
                Console.WriteLine(b);
                //b sara 9
            }

            {
                //Una classe in C# è un costrutto fondamentale che consente di definire un tipo di dati che
                //rappresenta un insieme di attributi e metodi correlati. Una volta definita la classe, puoi creare
                //istanze di quella classe, chiamate oggetti, per utilizzare le funzionalità definite nella classe.
            }

            {
                //Puoi spiegarmi cos'è un'eccezione in C# e come viene gestita?

                //Corretto! Un'eccezione in C# è un errore o una condizione anomala che si verifica durante l'esecuzione
                //del programma.Le eccezioni sono rappresentate da istanze di classi che derivano dalla classe Exception
                //o dalle sue sottoclassi.Quando si verifica un'eccezione, viene sollevata ("thrown") e può essere gestita
                //attraverso la gestione delle eccezioni.


                //Qual è la differenza tra una classe e una struttura in C#?
            }

            {
                //Common Language Runtime (CLR) 

                //comando di eseuzione del programma 
            }

            {
                //Qual è la differenza tra una List e un Array in C#?
                //la differenza fra un array e lyst e che la lunghezza di un array e impostata all'inizio 
                //la lughezza della lista puo aumentare o diminuire
                //L'array in C# è implementato come un tipo di valore.
                int[] n = { 1, 2, 3 };

                //list 

                List<int> list = new List<int>();
                list.Add(1);
                list.Add(2);
            }
        }
    }
}
