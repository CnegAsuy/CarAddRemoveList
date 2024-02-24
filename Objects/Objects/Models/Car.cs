namespace Objects.Models;

public class Car
{
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

    public void List(List<Car> ListCar)
    {
        Console.Clear();
        foreach (var i in ListCar)
        {
            Console.WriteLine($"--------{i.Brand.ToUpper()}--------\n{i.Model}\n{i.Year}\n{i.Color}\n");
        }
        Console.ReadKey();
    }

    public void Delete(List<Car> ListCar)
    {
            Console.Clear();
            for (int i = 0; i < ListCar.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {ListCar[i].Brand} {ListCar[i].Model} {ListCar[i].Year}");
            }
            while (ListCar.Count > 0)
            {
            int choose = TakeInt("\nChoose One: ");
            try
            {
                ListCar.Remove(ListCar[choose - 1]);
                break;
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please input a valid number!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
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
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}