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
        Console.WriteLine("0 e numeri maggiori di 43. USCITA");
        Console.WriteLine("");
        Console.WriteLine("<-------------------------------------------------------------------------------------------------------------------------------------------------------->");
        Console.WriteLine("");

        Console.Write("INSERISCI SCELTA  ---> ");
        s = Convert.ToInt32(Console.ReadLine());

        return s;
    }
}