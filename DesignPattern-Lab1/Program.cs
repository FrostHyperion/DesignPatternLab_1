namespace DesignPattern_Lab1;

public static class Program {
    public static void Main() {
        Discount twentyfive = new TwentyFivePercentDiscount();
        Discount doubleAmount = new DoubleAmount();
        Discount NoChange = new NoChange();
        Console.WriteLine("1 for December");
        Console.WriteLine("2 for June or july");
        Console.WriteLine("3 for other months");
        Console.Write("Select: ");
        var month = Console.ReadLine();
        Calculator calculator = new CalculatorFare(NoChange);
        if (month == "1") {
            calculator.SetDiscount(doubleAmount);
        }
        if(month == "2")
        {
            calculator.SetDiscount(twentyfive);
        }
        if(month == "3")
        {
            calculator.SetDiscount(NoChange);
        }
        Console.WriteLine(calculator.GetDescription());
        Console.WriteLine(calculator.GetDiscount());
    }
}
