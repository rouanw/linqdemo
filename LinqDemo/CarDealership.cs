using System.Collections.Generic;

namespace LinqDemo
{
    public class CarDealership
    {
        private List<Car> cars = new List<Car>
            {
                new Car
                    {
                        Colour = "blue",
                        Make = "Volkswagen",
                        Model = "Golf",
                        Year = 1999,
                        EngineCapacity = 1400,
                        Price = 50000,
                        Mileage = 40000
                    },
                new Car
                    {
                        Colour = "blue",
                        Make = "BMW",
                        Model = "3 Series",
                        Year = 2005,
                        EngineCapacity = 1800,
                        Price = 150000,
                        Mileage = 140000
                    },
                new Car
                    {
                        Colour = "red",
                        Make = "Renault",
                        Model = "Clio",
                        Year = 2002,
                        EngineCapacity = 1400,
                        Price = 70000,
                        Mileage = 90000
                    },
                new Car
                    {
                        Colour = "green",
                        Make = "Ford",
                        Model = "Focus",
                        Year = 2006,
                        EngineCapacity = 1600,
                        Price = 80000,
                        Mileage = 200000
                    },
                new Car
                    {
                        Colour = "black",
                        Make = "Volkswagen",
                        Model = "Polo",
                        Year = 2010,
                        EngineCapacity = 1400,
                        Price = 99000,
                        Mileage = 20000
                    }
            };

        public int GetNumberOfBlueCars()
        {
            throw new System.NotImplementedException();
        }

        public List<Car> GetVolkswagens()
        {
            throw new System.NotImplementedException();
        }

        public bool AreThereGreenCars()
        {
            throw new System.NotImplementedException();
        }

        public bool AreThereGoldCars()
        {
            throw new System.NotImplementedException();
        }

        public Car FirstCar()
        {
            throw new System.NotImplementedException();
        }

        public Car LastCar()
        {
            throw new System.NotImplementedException();
        }

        public Car CarWithHighestMileage()
        {
            throw new System.NotImplementedException();
        }

        public Car OldestCar()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Car> SortAlphabeticallyByModel()
        {
            throw new System.NotImplementedException();
        }

        public decimal PriceOfAllCars()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<string> AllModels()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<string> AvailableColours()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Car> CheapCars()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Car> CheapSlowCars()
        {
            throw new System.NotImplementedException();
        }

        public List<Car> GetBlueCarsAsList()
        {
            throw new System.NotImplementedException();
        }
    }
}
