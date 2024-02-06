using System.Text;

namespace Tuple;
public class StartUp
{
    static void Main()
    {
        List<CustomTuple<string, string>> list = new();

        for (int i = 0; i < 3; i++)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (input.Length == 3)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"{input[0]} ");
                sb.Append(input[1]);
                string result = sb.ToString().TrimEnd();

                CustomTuple<string, string> stringTuple  = new(result, input[2]);
                list.Add(stringTuple);
            }
            else
            {
                CustomTuple<string, string> currentTuple = new(input[0], input[1]);
                list.Add(currentTuple);
            }
                       
        }

        foreach (var t in list)
        {
            Console.WriteLine(t);
        }

    }
}