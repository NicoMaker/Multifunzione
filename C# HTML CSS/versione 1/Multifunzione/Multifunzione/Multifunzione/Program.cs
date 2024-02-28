Ciclo_principale.Funzioni();

public class Ciclo_principale
{
    public static void Funzioni()
    {
        int s = 0, moneta = 0, numerop = 0, lettere = 0, dadi = 0, numero = 0, numeri = 0, posizione = 0;
        const int Vettore = 30000000;

        string[] utenti = new string[Vettore];
        string[] password = new string[Vettore];
        float[] Parte_reale = new float[Vettore];
        float[] Parte_immaginaria = new float[Vettore];
        int[] Numeripr = new int[Vettore];
        string[] nomiTiroConArco = new string[Vettore];
        double[] punteggiTiroConArco = new double[Vettore];

        do
        {
            Console.Clear();
            s = Menù.Informazioni(s);

            switch (s)
            {
                case 1:

                    moneta = Moneta.Iserisci();
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("il numero delle monete è ---> " + moneta);
                    Console.WriteLine("");
                    break;

                case 2:
                    Moneta.Visualizza(moneta);
                    break;

                case 3:
                    int numero1A = Ahmes.Inserisci1();
                    int numero2A = Ahmes.Inserisci2();
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    int risultato = Ahmes.Visualizza(numero1A, numero2A);
                    Console.WriteLine($"il risultato è ---> {risultato}");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;


                case 4:
                    numerop = Password.InserisciNumeroPassword(utenti);
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("password da generare --> " + numerop);
                    Console.WriteLine("");
                    break;

                case 5:
                    Console.WriteLine("");
                    Password.Crea(numerop, utenti, password);
                    Console.WriteLine("");
                    break;

                case 6:
                    Console.WriteLine("");
                    Password.Visualizza(numerop, utenti, password);
                    Console.WriteLine("");
                    break;

                case 7:
                    Console.WriteLine("");
                    numerop = Password.InserisciALtriUtenti(numerop, utenti, password);
                    Console.WriteLine("");
                    break;

                case 8:
                    Console.WriteLine("");
                    Password.ControllaPassword(numerop, utenti, password);
                    Console.WriteLine("");
                    break;

                case 9:
                    Console.WriteLine("");
                    Password.ControllaNomeUtente(numerop, utenti, password);
                    Console.WriteLine("");
                    break;

                case 10:

                    Console.WriteLine("");
                    lettere = Lettere.Inserisci();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("");
                    Console.WriteLine("il numero di lettere da generare  è ----> " + lettere);
                    Console.WriteLine("");
                    break;

                case 11:
                    Console.WriteLine("");
                    Lettere.Visualizza(lettere);
                    break;

                case 12:
                    Console.WriteLine("");
                    dadi = Dadi.Inserisci();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("");
                    Console.WriteLine("il numero di dadi da lanciare  è ----> " + dadi);
                    Console.WriteLine("");
                    break;

                case 13:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    numero = Dadi.Visualizza(dadi);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"il numero genrato dal lancio di {dadi} dadi è ----> " + numero);
                    Console.WriteLine("");
                    break;

                case 14:
                    Console.WriteLine("");
                    Pasqua.Crea();
                    Console.WriteLine("");
                    break;

                case 15:
                    Console.WriteLine("");
                    int collatz = Collatz.Inserisci();
                    Collatz.Visualizza(collatz);
                    Console.WriteLine("");
                    break;

                case 16:
                    Console.WriteLine("");
                    int fact = Fact.Inserisci();
                    Fact.Crea(fact);
                    Console.WriteLine("");
                    break;

                case 17:
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    int numero1E = Euclide.Inserisci1();
                    int numero2E = Euclide.Inserisci2();
                    Euclide.Visualizza(numero1E, numero2E);
                    Console.WriteLine("");
                    break;

                case 18:
                    Console.WriteLine("");
                    numeri = Numeri_Complessi.InserisciNumeri(Parte_reale, Parte_immaginaria);
                    Console.WriteLine("");
                    break;

                case 19:
                    Console.WriteLine("");
                    Numeri_Complessi.Visualizza(numeri, Parte_reale, Parte_immaginaria);
                    Console.WriteLine("");
                    break;

                case 20:
                    Console.WriteLine("");
                    Numeri_Complessi.Somma(numeri, Parte_reale, Parte_immaginaria);
                    Console.WriteLine("");
                    break;

                case 21:
                    Console.WriteLine("");
                    Numeri_Complessi.Sottrazione(numeri, Parte_reale, Parte_immaginaria);
                    Console.WriteLine("");
                    break;

                case 22:
                    Console.WriteLine("");
                    int numeropr = Numeri_Primi.Inserisci();
                    Numeri_Primi.Visualizza(numeropr, Numeripr);
                    Console.WriteLine("");
                    break;

                case 23:

                    Console.WriteLine("");
                    Polinomi.Visualizza();
                    Console.WriteLine("");
                    break;

                case 24:
                    Console.WriteLine("");
                    Matematica.Scelta();
                    Console.WriteLine("");
                    break;

                case 25:
                    Console.WriteLine("");
                    Sasso_Carta_forbice.Gioco();
                    Console.WriteLine("");
                    break;

                case 26:
                    Console.WriteLine("");
                    Tabelline.Crea();
                    Console.WriteLine("");
                    break;

                case 27:
                    Console.WriteLine("");
                    double numeroB = Babilonia.Inserisci_numero();
                    double epsion = Babilonia.Inserisci_errore();
                    Babilonia.Visualizza(numeroB, epsion);
                    Console.WriteLine("");
                    break;

                case 28:
                    Console.WriteLine("");
                    string frase = Cesare.Inserisci_frase();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("");
                    string encripted = Cesare.Cripta(frase);
                    Console.WriteLine($"il messaggio {frase} è stato criptato con ---> {encripted}");

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("VUOI VEDERE LA DECRIPTAZIONE ? scrivi SI --->  ");
                    string Visualizza = Console.ReadLine();
                    Console.WriteLine("");

                    if (Visualizza == "SI")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        string decripted = Cesare.Decripta(encripted);
                        Console.WriteLine($"il messaggio {encripted} è stato decriptato con ---> {decripted}");
                    }
                    break;

                case 29:
                    Console.WriteLine("");
                    string frasecripto = Cripto.Inserisci_frase();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("");
                    string encriptedcripto = Cripto.Cripta(frasecripto);
                    Console.WriteLine($"il messaggio {frasecripto} è stato criptato con ---> {encriptedcripto}");

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("VUOI VEDERE LA DECRIPTAZIONE ? scrivi SI --->  ");
                    string Visualizzacripto = Console.ReadLine();
                    Console.WriteLine("");

                    if (Visualizzacripto == "SI")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        string decriptedcripto = Cripto.Decripta(encriptedcripto);
                        Console.WriteLine($"il messaggio {encriptedcripto} è stato decriptato con ---> {decriptedcripto}");
                    }
                    break;

                case 30:
                    Console.WriteLine("");
                    posizione = TiroConArco.Ntiri(nomiTiroConArco, punteggiTiroConArco, posizione);
                    break;

                case 31:
                    Console.WriteLine("");
                    posizione = TiroConArco.VentiTiri(nomiTiroConArco, punteggiTiroConArco, posizione);
                    break;

                case 32:
                    Console.WriteLine("");
                    TiroConArco.Visualizza(nomiTiroConArco, punteggiTiroConArco, posizione);
                    break;

                case 33:
                    Console.WriteLine("");
                    TiroConArco.ContollaUtente(nomiTiroConArco, punteggiTiroConArco, posizione);
                    break;

                case 34:
                    Console.WriteLine("");
                    posizione = TiroConArco.AzzeraVettore(posizione);
                    break;

                case 35:
                    string alfabeto = "abcdefghijklmnopqrstuvwxyz";

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    string originale = CriptoChiave.InserisciTesto();

                    int chiave = CriptoChiave.InserisciChiave();
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("");
                    Console.WriteLine($"SPOSTO DI {chiave} POSTI LA CHIAVE ");
                    Console.WriteLine("");

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    string criptato = CriptoChiave.Cripta(originale, alfabeto, chiave);
                    Console.WriteLine($"il messaggio {originale} è stato criptato con ---> {criptato}");

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("");
                    Console.Write("VUOI VEDERE LA DECRIPTAZIONE ? scrivi SI --->  ");
                    string Sicripto = Console.ReadLine();
                    Console.WriteLine("");

