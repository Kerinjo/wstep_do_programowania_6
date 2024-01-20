using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wstep_do_programowania_6
{
    internal class Cyfra
    {
        public static int a = 6;
    }
    
    internal class Utils
    {
        public static double abs(double num)
        {
            if (num > 0) 
            {
                return num;
            }
            else
            {
                return -num;
            }
        }
    }

}
