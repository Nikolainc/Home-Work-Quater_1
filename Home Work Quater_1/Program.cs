using System.Runtime.CompilerServices;

class Program
{
    const int _textlenght = 3;

    static void Main(string[] args)
    {
        string[] array = { "One", "Two", "Three", ":)", "VeryLongString", "123", "1", "", "01234567890"};
        PrintNewArray(array);
        Console.WriteLine();
    }

    static void PrintNewArray(string[] array)
    {
        string[] newArray;
        int newlenght = 0;

        foreach (var item in array)
        {
            if (IslenghtString(item))
            {
                newlenght++;
            }
        }

        newArray = new string[newlenght];

        foreach (var item in array)
        {
            if (IslenghtString(item))
            {
                newlenght--;
                newArray[newlenght] = item;
            }
        }
        newArray.Print();
    }
    static bool IslenghtString(string text)
    {
        if (text.Length <= _textlenght)
        {
            return true;
        }
        return false;
    }

}
static class MyExtention
{
    public static void Print(this string[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + "\t");
        }
    }
}