                    if (Sicripto == "SI")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        string decriptato = CriptoChiave.Decripta(criptato, alfabeto, chiave);
                        Console.WriteLine($"il messaggio {criptato} è stato decriptato con ---> {decriptato}");
                    }
                    Console.WriteLine("");

                    break;

                default:

                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("TASTO INVALIDO !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                    break;

            }

            Console.WriteLine(" ");
            Console.Write("PREMI UN TASTO PER CONTINUARE ---> ");
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.Clear();

        } while (s != 0 && s <= 35);
    }
}

public class Menù
{
    public static int Informazioni(int s)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine("<------------------------------------------------------------------- BENVENUTI NEL MIO MENU' ------------------------------------------------------------->");
        Console.WriteLine("");
        Informazioni_Programma.Info();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("0 e numeri maggiori di 35. USCITA");
        Console.WriteLine("");
        Console.WriteLine("<-------------------------------------------------------------------------------------------------------------------------------------------------------->");
        Console.WriteLine("");

        Console.Write("INSERISCI SCELTA  --->  ");
        s = Convert.ToInt32(Console.ReadLine());

        return s;

    }
}

public class Informazioni_Programma
{
    public static void Info()
    {
        InformazioniMoneta();
        InformazioniAhmes();
        InformazioniPassword();
        InformazioniLettere();
        InformazioniDadi();
        InformazioniPasqua();
        InformazioniCollaztz();
        InformazioniFact();
        InformazioniEuclide();
        InformazioniNumeri_complessi();
        InformazioniNumeriPrimi();
        InformazioniPolinomi();
        InformazioniMatematica();
        InformazioniSasso_Carta_forbice();
        InformazioniTabelline();
        InformazioniMetodoBabilonese();
        InformazioniCesare();
        InformazioniCripto();
        InformazioniGaraTiroConarco();
        InformazioniCriptoChiave();
    }

    private static void InformazioniMoneta()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("1. INSERISCI N MONETE ");
        Console.WriteLine("2. VISUALIZZA LANCIO MONETE");
    }

    private static void InformazioniAhmes()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("3. AHMES");
    }

    private static void InformazioniPassword()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("4. INSERISCI QUANTE PASSWORD GENERARE");
        Console.WriteLine("5. GENERA PASSWORD");
        Console.WriteLine("6. VISULIZZA ELENCO PASSWORD UTENTI");
        Console.WriteLine("7. INSERISCI ALTRI UTENTI");
        Console.WriteLine("8. VISULIZZA INSERENDO LA PASSWORD DI CHE UTENTE E' SE NO NON E' DI NESSUNO");
        Console.WriteLine("9. VISUALIZZA LA PASSWORD DELL'UTENTE INSERENDO IL NOME UTENTE E SE L'UTENTE NON ESISTE DECIDI SE INSERISCILO E CREA LA PASSWORD");
    }

    private static void InformazioniLettere()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("10. INSERISCI QUANTE LETTERRE GENERARE");
        Console.WriteLine("11. GENERA LETTERE CASUALE ");
    }

    private static void InformazioniDadi()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("12. INSERISCI NUMERO DI DADI");
        Console.WriteLine("13. VISUALIZZA RISULTATO LANCIO DADI");
    }

    private static void InformazioniPasqua()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("14. CALCOLA LA DATA DI PASQUA");
    }


    private static void InformazioniCollaztz()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("15. COLLATZ");
    }

    private static void InformazioniFact()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("16. FATTORIALE !");
    }

    private static void InformazioniEuclide()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("17. EUCLIDE");
    }

    private static void InformazioniNumeri_complessi()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("18. INSERISCI NUMERI COMPLESSI");
        Console.WriteLine("19. VISUALIZZA NUMERI");
        Console.WriteLine("20. SOMMA NUMERI COMPLESSI");
        Console.WriteLine("21. SOTTRAZIONE NUMERI COMPLESSI");
    }

    private static void InformazioniNumeriPrimi()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("22. CALCOLA SE NUMERO E'NUMERO PRIMO");
    }

    private static void InformazioniPolinomi()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("23. FAI POLINOMI FINO AL 4 GRADO ");
    }

    private static void InformazioniMatematica()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("24. SCEGLI SE FARE CALCOLI MATEMATICI");
    }

    private static void InformazioniSasso_Carta_forbice()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("25. GIOCO SASSO CARTA FORBICE");
    }

    private static void InformazioniTabelline()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("26. FAI TABELLINE");
    }

    private static void InformazioniMetodoBabilonese()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("27. FAI RADICI CON METEDO BABILONESE");
    }

    private static void InformazioniCesare()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("28. CRIPTA MESSAGGIO CODICE DI CESARE ");
    }

    private static void InformazioniCripto()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("29. CRIPTA MESSAGGIO CON ALFABETO OPPOSTO ");
    }

    private static void InformazioniGaraTiroConarco()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("30. INSERISCI QUANTI LANCI VUOI TIRARE A OGNI TENTATIVO CON N TENTATIVI DECISI DA TASTIERA E VISULAIZZA TENTATIVO MIGLORE E SE INSERIRLO NEL VETTORE UTENTI");
        Console.WriteLine("31. INSERISCI QUANTI LANCI VUOI TIRARE A OGNI TENTATIVO CON 20 TENTATIVI VISULIZZA IL TENTATIVO MIGLORE E VISULIZZA SE INSERIRLO NEL VETTORE UTENTI");
        Console.WriteLine("32. VISUALIZZA VETTORE UTENTI E MIGLORE PUNTEGGIO CON IL SUO NOME");
        Console.WriteLine("33. INSERISCI NOME E DICE QUANTI PUNTI HA SE NO NON ESISTE UTENTE  E STAMPA ALRI UTENTI SE ESISTE UTENTE DIMMI SE E' IL MIGLORE");
        Console.WriteLine("34. AZZERA VETTORE");
    }

    private static void InformazioniCriptoChiave()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("35. CRIPTA MESSAGGIO CON POSTO CHIAVE  ");
    }
}

public class Moneta
{
    public static int Iserisci()
    {
        int lanci2 = 0;

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("");
        Console.Write("inseriscci quante monete vuoi lanciare ---> ");
        string lanci = Console.ReadLine();
        lanci2 = Convert.ToInt32(lanci);

        return lanci2;
    }

    public static void Visualizza(int lanci2)
    {

        int testa = 0, croce = 0, casuale_testa_croce = 0;

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("");
        Console.WriteLine("il numero delle monete è ---> " + lanci2);
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.White;
        for (int tentativi = 0; tentativi < lanci2; tentativi++)
        {
            Random generatore = new Random();
            casuale_testa_croce = generatore.Next(0, 10);

            Console.Write(casuale_testa_croce + " ");

            if (casuale_testa_croce % 2 == 0)
                testa++;
            else
                croce++;
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("--------------- I RISULTATI SONO : --------------- -");
        Console.WriteLine("");
        Console.WriteLine("\t \t TESTA -----> {0}", testa);
        Console.WriteLine("\t \t CROCE -----> {0}", croce);
        Console.WriteLine("");

        Console.WriteLine("");

        if (testa > croce)
            Console.WriteLine("\t \t HA VINTO TESTA");
        else
            Console.WriteLine(croce > testa ? "\t \t HA VINTO CROCE" : "\t NON HA VINTO NESSUNO PERCHE' SONO UGUALI");


        Console.WriteLine("");
    }
}

public class Ahmes
{

    public static int Inserisci1()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("");
        Console.Write("INSERISCI IL PRIMO NUMERO -->  ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        return numero1;

    }

