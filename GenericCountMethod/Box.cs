using System.Text;

namespace GenericCountMethod;

public class Box<T> where T: IComparable
{
    private List<T> elements;

    public Box()
    {
        elements = new List<T>();
    }
    public void Add(T element)
    {
        elements.Add(element);
    }

    public int Count(T element)
    {
        int count = 0;
        foreach (T item in elements) 
        { 
            if (item.CompareTo(element) > 0)
            {
                count++;
            }
        }
        return count;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (T element in elements)
        {
            sb.AppendLine($"{typeof(T)}: {element}");
        }
        return sb.ToString().TrimEnd();
    }
}
