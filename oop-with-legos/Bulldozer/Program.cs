using System;

namespace Bulldozer
{
    // Main program
    class MainClass
    {
        static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            var result = worker.AddNumbers(2, 3);

            Console.WriteLine(result.ToString());
        }
    }

    // Class
    public class FactoryWorker
    {
        public FactoryWorker()
        {

        }

        // Method
        public int AddNumbers(int num1, int num2)
        {
            // This is essentially the factory, that will produce the result we want above
            // The Main program does not care how the result comes about - only cares that the result is what 
            // is expected
            var result = num1 + num2;

            result = result + 100;
            result = result - 100;

            return result;
        }

    }
}
