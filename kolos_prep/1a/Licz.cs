using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{

    internal class Licz
    {
        private int value;

        public Licz(int value = 4)
        {
            this.value = value;
        }
        
        public void Dodaj(int num = 4)
        {
            this.value += num;
        }
        
        public void Odejmij(int num)
        {
            this.value -= num;
        }

        public void Wypisz()
        {
            Console.WriteLine($"wartosc: {this.value}");
        }
    }
}
