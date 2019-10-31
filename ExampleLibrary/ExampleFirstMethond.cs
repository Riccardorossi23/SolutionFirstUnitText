using System;

namespace ExampleLibrary
{
    public class ExampleFirstMethond
    {
        public static bool Calcolo1()
        {
            double a = 1.0 / 10.0;
            double somma = a + a + a + a + a + a + a + a + a + a;
            if (somma == 1)
                return true;
            else
                return false;
        }
        public static bool Calcolo2()
        {
            double b = 1.0 / 10.0;
            double s = b * 10;
            if (s == 1)
                return true;
            else
                return false;

        }
  
    }
   
}
