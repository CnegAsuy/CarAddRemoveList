using Objects.Models;
List<Car> listCar = new List<Car>();
var car = new Car(listCar);
while (true)
{
    Console.Clear();
    Console.Write("1. Add\n2. Remove\n3. List\n4. Exit\nChoose One: ");
    switch (Console.ReadLine())
    {
        case "1":
            car = new Car(listCar);
            break;
        case "2":
            car.Delete(listCar);
            break;
        case "3":
            car.List(listCar);
            break;
        case "4":
            Environment.Exit(31);
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please input a valid number!");
            Console.ForegroundColor = ConsoleColor.Gray;
            break;
    }
}