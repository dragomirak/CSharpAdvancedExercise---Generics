namespace GenericBox;

public class StartUp
{
    static void Main()
    {
    //    Box<string> stringBox = new();

    //    int lines = int.Parse(Console.ReadLine());
    //    for (int i = 0; i < lines; i++)
    //    {
    //        stringBox.Add(Console.ReadLine());
    //    }

    //    string[] indexes = Console.ReadLine()
    //        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    //    int firstIndex = int.Parse(indexes[0]);
    //    int secondIndex = int.Parse(indexes[1]);

    //    stringBox.Swap(firstIndex, secondIndex);

    //    Console.WriteLine(stringBox);

        Box<int> intBox = new();

        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            intBox.Add(int.Parse(Console.ReadLine()));
        }

        string[] indexes = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int firstIndex = int.Parse(indexes[0]);
        int secondIndex = int.Parse(indexes[1]);

        intBox.Swap(firstIndex, secondIndex);
        Console.WriteLine(intBox);
    }
}
