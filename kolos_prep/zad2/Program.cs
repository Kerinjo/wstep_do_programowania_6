namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[] { 1, 2, 3, 4, 5, 6 };
            Sumator sumator = new Sumator(tab);

            int res1 = sumator.Suma();
            int res2 = sumator.SumaPodziel3();
            int res3 = sumator.IleElementow();

            Console.WriteLine($"Suma1: {res1}\tSuma2: {res2}");
            Console.WriteLine($"Dlugosc: {res3}");

            sumator.WypiszElementy();
            sumator.FinalBoss(1, 5);
            sumator.FinalBoss(2, 6);
        }
    }
}
