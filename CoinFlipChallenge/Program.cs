internal class Program
{
    private static void Main(string[] args)
    {
        Random coin = new Random();
        int flip = coin.Next(0, 2);
        Console.WriteLine($"Coin toss {flip} : {(flip == 0 ? "heads" : "tails")}");
    }
}