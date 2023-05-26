public class CriptoChiave
{
    public static string InserisciTesto()
    {
        Console.Write("INSERISCI LA FRASE DA CRIPTARE ---> ");
        string originale = Console.ReadLine();

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