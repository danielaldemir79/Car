namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car myCar = new Car();
            myCar.Company = "Lexus RX";
            myCar.Color = "White";
            myCar.HorsePower = 500;
            myCar.Year = 2024;
            myCar.Gear = 6;
            myCar.EngineOn = true;
            myCar.EngineModel = Motor.MotorType.Hybrid;
            myCar.Speed = 250;

            Car yourCar = new Car();
            yourCar.Company = "BMW X5";
            yourCar.Color = "White";
            yourCar.HorsePower = 400;
            yourCar.Year = 2024;
            yourCar.Gear = 6;
            yourCar.EngineOn = true;
            yourCar.EngineModel = Motor.MotorType.Hybrid;
            yourCar.Speed = 240;

            Console.WriteLine("CAR 1");
            myCar.ShowInfo();
            Console.WriteLine();
            
            Console.WriteLine("Car 2");
            yourCar.ShowInfo();
            Console.WriteLine();

            myCar.Fuel();
            yourCar.Fuel();
            Console.WriteLine();

            Console.WriteLine("LET THE RACE BEGIN!");
            Console.WriteLine();
            myCar.Honk();
            yourCar.Honk();

       
            Console.WriteLine();
            myCar.IsFasterThan(yourCar);
        }

    }
}
