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

            Car yourCar = new Car();
            yourCar.Company = "BMW X5";
            yourCar.Color = "White";
            yourCar.HorsePower = 400;
            yourCar.Year = 2024;
            yourCar.Gear = 6;
            yourCar.EngineOn = true;
            yourCar.EngineModel = Motor.MotorType.Hybrid;

           

            myCar.Honk();
            myCar.Fuel();
        }
    }
}
