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

            Console.WriteLine($"Bilinfo. Modell: {myCar.Company} \nÅrsmodell: {myCar.Year} \nFärg:{myCar.Color} \nHästkrafter:{myCar.HorsePower} \nÄr motorn på: {myCar.EngineOn} \nVäxel: {myCar.Gear}");
        }
    }
}
