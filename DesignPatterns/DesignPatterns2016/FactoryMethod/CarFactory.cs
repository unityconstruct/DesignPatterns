using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2016.FactoryMethod
{
    public class CarFactory
    {
        
        public static void GetACarPrices()
        {
            var factory = new SedanCarFactory() as IVehicleFactory;
            var myHonda = factory.GetCar("Honda");
            var myKia = factory.GetCar("Kia");
            Console.WriteLine($"Honda Price is: {myHonda.Price}, Kia Price is: {myKia.Price}");
        }
    }

    // Product
    public abstract class ICar
    {
        public decimal Price { get; set; }
    }

    // Concrete Product
    public class HondaCar : ICar
    {
        public HondaCar()
        {
            Price = 15000;
        }
    }

    // Concrete Product
    public class KiaCar : ICar
    {
        public KiaCar()
        {
            Price = 16000;
        }
    }

    // Concrete Product
    public class ChevyTruck : ICar
    {
        public ChevyTruck()
        {
            Price = 25000;
        }
    }

    //Creator
    interface IVehicleFactory
    {
        ICar GetCar(string brandName);
    }

    //Concrete Creators
    public class SedanCarFactory : IVehicleFactory
    {
        public ICar GetCar(string brandName)
        {
            if(brandName == "Honda")
            {
                return new HondaCar();
            } else if (brandName == "Kia")
            {
                return new KiaCar();
            } else
            {
                throw new ArgumentException("Invalid Brand Name");
            }
        }
    }



}
