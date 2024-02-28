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