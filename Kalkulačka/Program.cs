namespace Kalkulačka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number to be added:");
            string s = Console.ReadLine();

            Console.WriteLine("Enter number to be added:");
            string s1 = Console.ReadLine();

            int sum = int.Parse(s) + int.Parse(s1);

            string ll = (sum > 20) ? "more": "less";
            
            Console.WriteLine("Result is " + ll + " than " + 20.);
        }
    }
}