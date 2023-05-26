public class Matematica
{
    private static void Visualizza()
    {
        Console.WriteLine(" ");
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("-------------------------------------------- FUNZIONI MATEMATICHE -------------------------------------------- ");
        Console.WriteLine("");
        Console.WriteLine("1. RADICI");
        Console.WriteLine("2. ESPONONENZIALI");
        Console.WriteLine("3. LOGARITMI");
        Console.WriteLine("4. VALORI ASSOLUTI");
        Console.WriteLine("5. SENO");
        Console.WriteLine("6. COSENO");
        Console.WriteLine("7. TANGENTE");
        Console.WriteLine("8. ARCOSENO");
        Console.WriteLine("9. ARCOCOSENO");
        Console.WriteLine("10. ARCOTANGENTE");
        Console.WriteLine("11. STAMPA NUMERI PARI FINO A CHE NUMERO INSERITO DA TASTIERA");
        Console.WriteLine("12. STAMPA NUMERI DISPARI FINO A CHE NUMERO INSERITO DA TASTIERA");
        Console.WriteLine("13. STAMPA TABELLINA FINO A POSIZIONE N");
        Console.WriteLine("14. INSERISCI NUMERO E TI DICE TUTTI I SUOI NUMERI PRIMI PRECEDENTI");
        Console.WriteLine("15. FIBONACCI");
        Console.WriteLine("16. CONVERSIONI");
        Console.WriteLine("17. STAMPA TRIANGOLO DI TARATAGLIA FINO A NUMERO CHE INSERISCI TU");
        Console.WriteLine("");
        Console.WriteLine("<------------------------------------------------------------------------------------------------------------------->");
    }

    private static int Contollo()
    {
        Console.WriteLine(" ");
        Visualizza();

        int scelta;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" ");
        do
        {
            Console.Write("INSERISCI SCELTA DA 1 A 17 ---> ");
            scelta = Convert.ToInt32(Console.ReadLine());
        }
        while (scelta < 1 || scelta > 17);

        return scelta;
    }

    public static void Scelta()
    {
        int scelta = 0;
        string scelta_volte_fare = "";
        const int Vettore = 30000000;
        int[] numeri_primidivisibili = new int[Vettore];

        Console.WriteLine("");
        do
        {
            scelta = Contollo();

            switch (scelta)
            {
                case 1:
                    Console.Clear();
                    InfoMath.Radici();
                    break;
                case 2:
                    Console.Clear();
                    InfoMath.Esponenzili();
                    break;
                case 3:
                    Console.Clear();
                    InfoMath.Logaritmo();
                    break;
                case 4:
                    Console.Clear();
                    InfoMath.Valori_assoluti();
                    break;
                case 5:
                    Console.Clear();
                    InfoMath.Seno();
                    break;
                case 6:
                    Console.Clear();
                    InfoMath.Coseno();
                    break;
                case 7:
                    Console.Clear();
                    InfoMath.Tangente();
                    break;
                case 8:
                    Console.Clear();
                    InfoMath.ArcoCoseno();
                    break;
                case 9:
                    Console.Clear();
                    InfoMath.ArcoCoseno();
                    break;
                case 10:
                    Console.Clear();
                    InfoMath.ArcoTangente();
                    break;
                case 11:
                    Console.Clear();
                    InfoMath.StampaPari();
                    break;
                case 12:
                    Console.Clear();
                    InfoMath.StampaDispari();
                    break;
                case 13:
                    Console.Clear();
                    InfoMath.StampaNnumeriDivisibilipperN();
                    break;
                case 14:
                    Console.Clear();
                    InfoMath.CalcolaNumeriPrimiDivisibiliperNumero(numeri_primidivisibili);
                    break;
                case 15:
                    Console.Clear();
                    InfoMath.Fibonacci();
                    break;

                case 16:
                    Console.Clear();
                    Conversioni();
                    break;

                case 17:
                    Console.Clear();
                    InfoMath.Triangolo_di_Tartaglia();
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("PREMI UN TASTO PER CONTINUARE ---> ");
            Console.ReadKey();
            Console.WriteLine("");
            Console.Write("VUOI RIFARE L'OPERAZIONE SCRIVI SI ---> ");
            scelta_volte_fare = Console.ReadLine();
            scelta_volte_fare = scelta_volte_fare.ToLower();

        }while (scelta_volte_fare == "si");

    }
    
    private static void Conversioni()
    {
        Console.WriteLine("");
        int scelta = 0;
        string scelta_volte_fare = "";

        do
        {
            scelta = ContolloConversioni();

            switch (scelta)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("");
                    InfoMath.Binario_Decimale(); 
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("");
                    InfoMath.Decimale_Binario();
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("PREMI UN TASTO PER CONTINUARE ---> ");
            Console.ReadKey();
            Console.WriteLine("");
            Console.Write("VUOI RIFARE L'OPERAZIONE SCRIVI SI ---> ");
            scelta_volte_fare = Console.ReadLine();
            scelta_volte_fare = scelta_volte_fare.ToLower();

        } while (scelta_volte_fare == "si");
    }

    private static int ContolloConversioni()
    {
        Console.WriteLine(" ");
        VisualizzaConversioni();

        int scelta;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" ");
        do
        {
            Console.Write("INSERISCI SCELTA DA 1 A 2 ---> ");
            scelta = Convert.ToInt32(Console.ReadLine());
        }
        while (scelta < 1 || scelta > 2);

        return scelta;
    }

    private static void VisualizzaConversioni()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("");
        Console.WriteLine("------ CONVERSIONI ------");
        Console.WriteLine("");
        Console.WriteLine("1. BINARIO DECIMALE");
        Console.WriteLine("2. DECIMALE BINARIO");
        Console.WriteLine("");
    }
}