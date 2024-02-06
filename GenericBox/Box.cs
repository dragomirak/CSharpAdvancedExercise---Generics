using System.Text;

namespace GenericBox;

public class Box<T>
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

    public void Swap(int firstIndex, int secondIndex)
    {
        CheckIndexValidity(firstIndex, secondIndex);
        //T temp = elements[firstIndex];
        //elements[firstIndex] = elements[secondIndex];
        //elements[secondIndex] = temp;

        (elements[firstIndex], elements[secondIndex]) = (elements[secondIndex], elements[firstIndex]);
    }

    private void CheckIndexValidity(int firstIndex, int secondIndex)
    {
        if (firstIndex < 0
                    || secondIndex < 0
                    || firstIndex >= elements.Count
                    || secondIndex >= elements.Count)
        {
            throw new IndexOutOfRangeException();
        }
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