    public static int Inserisci2()
    {
        Console.Write("INSERISCI IL SECONDO NUMERO -->  ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        return numero2;
    }

    public static int Visualizza(int numero1, int numero2)
    {
        int resto = 0, passaggio = 0;
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkRed;

        Console.WriteLine("il primo numero è --> " + numero1);
        Console.WriteLine("il secondo numero è --> " + numero2);

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.Yellow;

        while (numero1 > 0)
        {
            passaggio++;

            if (numero1 % 2 == 0)
            {
                Console.WriteLine($"{passaggio} passaggio se {numero1} è pari allora  --> ({numero1} / 2) * (2 * {numero2}) ");
                numero1 = numero1 / 2;
                numero2 = numero2 * 2;
            }
            else
            {

                Console.WriteLine(resto == 0 ? $"{passaggio} passaggio se {numero1} è dispari allora --> ({numero1} - 1) * ({numero2} + {numero2})" : $"{passaggio} passaggio se {numero1} è dispari allora --> ({numero1} - 1) * ({numero2} + {resto})");

                numero1--;
                resto += numero2;
            }
        }

        int risultato = resto;

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("");
        Console.WriteLine($"il calcolo è stato fatto in --> {passaggio} passaggi");

        return risultato;
    }
}

public class Password
{
    public static int InserisciNumeroPassword(string[] utenti)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" ");
        Console.Write("inserisci quante password vuoi generare ---> ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        for (int i = 1; i <= numero; i++)
        {
            Console.Write($"inserisci {i} utente --> ");
            utenti[i] = Console.ReadLine();
        }
        return numero;

    }
    public static void Crea(int numero, string[] utenti, string[] password)
    {

        Console.WriteLine("");

        for (int i = 1; i <= numero; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{i} utente è ---> {utenti[i]}");
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("");
        Console.WriteLine("Password da generare --> " + numero);
        Console.WriteLine("");

        int misura;
        const int Vettore = 30000000;
        int[] numeri_casuali = new int[Vettore];

        string pass = @"0123456789ABCDEFGHIJKLMNOPQRSTUVXWYZabcdefghijklmnopqrstuvwxyz@#+-!\\|&%()*/", lettera = "";
        for (int i = 1; i <= numero; i++)
        {

            Console.WriteLine("");

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"inserisci misura password di {utenti[i]} almeno 8 caratteri ---> ");
                misura = Convert.ToInt32(Console.ReadLine());

            } while (misura < 8);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");
            Console.Write("password  di " + utenti[i] + " è --> ");

            for (int j = 1; j <= misura; j++)
            {
                Random r = new Random();
                int casuale = r.Next(0, pass.Length - 1);
                numeri_casuali[j] = casuale;

                if (j > 0)
                {
                    while (numeri_casuali[j] == numeri_casuali[j - 1])
                    {
                        if (numeri_casuali[j] > 9)
                        {
                            casuale = r.Next(0, pass.Length - 1);
                            numeri_casuali[j] = casuale;
                        }
                    }
                }

                lettera += pass[casuale];
                password[i] = lettera;
                Console.Write(pass[casuale]);

            }
            lettera = "";
            Console.WriteLine("");
        }

    }

    public static void Visualizza(int numero, string[] utenti, string[] password)
    {
        StampaPassSuText PassText;
        PassText = new StampaPassSuText("D:/Corso ITS IIOT/Progetti C#/CORSO OPP./Password.txt");
        PassText.Cancella("D:/Corso ITS IIOT/Progetti C#/CORSO OPP./Password.txt");

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("---------- ELENCO UTENTI CON PASSWORD ----------");
        Console.WriteLine("");

        PassText.Scrivi("---------- ELENCO UTENTI CON PASSWORD ----------");
        PassText.Scrivi(" ");

        for (int i = 1; i <= numero; i++)
        {
            Console.WriteLine($"utente {utenti[i]} password ----> {password[i]}");
            PassText.Scrivi($"{i} utente {utenti[i]} password ----> {password[i]}");
        }
    }

    public static void ControllaPassword(int numero, string[] utenti, string[] password)
    {
        string inserisci = "";
        int conta = 0;


        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("");
        Console.Write("inserisci password che vuoi vedere di che utente è --> ");
        inserisci = Console.ReadLine();
        Console.WriteLine("");
        conta = 0;

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        for (int i = 1; i <= numero; i++)
        {
            if (password[i] == inserisci)
            {
                Console.WriteLine($"la password che hai inserito {inserisci} e' di ---> {utenti[i]}");
                conta = 1;
            }

        }
        if (conta == 0)
        {
            Console.WriteLine($"la password che hai inserito {inserisci} non è di nessuno");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");
            Console.WriteLine("---------- LE PASSWORD POSSONO ESSRE LE SEGUENTI ----------");
            Console.WriteLine("");

            for (int i = 1; i <= numero; i++)
                Console.WriteLine($"utente {utenti[i]} password ---> {password[i]}");

        }

    }

    public static int InserisciALtriUtenti(int numero, string[] utenti, string[] password)
    {
        int misura;
        const int Vettore = 30000000;
        int[] numeri_casuali = new int[Vettore];

        string pass = @"0123456789ABCDEFGHIJKLMNOPQRSTUVXWYZabcdefghijklmnopqrstuvwxyz@#+-!\\|&%()*/", lettera = "";


        Console.ForegroundColor = ConsoleColor.DarkRed;

        Console.Write("inserisci quante utenti vuoi aggiungere ---> ");
        int inserisci = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        for (int i = numero + 1; i <= numero + inserisci; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"inserisci nome {i} utente ---> ");
            utenti[i] = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
        }

        for (int i = numero + 1; i <= numero + inserisci; i++)
        {
            Console.WriteLine("");

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"inserisci misura password di {utenti[i]} almeno 8 caratteri ---> ");
                misura = Convert.ToInt32(Console.ReadLine());

            } while (misura < 8);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");
            Console.Write("password  di " + utenti[i] + " è --> ");

            for (int j = 1; j <= misura; j++)
            {
                Random r = new Random();
                int casuale = r.Next(0, pass.Length - 1);
                numeri_casuali[j] = casuale;

                if (j > 0)
                {
                    while (numeri_casuali[j] == numeri_casuali[j - 1])
                    {
                        if (numeri_casuali[j] > 9)
                        {
                            casuale = r.Next(0, pass.Length - 1);
                            numeri_casuali[j] = casuale;
                        }
                    }
                }

                lettera += pass[casuale];
                password[i] = lettera;
                Console.Write(pass[casuale]);

            }
            lettera = "";
            Console.WriteLine("");
        }

        numero += inserisci;


        return numero;

    }

    public static void ControllaNomeUtente(int numero, string[] utenti, string[] password)
    {
        string pass = @"0123456789ABCDEFGHIJKLMNOPQRSTUVXWYZabcdefghijklmnopqrstuvwxyz@#+-!\\|&%()*/", lettera = "";
        int conta = 0, misura;
        const int Vettore = 30000000;
        int[] numeri_casuali = new int[Vettore];

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.Write("inserisci nome utente da controllare --> ");
        string nome = Console.ReadLine();
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        for (int i = 1; i <= numero; i++)
        {
            if (nome == utenti[i])
            {
                Console.WriteLine($"L'utente {nome} ha la password --> {password[i]}");
                conta = 1;
            }
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;

        if (conta == 0)
        {
            Console.WriteLine($"non esiste l'utente {nome}");
            Console.WriteLine("");

            Console.WriteLine("----GLI UTENTI SONO I SEGUENTI----");
            Console.WriteLine("");

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine($"utente {utenti[i]} ---> {password[i]}");
            }
        }
    }
}

public class Lettere
{
    public static int Inserisci()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.Write("Inserisci quante lettere casuali vuoi genrare ---> ");
        int lettere = Convert.ToInt32(Console.ReadLine());

        return lettere;
    }

    public static void Visualizza(int lettere)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine("il numero delle letetre da generare ----> " + lettere);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("");

        Console.WriteLine("---------- ELENCO LETTERE CASUALI ---------");
        Console.WriteLine("");

        string lettera = "ABCDEFGHIJKLMNOPQRSTUVXYWZ";


        for (int i = 1; i <= lettere; i++)
        {
            Random generatore = new Random();
            int casuale = generatore.Next(0, lettera.Length - 1);

            Console.WriteLine($"la {i} lettera casuale è ----> {lettera[casuale]}");
        }
        Console.WriteLine("");
    }
}

public class Dadi
{
    public static int Inserisci()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.Write("Inserisci quanti dadi vuoi lanciare ---> ");
        int lanci = Convert.ToInt32(Console.ReadLine());

