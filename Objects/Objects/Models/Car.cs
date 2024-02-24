namespace Objects.Models;
public class Car
{
    private ConsoleColor cc = Console.ForegroundColor;
    public string Brand { get; set; } = "null";
    public string Model { get; set; } = "null";
    public int Year { get; set; } = -1;
    public string Color { get; set; } = "beyaz";

    public Car(List<Car> ListCar)
    {
        Console.Clear();
        Console.Write("Brand of car: ");
        this.Brand = Console.ReadLine();
        Console.Write("Model of brand: ");
        this.Model = Console.ReadLine();
        this.Year = TakeInt("The year of car: ");
        Console.Write("Color of car: ");
        this.Color = Console.ReadLine();
        ListCar.Add(this);
    }
    public int TakeInt(string text)
    {
        
        while (true)
        {
            try
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please input a valid number!");
                Console.ForegroundColor = cc;
            }
        }
    }
}