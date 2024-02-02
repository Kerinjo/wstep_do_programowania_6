using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Sumator
    {
        private int[] Liczby;

        public Sumator(int[] tab)
        {
            Liczby = tab;
        }

        public int Suma()
        {
            int sum = 0;
            foreach (var num in Liczby)
            {
                sum += num;
            }

            return sum;
        }

        public int SumaPodziel3()
        {
            int sum = 0;
            foreach (var num in Liczby)
            {
                if (num % 3 == 0)
                    sum += num;
            }

            return sum;
        }
        
        public int IleElementow() => Liczby.Length; 

        public void WypiszElementy()
        {
            string out_str = "[";

            foreach (var val in Liczby)
            {
                out_str += val.ToString();
                out_str += ", ";
            }

            out_str = out_str.Remove(out_str.Length - 2);

            out_str += "]";
            Console.WriteLine(out_str);
        }

        public void FinalBoss(int lowIndex, int highIndex)
        {
            if (lowIndex < 0)
                lowIndex = 0;
            if (highIndex > Liczby.Length - 1)
                highIndex = Liczby.Length - 1;

            string out_str = "[";
            for (int i = lowIndex; i <= highIndex; i++)
            {
                Console.WriteLine($"{i}, {Liczby[i]}");
                out_str += Liczby[i].ToString();
                out_str += ", ";
            
            }

            out_str = out_str.Remove(out_str.Length - 2);

            out_str += "]";
            Console.WriteLine(out_str);
        }
    }
}
