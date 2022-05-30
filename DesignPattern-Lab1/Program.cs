namespace DesignPattern_Lab1;

public static class Program {
    public static void Main()
    {
        Calculator calculator = new();
        Console.WriteLine("1 for December");
        Console.WriteLine("2 for June or july");
        Console.WriteLine("3 for other months");
        Console.WriteLine("Select");
        int month = int.Parse(Console.ReadLine());
    }
}
