internal class Program
{
    static bool vn(int v)
    {
        //FUNZIONI ESERCIZIO UNO
        if (v % 2 == 0)
        {

            if (v % 3 == 0)
            {
                return true;
            }

            return false;
        }
        return false;
    }
    static int Somma(int a, int b)
    {
        int S = 0;

        for (int i = a; i <= 50; i++)
        {

            bool verifica = vn(i);



            if (verifica == true)
            {

                S = S + i;

            }

        }
        return S;
    }

    //FUNZIONI ESERCIZIO 4

    //funzione controllo nome 
    static bool controllo(string a)
    {

        if (a == "Marco" || a == "Sara" || a == "Tommaso")
        {
           
            
                return true;
            
        }

        return false;
    }
    private static void Main(string[] args)
    {
        // MAIN ESERCIZIO 1
        
        int risultato = Somma(1, 50);

        Console.WriteLine("il risultato della somma dei numeri speciali ( divisibili per due e tre ) è " + risultato);
        
        //MAIN ESERCIZIO 4

        Console.WriteLine("dimmi il nome dell'utente");
       string n = Console.ReadLine();

        bool risultato1 = controllo(n);

       
        if (risultato1 == true)
        {
            
            Console.WriteLine("il nome " + risultato1+ "è autorizzato");

        }
        else {

            Console.WriteLine("nome utente sbagliato");

        }
    }
}