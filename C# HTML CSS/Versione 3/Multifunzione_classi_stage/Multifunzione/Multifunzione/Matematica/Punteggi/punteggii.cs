public class punteggi
{
    public static int inserisci(string []utenti, int numeroutenti)
    {
        Console.WriteLine("quuanti utenti vuoi inserire ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int totale = numero + numeroutenti;

        for (int i = numeroutenti; i < totale; i++)
        {
            Console.Write("inserisci il nome dell'utente ");
            utenti[i] = Console.ReadLine();
        }

        return totale;
    }

    public static void visualizza(string[] utenti, List<int> punti, int numeroutenti)
    {
        for (int i = 0; i < numeroutenti; i++)
        {
            punti.Add(0);

            Console.WriteLine(utenti[i] + " punti " + punti[i]);
        }
    }

    public static void agggiungipunti(string [] utenti, List<int> punti)
    {
        string nome;
        bool conta = false;

        do
        {
            Console.Write("inserisci il nome a cui aggiungere punti ");
            nome = Console.ReadLine();

            for (int i = 0; i < utenti.Length; i++)
                if (nome == utenti[i])
                    conta = true;

        } while (!conta);

        Console.Write("quanti punti vuoi aggiungere a " + nome + " ");
        int aggiungi = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < utenti.Length  - 1; i++)
            if (nome == utenti[i])
                punti[i] += aggiungi;

    }


    public static void toglipunti(string [] utenti, List<int> punti)
    {
        string nome;
        bool conta = false;

        do
        {
            Console.Write("inserisci il nome a cui togliere i punti ");
            nome = Console.ReadLine();

            for (int i = 0; i < utenti.Length - 1; i++)
                if (nome == utenti[i])
                    conta = true;

        } while (!conta);

        Console.Write("quanti punti vuoi togliere a " + nome + " ");
        int togli = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < utenti.Length; i++)
            if (nome == utenti[i])
                punti[i] -= togli;

    }

    public static void aggiungiatutti(string [] utenti, List<int> punti, int numeroutenti)
    {
        Console.Write("quanti punti vuoi aggiungere a tutti ");
        int aggiungi = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numeroutenti; i++)
            punti[i] += aggiungi;
    }

    public static void togliatutti(string [] utenti, List<int> punti, int numeroutenti)
    {
        Console.Write("quanti punti vuoi togliere a tutti ");
        int togli = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numeroutenti; i++)
            punti[i] -= togli;
    }


    public static void vincitore(string [] utenti, List<int> punti, int numeroutenti)
    {
        int max = int.MinValue;
        string vincitore = "nessun vincitore";

        for (int i = 0; i < numeroutenti; i++)
            if (punti[i] >= max)
            {
                max = punti[i];
                vincitore = utenti[i];
            }

        if (vincitore == "nessun vincitore")
            Console.WriteLine(vincitore);
        else
            Console.WriteLine("ha vinto " + vincitore + " con " + max + " punti");
    }

    public static void resetpunti(List<int> punti)
    {
        for (int i = 0; i < punti.Count; i++)
            punti[i] = 0;

        Console.WriteLine("rest punti");
    }

    public static int resetcompleto(string [] utenti)
    {
        int numeroutenti = 0;

        Console.WriteLine("reset completo");

        return numeroutenti;
    }
}