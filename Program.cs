namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Display the following using string interpolation:
            //From today’s date
            

            //{<interpolationExpression>[,<alignment>][:<formatString>]}
            var date = DateTime.Now;

            //1.January 22, 2019(right aligned in a 40 character field)
            Console.WriteLine($"{date,40:MMMM dd, yyyy}");
            
            //2.2019.01.22
            Console.WriteLine($"{date:yyyy.MM.dd}");










            var pi = Math.PI;


        }
    }
}