namespace Kalkulačka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter first number:");
            double nr1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter second number:");
            double nr2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
                
            //int sum = int.Parse(s) + int.Parse(s1);

            /*string ll = (sum > 20) ? "more": "less";
            
            Console.WriteLine("Result is " + ll + " than " + 20 + ".");*/

            Console.WriteLine("Enter operator:");
            string wOperator = Console.ReadLine();
            double wResult;
            switch(wOperator)
            {
                case "+":
                    wResult = nr1 + nr2;
                break;

                case "-":
                    wResult = nr1 - nr2; 
                break;

                case "*":
                    wResult = nr1 *  nr2;
                break;

                case "/":
                    if (nr2 != 0)
                        wResult = nr2 / nr1;
                    else
                        Console.WriteLine("Error, can`t divide by zero.");
                    wResult = 0;
                break;

                default:
                    wResult = 0;
                break;

            }
            Console.WriteLine("Result: " + wResult);
        }
    }
}