        return lanci;
    }

    public static int Visualizza(int lanci)
    {
        int numero = 0;

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        for (int i = 1; i <= lanci; i++)
        {
            Random generatore = new Random();
            int numero_generato = generatore.Next(1, 7);
            numero += numero_generato;
            Console.Write(numero_generato + " ");
        }
        Console.WriteLine("");
        Console.WriteLine("");

        return numero;
    }
}

public class Pasqua
{
    public static void Crea()
    {
        int anno = 0, anno_corrente = 0, a = 0, b = 0, c = 0, d = 0, e = 0, f = 0;

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("");
        Console.Write("INSERISCI L'ANNO PER CUI CALCOLARE LA DATA DI PASQUA ---> ");
        anno = Convert.ToInt32(Console.ReadLine());

        Console.Write("INSERISCI L'ANNO CORRENTE ---> ");
        anno_corrente = Convert.ToInt32(Console.ReadLine());

        a = anno % 19;
        b = anno % 4;
        c = anno % 7;
        d = 19 * a;
        d += 24;
        d = d % 30;
        e = 2 * b;
        e += 4 * c;
        e += 6 * d;
        e += 5;
        e = e % 7;
        f = d + e;

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        if (anno < anno_corrente)
        {
            if ((d == 28) && (e == 6))
                Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " è stato il 18 APRILE");
            else
            {
                if ((d == 29) && (e == 6))
                    Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " è stato il 19 APRILE");
                else
                {
                    if (f <= 9)
                    {
                        f += 22;
                        Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " è stato il " + f + " MARZO");
                    }
                    else
                    {
                        f -= 9;
                        Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " è stato il " + f + " APRILE");
                    }
                }
            }
        }
        else
        if ((d == 28) && (e == 6))
            Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " sarà il 18 APRILE");
        else
        {
            if ((d == 29) && (e == 6))
                Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " sarà il 19 APRILE");
            else
            {
                if (f <= 9)
                {
                    f += 22;
                    Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " sarà il " + f + " MARZO");
                }
                else
                {
                    f -= 9;
                    Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " sarà il " + f + " APRILE");
                }
            }
        }
    }
}

public class Collatz
{
    public static int Inserisci()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.Write("INSERISCI IL NUMERO IL QUALE VOGLIO FARE COLLATZ ---> ");
        int numero = Convert.ToInt32(Console.ReadLine());

        return numero;
    }

    public static void Visualizza(int numero)
    {
        int k = 0;

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("");

        while (numero > 1)
        {
            Console.Write(" " + numero + " -->");

            if (numero % 2 == 0)
            {
                numero = numero / 2;
                k++;
            }
            else
            {
                numero = 3 * numero + 1;
                k++;
            }
        }

        Console.Write(" 1");

        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" K ---> " + k);
    }
}

public class Fact
{
    public static int Inserisci()
    {
        int numero = 0;

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("INSERISCI NUMERO PER FARE IL FATTORILAE ! ----> ");
        numero = Convert.ToInt32(Console.ReadLine());

        return numero;
    }

    public static void Crea(int numero)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int fact = 1;
        int i = numero;

        if (i == 0)
            fact = 1;

        while (i > 0)
        {
            fact = fact * i;
            i--;
        }

        Console.WriteLine();
        Console.WriteLine($"{numero}! ----> {fact}");
    }

}

public class Euclide
{
    public static int Inserisci1()
    {
        Console.Write("INSERISCI PRIMO NUMERO ---> ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        return numero1;
    }

    public static int Inserisci2()
    {
        Console.Write("INSERISCI SECONDO NUMERO ---> ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        return numero2;
    }

    public static void Visualizza(int numero1, int numero2)
    {
        int passaggio = 0;
        int resto = numero1 % numero2;
        int quoziente = numero1 / numero2;

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        while (resto > 0)
        {
            passaggio++;
            Console.WriteLine($"{passaggio} passaggio ----> {numero1} = {numero2} * {quoziente} + {resto}");
            numero1 = numero2;
            numero2 = resto;
            resto = numero1 % numero2;
            quoziente = numero1 / numero2;
        }

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine($"Per ricavare l'MCD sono serviti ---> {passaggio} passaggi");
        Console.WriteLine("MCD ----> " + numero2);

    }
}

public class Numeri_Complessi
{
    public static int InserisciNumeri(float[] Parte_reale, float[] Parte_immaginaria)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("INSERISCI QUANTI NUMERI COMPLESSI VUOI AGGIUNGERE --> ");
        int numeri = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        for (int i = 1; i <= numeri; i++)
        {
            Console.Write($"Inserisci {i} numero reale --> ");
            Parte_reale[i] = float.Parse(Console.ReadLine());
            Console.Write($"Inserisci {i} numero immaginario --> ");
            Parte_immaginaria[i] = float.Parse(Console.ReadLine());
        }

        return numeri;
    }

    public static void Visualizza(int numeri, float[] Parte_reale, float[] Parte_immaginaria)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("----------- I NUMERI COMPLESSI INSERITI SONO -----------");
        Console.WriteLine("");

        for (int i = 1; i <= numeri; i++)
            Console.WriteLine($"{i} NUMERO COMPLESSO Z INSERITO E' ----> {Parte_reale[i]} + ({Parte_immaginaria[i]} i) ");
    }

    public static void Somma(int numeri, float[] Parte_reale, float[] Parte_immaginaria)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        float sommar = 0, sommai = 0;

        for (int i = 1; i <= numeri; i++)
        {
            sommar += Parte_reale[i];
            sommai += Parte_immaginaria[i];
        }

        Console.WriteLine($"IL RISULTATO FINALE DELLA SOMMA DI {numeri} NUMERI COMPLESSI E' ---> {sommar} + ({sommai} i)");
    }

    public static void Sottrazione(int numeri, float[] Parte_reale, float[] Parte_immaginaria)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        float sottrazioner = 0, sottrazionei = 0;

        for (int i = 1; i <= numeri; i++)
        {
            if (i == 1)
            {
                sottrazioner += Parte_reale[i];
                sottrazionei += Parte_immaginaria[i];
            }
            else
            {
                sottrazioner -= Parte_reale[i];
                sottrazionei -= Parte_immaginaria[i];
            }
        }

        Console.WriteLine($"IL RISULTATO FINALE DELLA SOTTRAZIONE DI {numeri} NUMERI COMPLESSI E' ---> {sottrazioner} - ({sottrazionei} i)");
    }
}

public class Numeri_Primi
{
    public static int Inserisci()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.Write("INSERISCI IL NUMERO IL QUALE VEDERE SE E' NUMERO PRIMO -----> ");
        int numero = Convert.ToInt32(Console.ReadLine());

        return numero;
    }

    public static void Visualizza(int numero, int[] Numeripr)
    {
        Console.WriteLine("");
        int conta = 0;

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Numeripr[i] = i;
                conta++;
            }
            else
                Numeripr[i] = 0;
        }

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"------------------ I NUMERI DIVISIBILI PER {numero} SONO I SEGUENTI -------------------");
        Console.WriteLine("");

        for (int i = 1; i <= numero; i++)
        {
            if (Numeripr[i] != 0)
                Console.Write($" {Numeripr[i]}");
        }

        Console.WriteLine("");
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine("");

        if (conta == 2 || numero == 1)
            Console.WriteLine($"\t \t IL NUMERO {numero} è primo");
        else
            Console.WriteLine($"\t \t IL NUMERO {numero} non è primo");

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("IL NUMERO " + numero + " E' DIVISIBILE PER " + conta + " NUMERI");

    }
}

