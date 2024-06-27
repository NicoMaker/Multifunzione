public class Punteggiiniziali
{
    public static void Inserisci()
    {
        int s = 0, numeroutenti = 0;
        const int Vettore = 300000000;

        string[] utenti = new string[Vettore];

        List<int> punti = new List<int>();

        do
        {
            s = Menu();

            switch (s)
            {
                case 1:
                    numeroutenti = punteggi.inserisci(utenti, numeroutenti);
                    break;
                case 2:
                    punteggi.visualizza(utenti, punti, numeroutenti);
                    break;

                case 3:
                    punteggi.agggiungipunti(utenti, punti);
                    break;

                case 4:
                    punteggi.toglipunti(utenti, punti);
                    break;

                case 5:
                    punteggi.aggiungiatutti(utenti, punti, numeroutenti);
                    break;

                case 6:
                    punteggi.togliatutti(utenti, punti, numeroutenti);
                    break;

                case 7:
                    punteggi.vincitore(utenti, punti, numeroutenti);
                    break;

                case 8:
                    punteggi.resetpunti(punti);
                    break;

                case 9:
                    numeroutenti = punteggi.resetcompleto(utenti);
                    break;
            }

        } while (s != 0);


        int Menu()
        {
            Console.WriteLine("1. aggiungi utenti");
            Console.WriteLine("2. viuslizza");
            Console.WriteLine("3. aggiungi punti");
            Console.WriteLine("4. togli punti");
            Console.WriteLine("5. aggiungi a tutti");
            Console.WriteLine("6. togli a tutti");
            Console.WriteLine("7. vincitore");
            Console.WriteLine("8. reset punti");
            Console.WriteLine("9. reset giocatori e punti");
            Console.WriteLine("0. uscita");

            Console.Write("inserisci scelta ");
            int s = Convert.ToInt32(Console.ReadLine());

            return s;
        }
    }
}