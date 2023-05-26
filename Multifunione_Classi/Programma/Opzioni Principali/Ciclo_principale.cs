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
                    Console.Clear();
                    moneta = Moneta.Iserisci();
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("il numero delle monete è ---> " + moneta);
                    Console.WriteLine("");
                    break;

                case 2:
                    Console.Clear();
                    Moneta.Visualizza(moneta);
                    break;

                case 3:
                    Console.Clear();
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
                    Console.Clear();
                    numerop = Password.InserisciNumeroPassword(utenti);
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("password da generare --> " + numerop);
                    Console.WriteLine("");
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("");
                    Password.Crea(numerop, utenti, password);
                    Console.WriteLine("");
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("");
                    Password.Visualizza(numerop, utenti, password);
                    Console.WriteLine("");
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine("");
                    numerop = Password.InserisciALtriUtenti(numerop, utenti, password);
                    Console.WriteLine("");
                    break;

                case 8:
                    Console.Clear();
                    Console.WriteLine("");
                    Password.ControllaPassword(numerop, utenti, password);
                    Console.WriteLine("");
                    break;

                case 9:
                    Console.Clear();
                    Console.WriteLine("");
                    Password.ControllaNomeUtente(numerop, utenti, password);
                    Console.WriteLine("");
                    break;

                case 10:
                    Console.Clear();
                    Console.WriteLine("");
                    lettere = Lettere.Inserisci();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("");
                    Console.WriteLine("il numero di lettere da generare  è ----> " + lettere);
                    Console.WriteLine("");
                    break;

                case 11:
                    Console.Clear();
                    Console.WriteLine("");
                    Lettere.Visualizza(lettere);
                    break;

                case 12:
                    Console.Clear();
                    Console.WriteLine("");
                    dadi = Dadi.Inserisci();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("");
                    Console.WriteLine("il numero di dadi da lanciare  è ----> " + dadi);
                    Console.WriteLine("");
                    break;

                case 13:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    Console.WriteLine("il numero di dadi lanciati è ----> " + dadi);
                    Console.WriteLine("");
                    numero = Dadi.Visualizza(dadi);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"il numero genrato dal lancio di {dadi} dadi è ----> " + numero);
                    Console.WriteLine("");
                    break;

                case 14:
                    Console.Clear();
                    Console.WriteLine("");
                    Pasqua.Crea();
                    Console.WriteLine("");
                    break;

                case 15:
                    Console.Clear();
                    Console.WriteLine("");
                    int collatz = Collatz.Inserisci();
                    Collatz.Visualizza(collatz);
                    Console.WriteLine("");
                    break;

                case 16:
                    Console.Clear();
                    Console.WriteLine("");
                    int fact = Fact.Inserisci();
                    Fact.Crea(fact);
                    Console.WriteLine("");
                    break;

                case 17:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    int numero1E = Euclide.Inserisci1();
                    int numero2E = Euclide.Inserisci2();
                    Euclide.Visualizza(numero1E, numero2E);
                    Console.WriteLine("");
                    break;

                case 18:
                    Console.Clear();
                    Console.WriteLine("");
                    numeri = Numeri_Complessi.InserisciNumeri(Parte_reale, Parte_immaginaria);
                    Console.WriteLine("");
                    break;

                case 19:
                    Console.Clear();
                    Console.WriteLine("");
                    Numeri_Complessi.Visualizza(numeri, Parte_reale, Parte_immaginaria);
                    Console.WriteLine("");
                    break;

                case 20:
                    Console.Clear();
                    Console.WriteLine("");
                    Numeri_Complessi.Somma(numeri, Parte_reale, Parte_immaginaria);
                    Console.WriteLine("");
                    break;

                case 21:
                    Console.Clear();
                    Console.WriteLine("");
                    Numeri_Complessi.Sottrazione(numeri, Parte_reale, Parte_immaginaria);
                    Console.WriteLine("");
                    break;

                case 22:
                    Console.Clear();
                    Console.WriteLine("");
                    int numeropr = Numeri_Primi.Inserisci();
                    Numeri_Primi.Visualizza(numeropr, Numeripr);
                    Console.WriteLine("");
                    break;

                case 23:
                    Console.Clear();
                    Console.WriteLine("");
                    Polinomi.Visualizza();
                    Console.WriteLine("");
                    break;

                case 24:
                    Matematica.Scelta();
                    Console.WriteLine("");
                    break;

                case 25:
                    Console.Clear();
                    Console.WriteLine("");
                    Sasso_Carta_forbice.Gioco();
                    Console.WriteLine("");
                    break;

                case 26:
                    Console.Clear();
                    Console.WriteLine("");
                    Tabelline.Crea();
                    Console.WriteLine("");
                    break;

                case 27:
                    Console.Clear();
                    Console.WriteLine("");
                    double numeroB = Babilonia.Inserisci_numero();
                    double epsion = Babilonia.Inserisci_errore();
                    Babilonia.Visualizza(numeroB, epsion);
                    Console.WriteLine("");
                    break;

                case 28:
                    Console.Clear();
                    Console.WriteLine("");
                    string frase = Cesare.Inserisci_frase();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("");
                    string encripted = Cesare.Cripta(frase);
                    Console.WriteLine($"il messaggio {frase} è stato criptato con ---> {encripted}");

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("VUOI VEDERE LA DECRIPTAZIONE ? scrivi SI ---> ");
                    string Visualizza = Console.ReadLine();
                    Visualizza = Visualizza.ToLower();
                    Console.WriteLine("");

                    if (Visualizza == "si")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        string decripted = Cesare.Decripta(encripted);
                        Console.WriteLine($"il messaggio {encripted} è stato decriptato con ---> {decripted}");
                    }
                    break;

                case 29:
                    Console.Clear();
                    Console.WriteLine("");
                    string frasecripto = Cripto.Inserisci_frase();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("");
                    string encriptedcripto = Cripto.Cripta(frasecripto);
                    Console.WriteLine($"il messaggio {frasecripto} è stato criptato con ---> {encriptedcripto}");

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("VUOI VEDERE LA DECRIPTAZIONE ? scrivi SI ---> ");
                    string Visualizzacripto = Console.ReadLine();
                    Visualizzacripto = Visualizzacripto.ToLower();
                    Console.WriteLine("");

                    if (Visualizzacripto == "si")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        string decriptedcripto = Cripto.Decripta(encriptedcripto);
                        Console.WriteLine($"il messaggio {encriptedcripto} è stato decriptato con ---> {decriptedcripto}");
                    }
                    break;

                case 30:
                    Console.Clear();
                    Console.WriteLine("");
                    posizione = TiroConArco.Ntiri(nomiTiroConArco, punteggiTiroConArco, posizione);
                    break;

                case 31:
                    Console.Clear();
                    Console.WriteLine("");
                    posizione = TiroConArco.VentiTiri(nomiTiroConArco, punteggiTiroConArco, posizione);
                    break;

                case 32:
                    Console.Clear();
                    Console.WriteLine("");
                    TiroConArco.Visualizza(nomiTiroConArco, punteggiTiroConArco, posizione);
                    break;

                case 33:
                    Console.Clear();
                    Console.WriteLine("");
                    TiroConArco.ContollaUtente(nomiTiroConArco, punteggiTiroConArco, posizione);
                    break;

                case 34:
                    Console.Clear();
                    Console.WriteLine("");
                    posizione = TiroConArco.AzzeraVettore(posizione);
                    break;

                case 35:
                    Console.Clear();
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
                    Console.Write("VUOI VEDERE LA DECRIPTAZIONE ? scrivi SI ---> ");
                    string Sicripto = Console.ReadLine();
                    Sicripto = Sicripto.ToLower();
                    Console.WriteLine("");

                    if (Sicripto == "si")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        string decriptato = CriptoChiave.Decripta(criptato, alfabeto, chiave);
                        Console.WriteLine($"il messaggio {criptato} è stato decriptato con ---> {decriptato}");
                    }
                    Console.WriteLine("");

                    break;

                case 36:
                    Console.Clear();
                    Console.WriteLine("");
                    char inserisci;
                   
                    Console.ForegroundColor= ConsoleColor.DarkYellow;

                    do
                    {
                        Console.Write("inserisci se vuoi segni zodiacali casuali o normali (c o n) ? ---> ");
                        inserisci = Convert.ToChar(Console.ReadLine());

                    }while (inserisci != 'n' && inserisci != 'c');

                    Console.WriteLine("");

                    if (inserisci == 'c')
                        Zoddiacale_Casuale.Inserisci();
                    else
                        Zodiacale.Inserisci();

                    break;

                case 37:
                    Console.Clear();
                    Console.WriteLine("");
                    Partita.Inserisci();
                    break;

                case 38:
                    Console.Clear();
                    Console.WriteLine("");
                    NumeriSenzaRipetizione.Visualizza();
                    break;

                case 39:
                    Console.Clear();
                    Console.WriteLine("");

                    string inseriscit;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    do
                    {
                        Console.Write("inserisci se vuoi tombola tabellone ordinato o casuale (tab o cas) ? ---> ");
                        inseriscit = Console.ReadLine() ;
                        inseriscit = inseriscit.ToLower();

                    } while (inseriscit != "tab" && inseriscit != "cas");

                    Console.WriteLine("");

                    if (inseriscit == "tab")
                        GiocoTombolaOrdinata.Inserisci();
                    else
                        GiocoTombola.Inserisci();

                    Console.Clear();
                    Console.WriteLine();
                    break;

                case 40:
                    Console.Clear();
                    Console.WriteLine("");

                    string sceltanumeri;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    do
                    {
                        Console.Write("inserisci se vuoi numeri senza ripetizione ordinati o casuali (ord o cas) ? ---> ");
                        sceltanumeri= Console.ReadLine();
                        sceltanumeri = sceltanumeri.ToLower();

                    } while (sceltanumeri != "ord" && sceltanumeri != "cas");

                    Console.WriteLine("");

                    if (sceltanumeri == "ord")
                        GicoNumeriSenzaRipetizioneordinato.Inserisci();
                    else
                        GiocoNumeriSenzaRipetizione.Inserisci();

                    Console.Clear();
                    Console.WriteLine();
                    break;

                case 41:
                    Console.Clear();
                    Console.WriteLine("");
                    Numeri_Casuali.Numeri_Random();
                    break;

                case 42:
                    Console.Clear();
                    Console.WriteLine("");
                    Golf.Inserisci();
                    break;

                case 43:
                    Console.Clear();
                    Console.WriteLine("");
                    NomiSenzaRipezione.Visualizza();
                    break;

                default:

                    Console.Clear();
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

        } while (s != 0 && s <= 43);
    }
}