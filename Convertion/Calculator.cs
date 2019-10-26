using System;

namespace Convertion
{
    public class Calculator
    {
        public static bool Calcolo1()
        {
            double a = 1.0 / 10.0;
            double s = a + a + a + a + a + a + a + a + a + a;
            if (s == 1.0)
                return true;
            else
                return false;
        }
        public static bool Calcolo2()
        {
            double a = 1.0 / 10.0;
            double p = a * 10.0;
            if (p == 1.0)
                return true;
            else
                return false;
        }
        public static bool Calcolo3()
        {
            string s = "a";
            int c = Convert.ToInt32(s);
            if (c == 97)
                return true;
            else
                return false;
        }
    }
}
