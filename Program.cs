namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car MyCar = new Car();
            MyCar.Brand = "Lexus RX";
            MyCar.Color = "White";
            MyCar.HorsePower = 500;
            MyCar.Year = 2024;
            MyCar.Gear = 6;
            MyCar.EngineOn = true;

            Console.WriteLine($"Bilinfo. Modell: {MyCar.Brand} \nÅrsmodell: {MyCar.Year} \nFärg:{MyCar.Color} \nHästkrafter:{MyCar.HorsePower} \nÄr motorn på: {MyCar.EngineOn} \nVäxel: {MyCar.Gear}");
        }
    }
}
