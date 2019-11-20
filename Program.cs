using System;

namespace BasicPart11_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.Write("Input first number : ");
            int.TryParse(Console.ReadLine(), out x);
            Console.Write("Input second number : ");
            int.TryParse(Console.ReadLine(), out y);

            try
            {

                double z = x / y;

                Console.WriteLine("Output : " + z);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Divide by Zero");
            }
            finally
            {
                Console.WriteLine("End Program.");
            }

            Console.ReadKey();
        }
    }
}
