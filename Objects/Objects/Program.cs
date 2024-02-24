using Objects.Models;
ConsoleColor cc = Console.ForegroundColor;
List<Car> listCar = new List<Car>();

void List()
{
    Console.Clear();
    foreach (var i in listCar)
    {
        Console.WriteLine($"--------{i.Brand.ToUpper()}--------\n{i.Model}\n{i.Year}\n{i.Color}\n");
    }
    Console.ReadKey();
}

void Delete()
{
    Console.Clear();
    for (int i = 0; i < listCar.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {listCar[i].Brand} {listCar[i].Model} {listCar[i].Year}");
    }
    while (listCar.Count > 0)
    {
        int choose = TakeInt("\nChoose One: ");
        try
        {
            listCar.Remove(listCar[choose - 1]);
            break;
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please input a valid number!");
            Console.ForegroundColor = cc;
        }
    }
}

int TakeInt(string text)
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

while (true)
{
    Console.Clear();
    Console.Write("1. Add\n2. Remove\n3. List\n4. Exit\nChoose One: ");
    switch (Console.ReadLine())
    {
        case "1":
            var car = new Car(listCar);
            break;
        case "2":
            Delete();
            break;
        case "3":
            List();
            break;
        case "4":
            Environment.Exit(31);
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please input a valid number!");
            Console.ForegroundColor = cc;
            Console.ReadKey();
            break;
    }
}