public class Polinomi
{
    public static void Visualizza()
    {
        int grado = 0, primo_grado = 0, secondo_grado = 0;

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.Write("INSERISCI IL PRIMO NUMERO  ---> ");
        float primo_numero = float.Parse(Console.ReadLine());
        Console.Write("INSERISCI PRIMA LETTERA  ---> ");
        string primo_lettera = Console.ReadLine();
        do
        {
            Console.Write("INSERISCI 1 GRADO MAGGIORE DI 0 ---> ");
            primo_grado = Convert.ToInt16(Console.ReadLine());
        }
        while (primo_grado <= 0);

        Console.Write("INSERISCI IL SECONDO NUMERO  ---> ");
        float secondo_numero = float.Parse(Console.ReadLine());
        Console.Write("INSERISCI SECONDA LETTERA  ---> ");
        string secondo_lettera = Console.ReadLine();
        do
        {
            Console.Write("INSERISCI 2 GRADO ---> ");
            secondo_grado = Convert.ToInt16(Console.ReadLine());
        } while (secondo_grado <= 0);

        do
        {
            Console.Write("INSERISCI GRADO DA 0 A 4 ---> ");
            grado = Convert.ToInt16(Console.ReadLine());
        }
        while (grado > 4 || grado < 0);

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        switch (grado)
        {
            case 0:
                Console.WriteLine("IL POLINIO E' UGUALE A ---> 1");
                break;
            case 1:
                Console.WriteLine("");
                Console.Write($"IL POLINOMIO E' UGUALE A ---> ({primo_numero} {primo_lettera}^{primo_grado})");
                Console.Write($" + ({secondo_numero} {secondo_lettera}^{secondo_grado})");
                Console.WriteLine("");
                break;
            case 2:
                Console.WriteLine("");
                Console.Write($"IL POLINOMIO E' UGUALE A ---> ({primo_numero * primo_numero} {primo_lettera} ^ {primo_grado * 2})");
                Console.Write($" + ({2 * primo_numero * secondo_numero} {primo_lettera} ^{primo_grado}{secondo_lettera} ^{secondo_grado})");
                Console.Write($" + ({secondo_numero * secondo_numero} {secondo_lettera}^{secondo_grado * 2} )");
                Console.WriteLine("");
                break;
            case 3:
                Console.WriteLine("");
                Console.Write($"IL POLINOMIO E' UGUALE A ---> ({primo_numero * primo_numero * primo_numero} {primo_lettera}^ {primo_grado + 3})");
                Console.Write($" + ({3 * primo_numero * secondo_numero} {primo_lettera}^{primo_grado + 2} {secondo_lettera}^{secondo_grado + 1})");
                Console.Write($" + ({3 * primo_numero * secondo_numero} {secondo_lettera}^{secondo_grado + 2} {primo_lettera}^{primo_grado + 1})");
                Console.Write($" + ({secondo_numero * secondo_numero * secondo_numero} {secondo_lettera}^{secondo_grado * 3})");
                Console.WriteLine("");
                break;

            case 4:
                Console.WriteLine("");
                Console.Write($"IL POLINOMIO E' UGUALE A ---> ({primo_numero * primo_numero * primo_numero * primo_numero} {primo_lettera}^{primo_grado * 4})");
                Console.Write($" + ({4 * primo_numero * secondo_numero} {primo_lettera}^{primo_grado + 3} {secondo_lettera}^{secondo_grado + 2})");
                Console.Write($" + ({6 * primo_numero * secondo_numero} {primo_lettera}^{primo_grado + 2} {secondo_lettera}^{secondo_grado + 2})");
                Console.Write($" + ({4 * primo_numero * secondo_numero} {primo_lettera}^{primo_grado} {secondo_lettera}^{secondo_grado + 3})");
                Console.Write($" + ({secondo_numero * secondo_numero * secondo_numero * secondo_numero} {secondo_lettera}^{secondo_grado * 4})");
                Console.WriteLine("");
                break;
        }

    }
}

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

    private static void CalcolaNumeriPrimiDivisibiliperNumero(int[] numeri_primidivisibili)
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

            if (conta == 2 || i == 1)
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
}

public class Sasso_Carta_forbice
{
    public static void Gioco()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("VUOI VEDERE LE REGOLE (SI O NO) ? ----> ");
        string visualizza_regole = Console.ReadLine();

        if (visualizza_regole == "SI")
            Regole();

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("INSERISCI NOME GIOCATORE 1 ---> ");
        string nome_giocatore1 = Console.ReadLine();

        Console.Write("INSERISCI NOME GIOCATORE 2 ---> ");
        string nome_giocatore2 = Console.ReadLine();

        int scelta_1 = Genera_1();
        int scelta_2 = Genera_2();

        string risultato_1 = Generacaso_1(scelta_1);
        string risultato_2 = Generacaso_2(scelta_2);

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine($"IL RISULTATO DI {nome_giocatore1} E' ----> {risultato_1}");
        Console.WriteLine($"IL RISULTATO DI {nome_giocatore2} E' ----> {risultato_2}");

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        while (risultato_1 == risultato_2)
        {
            Console.WriteLine("NON HA VINTO NESSUNO");

            scelta_1 = Genera_1();
            scelta_2 = Genera_2();

            risultato_1 = Generacaso_1(scelta_1);
            risultato_2 = Generacaso_2(scelta_2);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("");
            Console.WriteLine($"IL RISULTATO DI {nome_giocatore1} E' ----> {risultato_1}");
            Console.WriteLine($"IL RISULTATO DI {nome_giocatore2} E' ----> {risultato_2}");
            Console.WriteLine("");

        }

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        if (risultato_1 == "SASSO" && risultato_2 == "FORBICI")
            Console.WriteLine($"HA VINTO --> {nome_giocatore1}");
        else
            if (risultato_1 == "CARTA" && risultato_2 == "SASSO")
            Console.WriteLine($"HA VINTO --> {nome_giocatore1}");
        else
            if (risultato_1 == "FORBICI" && risultato_2 == "CARTA")
            Console.WriteLine($"HA VINTO --> {nome_giocatore1}");
        else
            if (risultato_2 == "SASSO" && risultato_1 == "FORBICI")
            Console.WriteLine($"HA VINTO --> {nome_giocatore2}");
        else
            if (risultato_2 == "CARTA" && risultato_1 == "SASSO")
            Console.WriteLine($"HA VINTO --> {nome_giocatore2}");
        else
            Console.WriteLine($"HA VINTO --> {nome_giocatore2}");
    }

    private static int Genera_1()
    {
        Random generatore = new Random();
        int scelta_1 = generatore.Next(0, 3);

        return scelta_1;
    }

    private static int Genera_2()
    {
        Random generatore = new Random();
        int scelta_2 = generatore.Next(0, 3);

        return scelta_2;
    }

    private static string Generacaso_1(int scelta_1)
    {
        string risultato_1 = "";
        switch (scelta_1)
        {
            case 0:
                risultato_1 = "SASSO";
                break;
            case 1:
                risultato_1 = "CARTA";
                break;
            case 2:
                risultato_1 = "FORBICI";
                break;
        }

        return risultato_1;
    }

    private static string Generacaso_2(int scelta_2)
    {
        string risultato_2 = "";

        switch (scelta_2)
        {
            case 0:
                risultato_2 = "SASSO";
                break;
            case 1:
                risultato_2 = "CARTA";
                break;
            case 2:
                risultato_2 = "FORBICI";
                break;
        }

        return risultato_2;
    }

    private static void Regole()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("");

        Console.WriteLine("------------------------ REGOLE -----------------------");
        Console.WriteLine("");
        Console.WriteLine("SASSO VINCE SU FORBICI MA PERDE CON CARTA");
        Console.WriteLine("CARTA VINCE SU SASSO MA PERDE CON FORBICI");
        Console.WriteLine("FORICI VIINCE SU CARTA MA PERDE CON SASSO");
        Console.WriteLine("SE SONO UGUALI RIULTATO NON HA VINTO NESSUNO");
    }
}

public class Tabelline
{
    public static void Crea()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("INSERISCI IL NUMERO IL QUALE VUOI FARE LA TABELLINA ---> ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.Write($"DA CHE NUMERO VUOI PARTIRE PER FARE LA TABELLINA DEL {numero} ---> ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write($"FINO A CHE NUMERO VUOI ARRIVARE PER FARE LA TABELLINA DEL {numero} ---> ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine($"------------ LA TABELLINA DEL {numero} E' ------------");
        Console.WriteLine("");


        if (end > start)
        {
            for (int i = start; i <= end; i++)
                Console.WriteLine($"{numero} * {i} = {numero * i}");

        }
        else
        {
            for (int i = end; i <= start; i++)
                Console.WriteLine($"{numero} * {i} = {numero * i}");
        }

    }
}

public class Babilonia
{
    public static double Inserisci_numero()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("INSERISCI NUMERO PER CALCOLARE LA RADICE ---> ");
        double numero = Convert.ToInt32(Console.ReadLine());

        return numero;
    }

    public static double Inserisci_errore()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("INSERISCI LA PRECISIONE DELL' ERRORE OVVVERO QUANTE CIFRE DOPO LA VIRGOLA ---> ");
        double epsilon = Convert.ToDouble(Console.ReadLine());

