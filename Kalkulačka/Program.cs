namespace Kalkulačka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter first number:");
            string s = Console.ReadLine();

            Console.WriteLine("Enter second number:");
            string s1 = Console.ReadLine();

            //int sum = int.Parse(s) + int.Parse(s1);

            /*string ll = (sum > 20) ? "more": "less";
            
            Console.WriteLine("Result is " + ll + " than " + 20 + ".");*/

            Console.WriteLine("Enter operator:");
            string wOperator = Console.ReadLine();
            float wResult;
            switch(wOperator)
            {
                case "+":
                    wResult = float.Parse(s) + float.Parse(s1);
                break;

                case "-":
                    wResult = float.Parse(s) - float.Parse(s1); 
                break;

                case "*":
                    wResult = float.Parse(s) * float.Parse(s1);
                break;

                case "/":
                    wResult = float.Parse(s1) / float.Parse(s1);
                break;

                default:
                    wResult = 0;
                break;

            }
            Console.WriteLine("Result: " + wResult);
        }
    }
}