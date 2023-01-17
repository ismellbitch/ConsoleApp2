using ConsoleApp2;

internal class Program
{
    private static void Main(string[] args)
    {
        Complex complex1 = new Complex(6,9);
        Complex complex2 = new Complex(3,11);
        Complex complex3 = (Complex)complex1.Add(complex2);
        Console.WriteLine(complex3.ToString());
    }
}