        return epsilon;
    }

    public static void Visualizza(double numero, double epsilon)
    {
        int passaggio = 0;
        double X0 = 1, errore = 0;

        X0 = Math.Pow(10, epsilon);
        errore = Math.Abs((X0 * X0) - numero);

        while (errore >= epsilon)
        {
            errore = Math.Abs((X0 * X0) - numero);
            X0 = 1 / 2 * (X0 + (numero / X0));
            passaggio++;
        }

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine($"LA RADICE APPROSSIMATA DI {numero} E' ----> {X0}");
        Console.WriteLine($"ALGORITMO FATTO IN ---> {passaggio} PASSAGGI");
    }
}

public class Cesare
{
    public static string Inserisci_frase()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("INSERISCE FRASE DA CRIPTARE ---> ");
        string frase = Console.ReadLine();

        return frase;
    }

    public static string Cripta(string frase)
    {
        string nuova_frase = "";

        for (int j = 0; j <= frase.Length - 1; j++)
        {
            switch (frase[j])
            {
                case 'a':
                    nuova_frase += "d";
                    break;

                case 'b':
                    nuova_frase += "e";
                    break;

                case 'c':
                    nuova_frase += "f";
                    break;

                case 'd':
                    nuova_frase += "g";
                    break;

                case 'e':
                    nuova_frase += "h";
                    break;

                case 'f':
                    nuova_frase += "i";
                    break;

                case 'g':
                    nuova_frase += "j";
                    break;

                case 'h':
                    nuova_frase += "k";
                    break;

                case 'i':
                    nuova_frase += "l";
                    break;

                case 'j':
                    nuova_frase += "m";
                    break;

                case 'k':
                    nuova_frase += "n";
                    break;

                case 'l':
                    nuova_frase += "o";
                    break;

                case 'm':
                    nuova_frase += "p";
                    break;

                case 'n':
                    nuova_frase += "q";
                    break;
                case 'o':
                    nuova_frase += "r";
                    break;
                case 'p':
                    nuova_frase += "s";
                    break;
                case 'q':
                    nuova_frase += "t";
                    break;
                case 'r':
                    nuova_frase += "u";
                    break;
                case 's':
                    nuova_frase += "v";
                    break;
                case 't':
                    nuova_frase += "w";
                    break;
                case 'u':
                    nuova_frase += "x";
                    break;
                case 'v':
                    nuova_frase += "y";
                    break;
                case 'w':
                    nuova_frase += "z";
                    break;
                case 'x':
                    nuova_frase += "a";
                    break;
                case 'y':
                    nuova_frase += "b";
                    break;
                case 'z':
                    nuova_frase += "c";
                    break;

                default:
                    nuova_frase += frase[j];
                    break;
            }
        }
        return nuova_frase;
    }

    public static string Decripta(string encripted)
    {
        string nuova_frase = "";

        for (int j = 0; j <= encripted.Length - 1; j++)
        {
            switch (encripted[j])
            {
                case 'a':
                    nuova_frase += "x";
                    break;

                case 'b':
                    nuova_frase += "y";
                    break;

                case 'c':
                    nuova_frase += "z";
                    break;

                case 'd':
                    nuova_frase += "a";
                    break;

                case 'e':
                    nuova_frase += "b";
                    break;

                case 'f':
                    nuova_frase += "c";
                    break;

                case 'g':
                    nuova_frase += "d";
                    break;

                case 'h':
                    nuova_frase += "e";
                    break;

                case 'i':
                    nuova_frase += "f";
                    break;

                case 'j':
                    nuova_frase += "g";
                    break;

                case 'k':
                    nuova_frase += "h";
                    break;

                case 'l':
                    nuova_frase += "i";
                    break;

                case 'm':
                    nuova_frase += "j";
                    break;

                case 'n':
                    nuova_frase += "k";
                    break;
                case 'o':
                    nuova_frase += "l";
                    break;
                case 'p':
                    nuova_frase += "m";
                    break;
                case 'q':
                    nuova_frase += "n";
                    break;
                case 'r':
                    nuova_frase += "o";
                    break;
                case 's':
                    nuova_frase += "p";
                    break;
                case 't':
                    nuova_frase += "q";
                    break;
                case 'u':
                    nuova_frase += "r";
                    break;
                case 'v':
                    nuova_frase += "s";
                    break;
                case 'w':
                    nuova_frase += "t";
                    break;
                case 'x':
                    nuova_frase += "u";
                    break;
                case 'y':
                    nuova_frase += "v";
                    break;
                case 'z':
                    nuova_frase += "x";
                    break;

                default:
                    nuova_frase += encripted[j];
                    break;
            }
        }

        return nuova_frase;
    }
}

public class Cripto
{
    public static string Inserisci_frase()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("INSERISCE FRASE DA CRIPTARE ---> ");
        string frase = Console.ReadLine();

        return frase;
    }

    public static string Cripta(string frase)
    {
        string nuova_frase = "";

        for (int j = 0; j <= frase.Length - 1; j++)
        {
            switch (frase[j])
            {
                case 'a':
                    nuova_frase += "z";
                    break;

                case 'b':
                    nuova_frase += "y";
                    break;

                case 'c':
                    nuova_frase += "x";
                    break;

                case 'd':
                    nuova_frase += "w";
                    break;

                case 'e':
                    nuova_frase += "v";
                    break;

                case 'f':
                    nuova_frase += "u";
                    break;

                case 'g':
                    nuova_frase += "t";
                    break;

                case 'h':
                    nuova_frase += "s";
                    break;

                case 'i':
                    nuova_frase += "r";
                    break;

                case 'j':
                    nuova_frase += "q";
                    break;

                case 'k':
                    nuova_frase += "p";
                    break;

                case 'l':
                    nuova_frase += "o";
                    break;

                case 'm':
                    nuova_frase += "n";
                    break;

                case 'n':
                    nuova_frase += "m";
                    break;
                case 'o':
                    nuova_frase += "l";
                    break;
                case 'p':
                    nuova_frase += "k";
                    break;
                case 'q':
                    nuova_frase += "j";
                    break;
                case 'r':
                    nuova_frase += "i";
                    break;
                case 's':
                    nuova_frase += "h";
                    break;
                case 't':
                    nuova_frase += "g";
                    break;
                case 'u':
                    nuova_frase += "f";
                    break;
                case 'v':
                    nuova_frase += "e";
                    break;
                case 'w':
                    nuova_frase += "d";
                    break;
                case 'x':
                    nuova_frase += "c";
                    break;
                case 'y':
                    nuova_frase += "b";
                    break;
                case 'z':
                    nuova_frase += "a";
                    break;

                default:
                    nuova_frase += frase[j];
                    break;
            }
        }
        return nuova_frase;
    }

    public static string Decripta(string encripted)
    {
        string nuova_frase = "";

        for (int j = 0; j <= encripted.Length - 1; j++)
        {
            switch (encripted[j])
            {
                case 'a':
                    nuova_frase += "z";
                    break;

                case 'b':
                    nuova_frase += "y";
                    break;

                case 'c':
                    nuova_frase += "x";
                    break;

                case 'd':
                    nuova_frase += "w";
                    break;

                case 'e':
                    nuova_frase += "v";
                    break;

                case 'f':
                    nuova_frase += "u";
                    break;

                case 'g':
                    nuova_frase += "t";
                    break;

                case 'h':
                    nuova_frase += "s";
                    break;

                case 'i':
                    nuova_frase += "r";
                    break;

                case 'j':
                    nuova_frase += "q";
                    break;

                case 'k':
                    nuova_frase += "p";
                    break;

                case 'l':
                    nuova_frase += "o";
                    break;

                case 'm':
                    nuova_frase += "n";
                    break;

                case 'n':
                    nuova_frase += "m";
                    break;
                case 'o':
                    nuova_frase += "l";
                    break;
                case 'p':
                    nuova_frase += "k";
                    break;
                case 'q':
                    nuova_frase += "j";
                    break;
                case 'r':
                    nuova_frase += "i";
                    break;
                case 's':
                    nuova_frase += "h";
                    break;
                case 't':
                    nuova_frase += "g";
                    break;
                case 'u':
                    nuova_frase += "f";
                    break;
                case 'v':
                    nuova_frase += "e";
                    break;
                case 'w':
                    nuova_frase += "d";
                    break;
                case 'x':
                    nuova_frase += "c";
                    break;
                case 'y':
                    nuova_frase += "b";
                    break;
                case 'z':
                    nuova_frase += "a";
                    break;

                default:
                    nuova_frase += encripted[j];
                    break;
            }
        }
        return nuova_frase;
    }
}

