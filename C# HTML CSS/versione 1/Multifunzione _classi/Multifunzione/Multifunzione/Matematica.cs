public class Matematica
{
    private static void Visualizza()
    {
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
        Console.WriteLine("");
        Console.WriteLine("<------------------------------------------------------------------------------------------------------------------->");
    }

    private static int Contollo()
    {
        Visualizza();

        int scelta;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        do
        {
            Console.WriteLine("");
            Console.Write("INSERISCI SCELTA DA 1 A 14 ---> ");
            scelta = Convert.ToInt32(Console.ReadLine());
        }
        while (scelta < 1 || scelta > 14);

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
                    Radici();
                    break;
                case 2:
                    Esponenzili();
                    break;
                case 3:
                    Logaritmo();
                    break;
                case 4:
                    Valori_assoluti();
                    break;
                case 5:
                    Seno();
                    break;
                case 6:
                    Coseno();
                    break;
                case 7:
                    Tangente();
                    break;
                case 8:
                    ArcoCoseno();
                    break;
                case 9:
                    ArcoCoseno();
                    break;
                case 10:
                    ArcoTangente();
                    break;
                case 11:
                    StampaPari();
                    break;
                case 12:
                    StampaDispari();
                    break;
                case 13:
                    StampaNnumeriDivisibilipperN();
                    break;
                case 14:
                    CalcolaNumeriPrimiDivisibiliperNumero(numeri_primidivisibili);
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("PREMI UN TASTO PER CONTINUARE ---> ");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("VUOI RIFARE L'OPERAZIONE SCRIVI SI ---> ");
            scelta_volte_fare = Console.ReadLine();
            Console.WriteLine();

        } while (scelta_volte_fare == "SI");

    }

    private static void Radici()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("inserisci il numero il quale vuoi calcolare la radice ---> ");
        double numero = Convert.ToDouble(Console.ReadLine());

        Console.Write("inserisci l'esponente della radice---> ");
        double esponente = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");
        double esponente_radice = 1 / esponente;

        double radice = Math.Pow(numero, esponente_radice);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"LA RADICE {esponente} di {numero} è  ----> {radice}");
    }

    private static void Esponenzili()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("inserisci il numero il quale vuoi calcolare l'espoonenzile ---> ");
        double numero = Convert.ToDouble(Console.ReadLine());

        Console.Write("inserisci l'esponente dell' esponenziale---> ");
        double esponente = Convert.ToDouble(Console.ReadLine());

        double esponenziale = Math.Pow(numero, esponente);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"il risultato di  {numero} ^ {esponente}  è ----> {esponenziale}");
    }


    private static void Logaritmo()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI IL NUMERO IL QUALE VUOI CALCOLARE IL LOGARITMO ---> ");
        double numero = Convert.ToDouble(Console.ReadLine());

        Console.Write("INSERISCI IL NUMERO DELLA BASE DEL LOGARITMO ---> ");
        double base_logaritmo = Convert.ToDouble(Console.ReadLine());

        double logaritmo = Math.Log(numero, base_logaritmo);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"il logaritmo in base {base_logaritmo} di {numero} è ----> {logaritmo}");

    }
    private static void Valori_assoluti()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI IL NUMERO IL QUALE VUOI CALCOLARE IL VALORE ASSOLUTO ---> ");
        double numero = Convert.ToDouble(Console.ReadLine());

        double valore_assoluto = 0;

        if (numero < 0)
            valore_assoluto = numero * -1;
        else
            valore_assoluto = numero;

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"il valore assoluto di {numero} è ----> {valore_assoluto}");
    }

    private static void Seno()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI L'ANGOLO IL QUALE VUOI CALCOLARE IL SENO---> ");
        double Angolo = Convert.ToDouble(Console.ReadLine());

        double Angolor = (Angolo * Math.PI) / 180;
        double Seno = Math.Sin(Angolor);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"il seno di {Angolo} è ----> {Seno}");
    }

    private static void Coseno()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI L'ANGOLO IL QUALE VUOI CALCOLARE IL COSENO---> ");
        double Angolo = Convert.ToDouble(Console.ReadLine());

        double Angolor = (Angolo * Math.PI) / 180;
        double Coseno = Math.Cos(Angolor);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"il coseno di {Angolo} è ----> {Coseno}");
    }

    private static void Tangente()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI L'ANGOLO IL QUALE VUOI CALCOLARE LA TANGENTE --> ");
        double Angolo = Convert.ToDouble(Console.ReadLine());

        double Angolor = (Angolo * Math.PI) / 180;
        double Tangente = Math.Sin(Angolor) / Math.Cos(Angolor);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"la tangente di {Angolo} è ----> {Tangente}");
    }

    private static void ArcoSeneno()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI L'ANGOLO IL QUALE VUOI CALCOLARE L' ARCOSENO --> ");
        double Angolo = Convert.ToDouble(Console.ReadLine());

        double Angolor = (Angolo * Math.PI) / 180;
        double ArcSen = Math.Asin(Angolor);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"l'arcoseno di {Angolo} è ----> {ArcSen}");
    }

    private static void ArcoCoseno()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI L'ANGOLO IL QUALE VUOI CALCOLARE L' ARCOCOSENO --> ");
        double Angolo = Convert.ToDouble(Console.ReadLine());

        double Angolor = (Angolo * Math.PI) / 180;
        double ArcCos = Math.Acos(Angolor);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"l'arcocoseno di {Angolo} è ----> {ArcCos}");
    }

    private static void ArcoTangente()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI L'ANGOLO IL QUALE VUOI CALCOLARE L' ARCOCOTANGENTE --> ");
        double Angolo = Convert.ToDouble(Console.ReadLine());

        double Angolor = (Angolo * Math.PI) / 180;
        double ArcTan = Math.Atan(Angolor);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"l'arcocoseno di {Angolo} è ----> {ArcTan}");
    }

    private static void StampaPari()
    {
        int numero = 0, contap = 0;

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        do
        {

            Console.Write("INSERISCI NUMERO PARI FINO A CHE NUMERO STAMPARE TUTTI I PARI --> ");
            numero = Convert.ToInt32(Console.ReadLine());

        } while (numero % 2 != 0);


        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");

        Console.WriteLine($"------------------ I NUMERI PARI FINO A {numero} SONO I SEGUENTI -----------------");
        Console.WriteLine("");

        for (int i = 0; i <= numero; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(" " + i);
                contap++;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($" PER IL NUMERO {numero} CI SONO ---> {contap} NUMERI PARI");
    }

    private static void StampaDispari()
    {
        int numero = 0, contad = 0;

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        do
        {

            Console.Write("INSERISCI NUMERO DISPARI FINO A CHE NUMERO STAMPARE TUTTI I DISPARI --> ");
            numero = Convert.ToInt32(Console.ReadLine());

        } while (numero % 2 != 1);


        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");

        Console.WriteLine($"------------------ I NUMERI DISPARI FINO {numero} SONO I SEGUENTI ------------------");
        Console.WriteLine("");

        for (int i = 0; i <= numero; i++)
        {
            if (i % 2 == 1)
            {
                Console.Write(" " + i);
                contad++;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($" PER IL NUMERO {numero} CI SONO ---> {contad} NUMERI PARI");
    }

    private static void StampaNnumeriDivisibilipperN()
    {

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI NUMERO DI VALORI DA VEDERE --> ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.Write("INSERISCI IL NUMERO IL QUALE VUOI VEDERE I DIVISIBILI ---> ");
        int divisibili = Convert.ToInt32(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");

        Console.WriteLine($"------------------ I NUMERI DIVISIBILI DI {divisibili} PER {numero} VOLTE SONO I SEGUENTI ------------------");
        Console.WriteLine("");

        for (int i = 0, j = 0; j < numero; i++)
        {
            if (i % divisibili == 0)
            {
                Console.Write(" " + i);
                j++;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("");
    }

    private static void CalcolaNumeriPrimiDivisibiliperNumero (int[] numeri_primidivisibili)
    {
        int numero = InserisciNumeroPrimo();
        int conta = 0, contanumeriprimiprecedenti = 0;


        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");

        for(int i = 1; i <  numero; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    conta++;
            }

            if (conta == 2 || i == 1)
               numeri_primidivisibili[i] = i;
            else
                numeri_primidivisibili[i] = 0;

            conta = 0;
        }

        Console.WriteLine($"----------- I NUMERI PRIMI PRECEDENTI A {numero} SONO I SEGUENTI -----------");
        Console.WriteLine("");

        for(int i = 1; i < numero; i++)
        {
            if (numeri_primidivisibili[i] != 0)
            {
                Console.Write(" "+numeri_primidivisibili[i]);
                contanumeriprimiprecedenti++;
            }
        }

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("");
        Console.WriteLine("");

        if (contanumeriprimiprecedenti == 0)
            Console.WriteLine("NON CI SONO NUMERI PRIMI PRECEDENTI A " + numero);
        else
            Console.WriteLine($"CI SONO ---> {contanumeriprimiprecedenti} NUMERI PRIMI PRECEDENTI A {numero}");
    }

    private static int InserisciNumeroPrimo()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI NUMERO FINO A CHE NUMERO VUOI VEDERE TUTTI I NUMERI PRIMI PRECEDENTI --> ");
        int numero = Convert.ToInt32(Console.ReadLine());

        return numero;
    }
}