
using System.Collections;

List<float> list = new List<float>();
list.Add(4f);
list.Add(2f);
list.Add(3f);

foreach(var n in list)
{
    Console.WriteLine(n);
}

public class List<T> : IEnumerable<T>
{
    private T[] values = new T[10];
    private int count = 0;


    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();
            return values[index];
        }
        set
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();
            values[index] = value;            
        }
    }


    public int Count => count;

    public void Add(T num)
    {
        if (count == values.Length)
        {
        T[] newArr = new T[2 * values.Length];
        for (int i = 0; i < values.Length; i++)
            newArr[i] = values[i];
        this.values = newArr;
        }


        values[count] = num;
        count++;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for(int i = 0; i < Count; i++)
        {
            yield return values[i];
        }
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}


public class ListIterator<T> : IEnumerator<T>
{
    private List<T> list;
    int index = -1;

    public ListIterator(List<T> list)
    {
        this.list = list;
    }


    public object Current => list[index];

    T IEnumerator<T>.Current => throw new NotImplementedException();

    public bool MoveNext()
    {
        index++;
        return index < list.Count;
    }

    public void Reset() => index = -1;
}


public interface IEnumerator<T>
{
    void Reset();
    T Current {get;}
    bool MoveNext();
}

