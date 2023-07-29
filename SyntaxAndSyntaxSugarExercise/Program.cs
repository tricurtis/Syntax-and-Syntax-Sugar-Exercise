namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
//int answer = 4;  //explict typing
//string response; //explict typing

//if (answer < 9)
//{
//    response = answer + " is less than nine";
//}
//else
//{
//    response = answer + " is greater than or equal to nine";
//}

var answer = 4;
var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

Console.WriteLine(response);