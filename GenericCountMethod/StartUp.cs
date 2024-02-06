namespace GenericCountMethod;

public class StartUp
{
    static void Main()
    {
        //Box<string> stringBox = new();

        //int lines = int.Parse(Console.ReadLine());
        //for (int i = 0; i < lines; i++)
        //{
        //    stringBox.Add(Console.ReadLine());
        //}

        //string compareWith = Console.ReadLine();

        //Console.WriteLine(stringBox.Count(compareWith));

        Box<double> doubleBox = new();

        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            doubleBox.Add(double.Parse(Console.ReadLine()));
        }

        double compareWith = double.Parse(Console.ReadLine());

        Console.WriteLine(doubleBox.Count(compareWith));

    }
}