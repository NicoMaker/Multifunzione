public class InfoMath
{
    public static void Radici()
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

    public static void Esponenzili()
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


    public static void Logaritmo()
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
    public static void Valori_assoluti()
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

    public static void Seno()
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

    public static void Coseno()
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

    public static void Tangente()
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

    public static void ArcoSeneno()
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

    public static void ArcoCoseno()
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

    public static void ArcoTangente()
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

    public static void StampaPari()
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

    public static void StampaDispari()
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

    public static void StampaNnumeriDivisibilipperN()
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

    public static void CalcolaNumeriPrimiDivisibiliperNumero(int[] numeri_primidivisibili)
    {
        int numero = InserisciNumeroPrimo();
        int conta = 0, contanumeriprimiprecedenti = 0;


        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");

        for (int i = 1; i < numero; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    conta++;
            }

            if (conta == 2)
                numeri_primidivisibili[i] = i;
            else
                numeri_primidivisibili[i] = 0;

            conta = 0;
        }

        Console.WriteLine($"----------- I NUMERI PRIMI PRECEDENTI A {numero} SONO I SEGUENTI -----------");
        Console.WriteLine("");

        for (int i = 1; i < numero; i++)
        {
            if (numeri_primidivisibili[i] != 0)
            {
                Console.Write(" " + numeri_primidivisibili[i]);
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

    public static void Fibonacci()
    {
        int somma = 0;

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI NUMERO FINO A CHE NUMERO IL QUALE VUOI CALCOLARE FIBONACCI --> ");
        int numero = Convert.ToInt32(Console.ReadLine());

        List<int> fib = new List<int>()
        {
            1, 1
        };

        for (int i = fib.Count; i < numero; i++)
            fib.Add(fib[i - 1] + fib[i - 2]);

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" ");
        Console.WriteLine("---------- SUCCESSIONE DI FIBONACCI DEL NUMERO " + numero + " ----------");
        Console.WriteLine(" ");

        foreach (int i in fib)
        {
            Console.Write(i + " ");
            somma += i;
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine($"il numero di Fibonacci del numero {numero} è ----> {somma}");
    }

    public static void Binario_Decimale()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        string numero = "";
        double numero_decimale = 0;
        int conta = 0;

        Console.WriteLine("");

        do
        {
            conta = 0;
            Console.Write("inserisci un numero in binario da convertire in decimale ---> ");
            numero = Console.ReadLine();

            for (int i = 0; i <= numero.Length - 1; i++)
            {
                if (numero[i] == '0' || numero[i] == '1')
                    conta += 0;
                else
                    conta++;
            }

            if (conta > 0)
                Console.WriteLine("numero non valido");

        } while (conta > 0);

        for (int i = numero.Length - 1, j = 0; i >= 0; i--, j++)
        {
            if (numero[i] == '1')
                numero_decimale += Math.Pow(2, j);
            else
                numero_decimale += 0;
        }


        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"numero binario ---> {numero}, numero decimale ---> {numero_decimale}");
        Console.WriteLine("");
    }

    public static void Decimale_Binario()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine("");

        Console.Write("inserisci un numero in decimale da convertire in binario ---> ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int numero_dec = numero;


        string numero_binario_valori = " ";

        while (numero != 0)
        {
            if (numero % 2 == 1)
            {
                numero_binario_valori += '1';
                numero = (numero - 1) / 2;
            }
            else
            {
                numero_binario_valori += '0'; ;
                numero = numero / 2;
            }
        }

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"numero decimale ---> {numero_dec}, numero binario ---> ");

        for (int i = numero_binario_valori .Length - 1; i >= 0; i--)
            Console.Write(numero_binario_valori[i]);

        Console.WriteLine("");
        Console.WriteLine("");
    }

    public static void Triangolo_di_Tartaglia()
    {
        const int numero_max = 32;

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        int righe = 0;
        int[,] Tartaglia = new int[numero_max, numero_max];

        do
        {
            Console.Write("inserisci numero righe per il triangolo di tartaglia ---> ");
            righe = Convert.ToInt32(Console.ReadLine());

        } while ((righe >= numero_max) || (righe < 1));

        Console.WriteLine("");


        // prima righa
        Tartaglia[0, 0] = 1;

        for (int j = 1; j < numero_max; j++)
            Tartaglia[0, j] = 0;

        //calcolo le altre righe		
        for (int i = 1; i < numero_max; i++)
        {
            Tartaglia[i, 0] = 1;

            for (int j = 1; j < righe; j++)
                Tartaglia[i, j] = Tartaglia[i - 1, j - 1] + Tartaglia [i - 1, j];
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        //visualizzazione triangolo di tartaglia

        for (int i = 0; i < righe; i++)
        {
            Console.Write($"{i+1} riga ---> ");

            for (int j = 0; j <= i; j++)
                Console.Write(Tartaglia[i, j] + " ");

            Console.WriteLine("");
        }

        Console.WriteLine("");
    }
}