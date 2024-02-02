namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Licz liczba = new Licz(7);

            liczba.Wypisz();

            liczba.Dodaj(6);
            liczba.Wypisz();

            liczba.Odejmij(14);
            liczba.Wypisz();
        }
    }
}
