using ConsoleApp2;

internal class Program
{
    private static void Main(string[] args)
    {
        Complex complex1 = new Complex(6,9);
        Complex complex2 = new Complex(3,11);
        Complex complex3 = (Complex)complex1.Add(complex2);
        Console.WriteLine(complex3.ToString());
        Complex complex4 = (Complex)complex1.Sub(complex2);
        Console.WriteLine(complex4.ToString());
        Complex complex5 = (Complex)complex1.Mul(complex2);
        Console.WriteLine(complex5.ToString());
        Complex complex6 = (Complex)complex1.Div(complex2);
        Console.WriteLine(complex6.ToString());
        Console.WriteLine(complex1.Equ(complex2));
        Complex complex7 = (Complex)complex2.Conj();
        Console.WriteLine(complex7.ToString());
    }
}