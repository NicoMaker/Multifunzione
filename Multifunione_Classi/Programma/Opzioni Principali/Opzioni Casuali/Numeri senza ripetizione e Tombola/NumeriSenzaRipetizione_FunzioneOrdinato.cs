﻿public class NumeriSenzaRipetizione_FunzioneOrdinato
{
    public static int Genera1Numero(int[] numeri, int numero_passaggio, int numero, int[] numeri_ordinati)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Random numberrandom = new Random();
        bool controllo = false;
        int conta = 0;
        int conta2 = numero_passaggio;

        if (numero_passaggio < numero - 1)
            numero_passaggio++;
        else
            conta2++;

        if (conta2 > numero - 1)
            Console.WriteLine($"non posso generare perchè ho già generato {numero} numeri");
        else
        {
            for (int i = numero_passaggio; i <= numero_passaggio; i++)
            {
                numeri[i] = numberrandom.Next(1, numero + 1);

                if (i > 0)
                {
                    do
                    {
                        controllo = false;

                        for (int j = 0; j < i; j++)
                        {
                            if (numeri[i] == numeri[j])
                            {
                                controllo = true;
                                numeri[i] = numberrandom.Next(1, numero + 1);
                            }
                            else
                                conta++;
                        }

                        if (conta == numero_passaggio)
                            controllo = true;

                    } while (controllo);

                }

                numeri_ordinati[numeri[i] - 1] = numeri[i];
            }

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            for (int i = numero_passaggio; i <= numero_passaggio; i++)
                Console.WriteLine($"{i + 1} Numero uscito è {numeri[i]}");
        }

        Console.ForegroundColor = ConsoleColor.White;

        return numero_passaggio;
    }

    public static void visualizza(int[] numeri, int numero_passaggio, int[] numeri_ordinati)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("NUMERI GENERATI");
        Console.WriteLine(" ");


        for (int i = 0; i < numeri_ordinati.Length; i++)
        {
            if (numeri_ordinati[i] != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(numeri_ordinati[i] + " ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(i + 1 + " ");
            }
        }

        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("");
    }

    public static void Controllo(int numero_passaggio, int[] numeri, int[] numeri_ordinati, int numero)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        int numero_controllo = 0;
        bool controllo_numero = false;


        if (numero_passaggio < 0)
            Console.WriteLine("non posso controllare alcun numero perchè non è stato genrato nessuno numero");
        else
        {
            do
            {
                Console.Write("inserire numero da controllare se uscito ---> ");
                numero_controllo = Convert.ToInt32(Console.ReadLine());

            } while (numero_controllo > numero || numero_controllo <= 0);

            Console.WriteLine(" ");


            for (int i = 0; i <= numero_passaggio; i++)
            {
                if (numero_controllo == numeri[i])
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"il numero {numero_controllo} è uscito");
                    Console.WriteLine(" ");
                    controllo_numero = true;
                }
            }

            if (!controllo_numero)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"il numero {numero_controllo} non è uscito");
                Console.WriteLine(" ");


                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("NUMERI USCITI");
                Console.WriteLine(" ");

                for (int i = 0; i < numeri_ordinati.Length; i++)
                {
                    if (numeri_ordinati[i] != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(numeri_ordinati[i] + " ");
                    }
                }

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
            }
        }
    }

    public static int AzzeraVettore(int numero_passaggio, int[] numeri_ordianti, int numero)
    {
        Console.ForegroundColor = ConsoleColor.White;
        numero_passaggio = -1;
        Console.WriteLine("vettore azzerato");

        for (int i = 0; i < numero; i++)
            numeri_ordianti[i] = 0;

        return numero_passaggio;
    }
}