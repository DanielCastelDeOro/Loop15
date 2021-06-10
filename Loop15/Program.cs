using System;

namespace Loop15
{
    class Program
    {
        static void Main(string[] args)
        {//loop 15
            var i = 0;

            while (i < 15)
            {
                Console.WriteLine(i);
                i++;

            }
            //will only loop by even numbers
            var d = 2;
            while (d < 28)
            {
                if(d % 2 == 0)
                {
                    Console.WriteLine(d);
                }
                d++;
            }

            
        }
    }
}
