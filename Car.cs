using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{


/*Lägg till ett fält för att hantera bilens motortyp, bensin, diesel, hybrid eller el.Använd en enum för att sätta bilens motor typ.

Lägg till en metod IsFasterThan(Car otherCar) som jämför hastigheten på två bilar och skriver ut vilken som är snabbast.*/
    internal class Car
    {

        public string Company;
        public string Color;
        public int HorsePower;
        public int Year;
        public int Gear;
        public bool EngineOn;
        public int Speed;
        
        public Motor.MotorType EngineModel;
        

        public void Honk()
        {
            Console.WriteLine("Beep beep!");
        }

        public void Fuel()
        {
            switch (EngineModel)
            {
                case Motor.MotorType.Bensin:
                    Console.WriteLine($"Bilen {Company} har en bensinmotor och tankas med bensin.");
                    break;
                case Motor.MotorType.Diesel:
                    Console.WriteLine($"Bilen {Company} har en dieselmotor och tankas med diesel.");
                    break;
                case Motor.MotorType.Hybrid:
                    Console.WriteLine($"Bilen {Company} har en hybridmotor och tankas med både bensin och el.");
                    break;
                case Motor.MotorType.El:
                    Console.WriteLine($"Bilen {Company} har en elmotor och tankas med el.");
                    break;
                default:
                    Console.WriteLine("Okänd motortyp.");
                    break;
            }
        }

        public void IsFasterThan(Car otherCar)
        {
            if (otherCar.Speed > Speed)
            {
                Console.WriteLine($"{otherCar.Company} is faste than {Company}");

            }
            else if (otherCar.Speed < Speed)
            {
                Console.WriteLine($"{Company} is faster than {otherCar.Company}");
            }
            else
            {
                Console.WriteLine($"{Company} and {otherCar.Company} have the same speed.");

            }


        }
        public void ShowInfo()
        {
            Console.WriteLine($"Company: {Company}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"HorsePower: {HorsePower}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Gear: {Gear}");
            Console.WriteLine($"EngineOn: {EngineOn}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"EngineModel: {EngineModel}");
        }
    }
}
