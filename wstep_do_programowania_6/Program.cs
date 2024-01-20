namespace wstep_do_programowania_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // jeżeli z metody statycznej odnosimy sie do innych pol / metod
            // to te metody i pola tez musza byc statyczne

            Console.WriteLine("Hello, World!");
            
            Cyfra.a = 10;
            

            // static sprawia, ze nie musimy tworzyc obiektu

            Console.WriteLine(Cyfra.a);
            Console.WriteLine(Utils.abs(-123));
        

            Cyfra c1 = new Cyfra();
            Cyfra c2 = new Cyfra();


            Node ciuchy = new Node();

            Node meskie= new Node();
            Node damskie = new Node();

            ciuchy.addChild(meskie);
            ciuchy.addChild(damskie);

            Console.WriteLine(ciuchy.childrenCount());
        
            Node buty = new Node();
            Node bluzy = new Node();

            meskie.addChild(buty);
            meskie.addChild(bluzy);

            Console.WriteLine(ciuchy.ancestorCount());
        }
    }
}