internal class Program
{
    static bool vn(int v)
    {
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

    private static void Main(string[] args)
    {

        int risultato = Somma(1, 50);

        Console.WriteLine("il risultato della somma dei numeri speciali ( divisibili per due e tre ) è " + risultato);

    }
}