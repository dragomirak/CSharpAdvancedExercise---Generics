namespace Threeuple;

public class StartUp
{
    static void Main()
    {
        string[] tokens1 = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        if (tokens1.Length == 5)
        {
            Threeuple<string, string, string> firstPersonInfo = new($"{tokens1[0]} {tokens1[1]}", tokens1[2], $"{tokens1[3]} {tokens1[4]}");
            Console.WriteLine(firstPersonInfo);
        }
        else
        {
            Threeuple<string, string, string> firstPersonInfo = new($"{tokens1[0]} {tokens1[1]}", tokens1[2], tokens1[3]);
            Console.WriteLine(firstPersonInfo);
        }
        

        string[] tokens2 = Console.ReadLine()
          .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Threeuple<string, int, bool> secondPersonInfo = new(tokens2[0], int.Parse(tokens2[1]), tokens2[2] == "drunk");

        string[] tokens3 = Console.ReadLine()
          .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Threeuple<string, double, string> thirdPersonInfo = new(tokens3[0], double.Parse(tokens3[1]), tokens3[2]);

        
        Console.WriteLine(secondPersonInfo);
        Console.WriteLine(thirdPersonInfo);
    }
}