public class TiroConArco
{
    public static int Ntiri(string[] nomiTiroConArco, double[] punteggiTiroConArco, int posizione)
    {
        double x = 0, y = 0, totale = 0;
        int lanci = 0, sommat = 0;

        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.Write("INSERISCI QUANTE GARE VUOI FARE ---> ");
        int numero_gare = Convert.ToInt32(Console.ReadLine());

        for (int i = 1, j = 1; i <= numero_gare; i++, j++)
        {
            Console.WriteLine("");
            Console.Write($"INSERISCI QUANTI LANCI VUOI FARE PER IL {i} TENTATIVO ---> ");
            lanci = Convert.ToInt16(Console.ReadLine());

            if (lanci > sommat)
                sommat = lanci;

            Console.WriteLine("");

            if (i >= 10)
                totale = Precisione(x, y, totale, lanci, j); // richiamo il metodo tira 
            else
                totale = Tira(x, y, totale, lanci, j); // richiamo il metodo tira 

            Console.Write("PREMI UN TASTO PER CONTINUARE ---> ");
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"IL PUNTEGGIO MASSIMO E' ---> {totale} SU {sommat} LANCI CON UN MASSIMO POSSIBILE DI {10 * sommat}");
        Console.WriteLine("");


        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write($"VUOI INSERIRE IL PUNTEGGIO MIGLORE {totale} IN UN UTENTE SCRIVI SI ---> ");
        string scelta_utente = Console.ReadLine();


        if (scelta_utente == "SI")
        {
            for (int i = posizione + 1; i <= posizione + 1; i++)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("SCEGLI IL NOME DELL'UTENTE ---> ");
                nomiTiroConArco[i] = Console.ReadLine();
                punteggiTiroConArco[i] = totale;
            }
            posizione++;
        }

        return posizione;
    }

    public static int VentiTiri(string[] nomiTiroConArco, double[] punteggiTiroConArco, int posizione)
    {
        double x = 0, y = 0, totale = 0;
        int lanci = 0, sommat = 0;

        Console.ForegroundColor = ConsoleColor.DarkCyan;

        int numero_gare = 20;

        for (int i = 1, j = 1; i <= numero_gare; i++, j++)
        {
            Console.WriteLine("");
            Console.Write($"INSERISCI QUANTI LANCI VUOI FARE PER IL {i} TTENTATIVO ---> ");
            lanci = Convert.ToInt16(Console.ReadLine());

            if (lanci > sommat)
                sommat = lanci;

            Console.WriteLine("");

            if (i >= 10)
                totale = Precisione(x, y, totale, lanci, j); // richiamo il metodo tira 
            else
                totale = Tira(x, y, totale, lanci, j); // richiamo il metodo tira 

            Console.Write("PREMI UN TASTO PER CONTINUARE ---> ");
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"IL PUNTEGGIO MASSIMO E' ---> {totale} SU {sommat} LANCI CON UN MASSIMO POSSIBILE DI {10 * sommat}");
        Console.WriteLine("");

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write($"VUOI INSERIRE IL PUNTEGGIO MIGLORE {totale} IN UN UTENTE SCRIVI SI ---> ");
        string scelta_utente = Console.ReadLine();

        if (scelta_utente == "SI")
        {
            for (int i = posizione + 1; i <= posizione + 1; i++)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("SCEGLI IL NOME DELL'UTENTE ---> ");
                nomiTiroConArco[i] = Console.ReadLine();
                punteggiTiroConArco[i] = totale;
            }
            posizione++;
        }

        return posizione;
    }

    public static void Visualizza(string[] nomiTiroConArco, double[] punteggiTiroConArco, int posizione)
    {
        double pmiglore = 0;
        string nmiglore = "";

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine("---------------------------------------------- I GIOCATORI SONO I SEGUENTI CON IL SEGUENTE PUNTEGGIO ----------------------------------------------");
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        for (int i = 1; i <= posizione; i++)
        {
            Console.WriteLine($"IL {i} GIOCATORE SI CHAMA {nomiTiroConArco[i]} E HA TOTALIZZATO ---> {punteggiTiroConArco[i]} PUNTI");

            if (punteggiTiroConArco[i] >= pmiglore)
            {
                pmiglore = punteggiTiroConArco[i];
                nmiglore = nomiTiroConArco[i];
            }
        }

        if (posizione > 0)
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"IL MIGLORE E' {nmiglore} CON ---> {pmiglore} PUNTI");
        }
    }

    private static double Tira(double x, double y, double totale, int lanci, int j) //funzione tira 
    {
        double impatto = 0, punteggio = 0, punteggio_tot = 0;
        Random generatore = new Random(); // vreazione metodo casuale generatore 

        Console.ForegroundColor = ConsoleColor.White;

        for (int i = 1; i <= lanci; i++)      //indica di fare 3 volte i lanci 
        {
            punteggio = 0;

            x = generatore.NextDouble(); //genera casualmente numero tra 0 e 1 assegno ad x 
            x = x * 40;                  // moltiplico numero per 40 assegno ad x

            y = generatore.NextDouble();  //genera casualmente numero tra 0 e 1 assegno ad x 
            y = y * 40;                   // moltiplico numero per 40 assegno ad x

            impatto = (x * x) + (y * y);   //faccio diventare radice quadrata moltiplico x e y 
            impatto = Math.Sqrt(impatto); // faccio la radice quadrata della variabile radice quadrata 


            Console.WriteLine("");
            Console.WriteLine($"{i} TENTATIVO NUMERO ---> {impatto}");


            if (impatto >= 30)  //se distanza maggiore di 30
            {
                punteggio += 0; //sommo punteggio
                punteggio_tot += 0;
                Console.WriteLine("SEI FUORI PUNTEGGIO");
            }
            else
            {
                if (impatto >= 20) // se distanza maggiore di 20
                {
                    punteggio += 1; //sommo punteggio
                    punteggio_tot += 1;
                    Console.WriteLine($"HAI OTTENUTO {punteggio} punti");
                }
                else
                {
                    if (impatto >= 10)   // se distanza maggiore di 10
                    {
                        punteggio += 5;  //sommo punteggio
                        punteggio_tot += 5;
                        Console.WriteLine($"HAI OTTENUTO {punteggio} punti");
                    }
                    else
                    {
                        if (impatto >= 0)
                        {
                            punteggio += 10;   //sommo punteggio
                            punteggio_tot += 10;
                            Console.WriteLine($"HAI OTTENUTO {punteggio} punti");
                        }
                    }
                }

                if (punteggio_tot > totale) //se punteggioe è maggiore di tptale sostituiscilo
                    totale = punteggio_tot;
            }

        }

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("");
        Console.WriteLine($"LA SOMMA DEI PUNTEGGI DEL {j} TENTATIVO E' ---> {punteggio_tot} / {10 * lanci}");
        Console.WriteLine("");

        return totale; // ritorna totale 
    }


    private static double Precisione(double x, double y, double totale, int lanci, int j) //funzione tira 
    {
        double impatto = 0, punteggio = 0, punteggio_tot = 0;
        Random generatore = new Random(); // vreazione metodo casuale generatore 

        Console.ForegroundColor = ConsoleColor.White;

        for (int i = 1; i <= lanci; i++)      //indica di fare 3 volte i lanci 
        {
            punteggio = 0;

            x = generatore.NextDouble(); //genera casualmente numero tra 0 e 1 assegno ad x 
            x = x * 35;                  // moltiplico numero per 40 assegno ad x

            y = generatore.NextDouble();  //genera casualmente numero tra 0 e 1 assegno ad x 
            y = y * 35;                   // moltiplico numero per 40 assegno ad x

            impatto = (x * x) + (y * y);   //faccio diventare radice quadrata moltiplico x e y 
            impatto = Math.Sqrt(impatto); // faccio la radice quadrata della variabile radice quadrata 


            Console.WriteLine("");
            Console.WriteLine($"{i} TENTATIVO NUMERO ---> {impatto}");


            if (impatto >= 30)  //se distanza maggiore di 30
            {
                punteggio += 0; //sommo punteggio
                punteggio_tot += 0;
                Console.WriteLine("SEI FUORI PUNTEGGIO");
            }
            else
            {
                if (impatto >= 20) // se distanza maggiore di 20
                {
                    punteggio += 1; //sommo punteggio
                    punteggio_tot += 1;
                    Console.WriteLine($"HAI OTTENUTO {punteggio} punti");
                }
                else
                {
                    if (impatto >= 10)   // se distanza maggiore di 10
                    {
                        punteggio += 5;  //sommo punteggio
                        punteggio_tot += 5;
                        Console.WriteLine($"HAI OTTENUTO {punteggio} punti");
                    }
                    else
                    {
                        if (impatto >= 0)
                        {
                            punteggio += 10;   //sommo punteggio
                            punteggio_tot += 10;
                            Console.WriteLine($"HAI OTTENUTO {punteggio} punti");
                        }
                    }
                }

                if (punteggio_tot > totale) //se punteggioe è maggiore di tptale sostituiscilo
                    totale = punteggio_tot;
            }

        }

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("");
        Console.WriteLine($"LA SOMMA DEI PUNTEGGI DEL {j} TENTATIVO E' ---> {punteggio_tot} / {10 * lanci}");
        Console.WriteLine("");

        return totale; // ritorna totale 
    }

    public static void ContollaUtente(string[] nomiTiroConArco, double[] punteggiTiroConArco, int posizione)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        int conta = 0;
        double migloreu = 0, miglore = 0;

        Console.Write("INSERISCI IL NOME DELL'UTENTE CHE VUOI VEDERE QUANTI PUNTI HA ---> ");
        string nome_da_controllare = Console.ReadLine();

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkCyan;

        for (int i = 1; i <= posizione; i++)
        {
            if (nome_da_controllare == nomiTiroConArco[i])
            {
                Console.WriteLine($"IL PUNTEGGIO DI {nome_da_controllare} E' ---> {punteggiTiroConArco[i]}");
                conta++;

                migloreu = punteggiTiroConArco[i];
            }

            if (punteggiTiroConArco[i] > miglore)
                miglore = punteggiTiroConArco[i];
        }

        if (conta <= 0)
        {
            Console.WriteLine("NON ESISTE L'UTENTE --> " + nome_da_controllare);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("");
            Console.WriteLine("---------- GLI UTENTI SONO I SEGUENTI ----------");
            Console.WriteLine("");

            for (int i = 1; i <= posizione; i++)
                Console.WriteLine($"{i} UTENTE NOME {nomiTiroConArco[i]} --> PUNTEGGIO {punteggiTiroConArco[i]}");
        }
        else
        {
            Console.WriteLine("");

            if (migloreu >= miglore)
                Console.WriteLine($"L'UTENTE {nome_da_controllare} HA IL PUNTEGGIO MIGLORE");
            else
                Console.WriteLine($"L'UTENTE {nome_da_controllare} NON HA IL PUNTEGGIO MIGLORE");
        }
    }

    public static int AzzeraVettore(int posizione)
    {
        posizione = 0;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("VETTORE AZZERATO");

        return posizione;
    }
}

