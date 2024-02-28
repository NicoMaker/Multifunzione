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