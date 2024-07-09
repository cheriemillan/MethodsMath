namespace MethodsMath;

class Program
{
    public static int? Add()
    {
        int num1=Convert.ToInt32(Console.ReadLine());
        int num2=Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {sum}");
        return null;
    }
     public static int? Subtract()
    {
        int num1=Convert.ToInt32(Console.ReadLine());
        int num2=Convert.ToInt32(Console.ReadLine());
        int sum = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {sum} ");
        return null;
    }
    public static int? Multiply()
    {
        int num1=Convert.ToInt32(Console.ReadLine());
        int num2=Convert.ToInt32(Console.ReadLine());
        int sum = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {sum} ");
        return null;
    }
    public static int? Divide()
    {
        int num1=Convert.ToInt32(Console.ReadLine());
        int num2=Convert.ToInt32(Console.ReadLine());
        int sum = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {sum} ");
        return null;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Please put in any two numbers of your choosing to add:");
        Console.WriteLine(Add());
        Console.WriteLine("Please put in any two numbers of your choosing to subtract:");
        Console.WriteLine(Subtract());
        Console.WriteLine("Please put in any two numbers of your choosing to multiply:");
        Console.WriteLine(Multiply());
        Console.WriteLine("Please put in any two numbers of your choosing to divide:");
        Console.WriteLine(Divide());
    }
}