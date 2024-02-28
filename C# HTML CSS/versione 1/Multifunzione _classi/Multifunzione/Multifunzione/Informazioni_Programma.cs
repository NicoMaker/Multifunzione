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
        Console.WriteLine("9. VISUALIZZA LA PASSWORD DELL'UTENTE SE NON ESISTE DI NON ESISTE");
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