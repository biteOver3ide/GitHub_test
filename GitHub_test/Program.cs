using System;
//using GitHub_testt;

namespace GitHub_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!" +(new you()).Add(7,7));
            
             //Commnet from Juan

            int[] github = { 12, 36, 352, 36352, 32541, -653, -9683, 452 };
            if (github[2] == 352)
            {
                Console.WriteLine("Nice work");
            }
            else if(github[0] == 12)
            {
                Console.WriteLine("easy work");
            }
            else
                Console.WriteLine("Go home!");

            Console.ReadLine();
        }
    }

}
