namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //inferred typing
            var answer = 4;
            // string interpolation and ternary operation conversion
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine.";
            Console.WriteLine(response);    

        }
    }
}