public class CriptoChiave
{
    public static string InserisciTesto()
    {
        Console.Write("INSERISCI LA FRASE DA CRIPTARE ---> ");
        string originale = Console.ReadLine();
        Console.WriteLine("");

        return originale;
    }

    public static int InserisciChiave()
    {
        int chiave;
        do
        {
            Console.Write("INSERISCI LA CHIAVE OVVERO DI QUANTE LETTERE VUOI CRIPTARE IL MESSAGGIO TRA NUMERI MAGGIORI O UGUALI A 0  ---> ");
            chiave = Convert.ToInt32(Console.ReadLine());
        }
        while (chiave < 0);

        while (chiave > 25)
            chiave -= 26;

        return chiave;
    }

    public static string Cripta(string testo, string alfabeto, int chiave)
    {
        string criptato = "";
        int posizione = 0;

        for (int i = 0; i <= testo.Length - 1; i++)
        {
            posizione = 0;

            switch (testo[i])
            {
                case 'a':
                    posizione += 0;
                    break;
                case 'b':
                    posizione += 1;
                    break;
                case 'c':
                    posizione += 2;
                    break;
                case 'd':
                    posizione += 3;
                    break;
                case 'e':
                    posizione += 4;
                    break;
                case 'f':
                    posizione += 5;
                    break;
                case 'g':
                    posizione += 6;
                    break;
                case 'h':
                    posizione += 7;
                    break;
                case 'i':
                    posizione += 8;
                    break;
                case 'j':
                    posizione += 9;
                    break;
                case 'k':
                    posizione += 10;
                    break;
                case 'l':
                    posizione += 11;
                    break;
                case 'm':
                    posizione += 12;
                    break;
                case 'n':
                    posizione += 13;
                    break;
                case 'o':
                    posizione += 14;
                    break;
                case 'p':
                    posizione += 15;
                    break;
                case 'q':
                    posizione += 16;
                    break;
                case 'r':
                    posizione += 17;
                    break;
                case 's':
                    posizione += 18;
                    break;
                case 't':
                    posizione += 19;
                    break;
                case 'u':
                    posizione += 20;
                    break;
                case 'v':
                    posizione += 21;
                    break;
                case 'w':
                    posizione += 22;
                    break;
                case 'x':
                    posizione += 23;
                    break;
                case 'y':
                    posizione += 24;
                    break;
                case 'z':
                    posizione += 25;
                    break;

                default:
                    posizione += -1;
                    break;
            }


            if (posizione >= 0)
            {
                if (posizione + chiave <= 25)
                {
                    criptato += alfabeto[posizione + chiave];
                }
                else
                {
                    criptato += alfabeto[posizione + chiave - 26];
                }
            }
            else
            {
                criptato += testo[i];
            }
        }

        return criptato;
    }

    public static string Decripta(string testo, string alfabeto, int chiave)
    {
        string criptato = "";
        int posizione = 0;

        for (int i = 0; i <= testo.Length - 1; i++)
        {
            posizione = 0;

            switch (testo[i])
            {
                case 'a':
                    posizione += 0;
                    break;
                case 'b':
                    posizione += 1;
                    break;
                case 'c':
                    posizione += 2;
                    break;
                case 'd':
                    posizione += 3;
                    break;
                case 'e':
                    posizione += 4;
                    break;
                case 'f':
                    posizione += 5;
                    break;
                case 'g':
                    posizione += 6;
                    break;
                case 'h':
                    posizione += 7;
                    break;
                case 'i':
                    posizione += 8;
                    break;
                case 'j':
                    posizione += 9;
                    break;
                case 'k':
                    posizione += 10;
                    break;
                case 'l':
                    posizione += 11;
                    break;
                case 'm':
                    posizione += 12;
                    break;
                case 'n':
                    posizione += 13;
                    break;
                case 'o':
                    posizione += 14;
                    break;
                case 'p':
                    posizione += 15;
                    break;
                case 'q':
                    posizione += 16;
                    break;
                case 'r':
                    posizione += 17;
                    break;
                case 's':
                    posizione += 18;
                    break;
                case 't':
                    posizione += 19;
                    break;
                case 'u':
                    posizione += 20;
                    break;
                case 'v':
                    posizione += 21;
                    break;
                case 'w':
                    posizione += 22;
                    break;
                case 'x':
                    posizione += 23;
                    break;
                case 'y':
                    posizione += 24;
                    break;
                case 'z':
                    posizione += 25;
                    break;

                default:
                    posizione += -1;
                    break;
            }


            if (posizione >= 0)
            {
                if (posizione - chiave >= 0)
                {
                    criptato += alfabeto[posizione - chiave];
                }
                else
                {
                    criptato += alfabeto[posizione - chiave + 26];
                }
            }
            else
            {
                criptato += testo[i];
            }
        }
        return criptato;
    }
}
internal class StampaPassSuText
{
    string pass;

    public StampaPassSuText(string password)
    {
        pass = password;
    }

    public void Scrivi(string testo)
    {
        File.AppendAllText(pass, testo + "\n");
    }

    public void Cancella(string testo)
    {
        File.Delete(testo);
    }
}