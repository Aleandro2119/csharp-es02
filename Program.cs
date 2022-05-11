using System;           //riferimento alla libreria di base
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {
            //for (char paperino='a'; paperino < 'z'; paperino++)
            //    Console.WriteLine(paperino);
            //var a = "aaaa"; //Utilizzo var <nome> per dichiarare una variabile assegnandogli
            //il tipo dell'oggetto che gli sto assegnando come valore
            /* int n = 0;
             for (int i = 0; i < 512; i++)
             {
                 if (n == 16)
                 {
                     Console.WriteLine();
                     n = 0;
                 }
                 n++;
                 //Console.Write("{0} ", Convert.ToChar(i));
                 Console.Write("{0} ", (char)i);  //casting
             }
             for (char paperino = 'a'; paperino < 'z'; paperino++)
                 Console.WriteLine((long)paperino); */


            /*
             * Un semplice calcolatore
             * Realizzare un programma che chiede all'utente che tipo di operazione intende
             * svolgere (0-somma, 1-prodotto, 2-divisione, 3-sottrazione, 4-quadrato, 5-media)
             * e poi se somma, prodotto, divisione o sottrazione chiede due valori, se quadrato 
             * chiede un solo valore e se media chiede 10 valori.
             * Utilizzare un vettore di interi o reali (a vostra scelta) per archiviare i valori di input
             * Opzionale:  implementare l'operazione di elevamento a potenza superiore al 2.
             */

            string[] comandi = new string[] { "Somma", "Prodotto", "Divisione", "Sottrazione", "Quadrato", "Media" };
            Console.Write("Comando [0-addizione, 1-prodotto, 2-divisione, 3-sottrazione, 4-quadrato, 5-media]: ");
            string cmd = Console.ReadLine();
            switch (cmd)
            {
                case "0":
                    Console.WriteLine("Operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                    Console.WriteLine("inserisci il primo numero:");
                    Console.WriteLine("Inserisci il secondo numero:");
                    string v1 = Console.ReadLine();
                    string v2 = Console.ReadLine();

                    int V1 = Convert.ToInt32(v1);
                    int V2 = Convert.ToInt32(v2);

                    Console.WriteLine("Hai inserito: {0}, {1}", V1, V2);
                    Console.WriteLine("Il loro prodotto: {0}", Somma(V1, V2));

            static int Somma(int v1, int v2)
            {
                return v1 + v2;
            }
            break;
                case "1":
                    Console.WriteLine("Operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                    Console.WriteLine("inserisci il primo numero:");
                    Console.WriteLine("Inserisci il secondo numero:");
                    string p1 = Console.ReadLine();
                    string p2 = Console.ReadLine();

                    int P1 = Convert.ToInt32(p1);
                    int P2 = Convert.ToInt32(p2);

                    Console.WriteLine("Hai inserito: {0}, {1}", P1, P2);
                    Console.WriteLine("Il loro prodotto: {0}", Moltiplica(P1, P2));
            

            static int Moltiplica(int p1, int p2)
            {
                return p1 * p2;
            }
            break;
                case "2":
                    Console.WriteLine("Operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                    Console.WriteLine("inserisci il primo numero:");
                    Console.WriteLine("Inserisci il secondo numero:");
                    string d1 = Console.ReadLine();
                    string d2 = Console.ReadLine();

                    int D1 = Convert.ToInt32(d1);
                    int D2 = Convert.ToInt32(d2);

                    Console.WriteLine("Hai inserito: {0}, {1}", D1, D2);
                    Console.WriteLine("Il loro prodotto: {0}", Dividere(D1, D2));
            

            static int Dividere(int d1, int d2)
            {
                return d1 / d2;
            }
            break;
                case "3":
                    Console.WriteLine("Operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                    Console.WriteLine("inserisci il primo numero:");
                    Console.WriteLine("Inserisci il secondo numero:");
                    string s1 = Console.ReadLine();
                    string s2 = Console.ReadLine();

                    int S1 = Convert.ToInt32(s1);
                    int S2 = Convert.ToInt32(s2);

                    Console.WriteLine("Hai inserito: {0}, {1}", S1, S2);
                    Console.WriteLine("Il loro prodotto: {0}", Sottrarre(S1, S2));
            

            static int Sottrarre(int s1, int s2)
            {
                return s1 - s2;
            }
            break;
                case "4":
                    Console.WriteLine("Operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                    Console.WriteLine("Inserire un numero");
                    int numberOne;
                    numberOne = int.Parse(Console.ReadLine());
                    double Result = Math.Pow(numberOne, 2);
                    Console.Write("Il quadrato del numero è: {0}", Result);
                    break;
                case "5":
                    Console.WriteLine("Operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                    Console.Write("Inserisci l'elenco dei numeri di cui intendi calcolare la media, separati da spazi vuoti, tutti sulla stessa riga: ");
                    string sNumeri = Console.ReadLine();
                    if (sNumeri == null)
                    {
                        Console.WriteLine("Non hai fornito numeri!!");
                        Environment.Exit(0);
                    }
                    string[] svect = sNumeri.Split(' ');
                    double media = 0.0;
                    int quanti = 0;
                    foreach (string snum in svect)
                    {
                        double num;
                        if (double.TryParse(snum, out num))
                        {
                            media += num;
                            quanti++;
                        }
                    }
                    media /= quanti;  //media = media / quanti
                    Console.WriteLine("La media dei numeri forniti è: {0}", media);
                    break;
                default:
                    Console.WriteLine("Richiestao comando non esistente: {0}.", cmd);
                    break;
            }
        }
    }
}
