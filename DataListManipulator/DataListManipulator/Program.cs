
class Program
{
    static void Main(string[] args)
    {
        DataList<int> intList = new DataList<int>();
        intList.Add(1);
        intList.Add(2);
        intList.Add(3);
        intList.Add(4);
        intList.Add(5);
        intList.Display();
        intList.Delete(2);
        intList.Display();
        intList.Delete(4);
        intList.Display();
        intList.Clear();
        intList.Display();

        Console.WriteLine("________________INT-END_______________");

        DataList<string> stringList = new DataList<string>();
        stringList.Add("a");
        stringList.Add("Hello Krab");
        stringList.Display();
        stringList.Add("b");
        stringList.Display();
        stringList.Delete("b");
        stringList.Display();
        stringList.Clear();
        stringList.Display();






    }
}