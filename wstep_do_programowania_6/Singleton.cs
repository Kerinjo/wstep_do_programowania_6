using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wstep_do_programowania_6
{
    internal class Singleton
    {
        private static Singleton instance;

        public static Singleton getSingleton()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        private Singleton() { }
    }
}
