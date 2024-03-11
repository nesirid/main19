using System.Collections.Generic;
using System.Text;
using System;


public class DataList<T>
{
        protected List<T> data;

    public DataList()
    {
        data = new List<T>();
    }
    public void Add(T item)
    {
        data.Add(item);
    }

    public void Delete(T item)
    {
        if (data.Contains(item))
        {
            data.Remove(item);
            Console.WriteLine($"{item} - bu listen pozulub");
        }
        else
        {
            Console.WriteLine($"{item} - bu listde tapilmadi(null)");
        }

    }
    public void Display()
    {
        Console.WriteLine("Hal hazirda olan list: ");
        foreach (T item in data)
        {
            Console.WriteLine(item);
        }
    }

    public void Clear()
    {
        data.Clear();
        Console.WriteLine("Butun elementler listen silindi.");
    }

}

