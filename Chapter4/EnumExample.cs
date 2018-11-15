using System;

namespace Chapter4
{
    
    
    class EnumExample
    {
        enum Dayofweek { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        static void Main(string[] args)
        {
            Dayofweek x;
            x = Dayofweek.Sun;
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}