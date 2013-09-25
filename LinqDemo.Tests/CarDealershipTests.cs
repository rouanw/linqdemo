using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo.Tests
{
    [TestClass]
    public class CarDealershipTests
    {
        private CarDealership carDealership;

        [TestInitialize]
        public void Setup()
        {
            carDealership = new CarDealership();
        }

        // Count
        [TestMethod]
        public void ThereAreTwoBlueCars()
        {
            Assert.AreEqual(2, carDealership.GetNumberOfBlueCars());
        }

        // Where
        [TestMethod]
        public void CanGetAllVolkswagens()
        {
            var volkswagens = carDealership.GetVolkswagens();

            Assert.AreEqual(2, volkswagens.Count);
            Assert.AreEqual(volkswagens[0].Model, "Golf");
            Assert.AreEqual(volkswagens[1].Model, "Polo");
        }

        // Where
        [TestMethod]
        public void CanGetAllCarsCheaperThanNinetyThousand()
        {
            var cheapCars = carDealership.CheapCars();

            Assert.AreEqual(3, cheapCars.Count());
        }

        // Where - multiple conditions
        [TestMethod]
        public void CanGetAllFourteenHundredsCheaperThanNinetyThousand()
        {
            var cheapSlowCars = carDealership.CheapSlowCars();

            Assert.AreEqual(2, cheapSlowCars.Count());
        }

        // Any
        [TestMethod]
        public void ThereAreGreenCars()
        {
            Assert.IsTrue(carDealership.AreThereGreenCars());
        }

        // Any
        [TestMethod]
        public void ThereAreNoGoldCars()
        {
            Assert.IsTrue(carDealership.AreThereGoldCars());
        }

        // First
        [TestMethod]
        public void TheGolfIsFirstInTheList()
        {
            Assert.AreEqual("Golf", carDealership.FirstCar().Model);
        }

        // Last
        [TestMethod]
        public void ThePoloIsLastInTheList()
        {
            Assert.AreEqual("Polo", carDealership.LastCar().Model);
        }

        // Max
        [TestMethod]
        public void TheFocusHasTheHighestMileage()
        {
            Assert.AreEqual("Focus", carDealership.CarWithHighestMileage().Model);
        }

        // Min
        [TestMethod]
        public void TheGolfIsTheOldestCar()
        {
            Assert.AreEqual("Golf", carDealership.OldestCar().Model);
        }

        // OrderBy
        [TestMethod]
        public void CanArrangeModelsAlphabetically()
        {
            var orderedCars = carDealership.SortAlphabeticallyByModel();
            Assert.AreEqual("3 Series", orderedCars.First().Model);
        }

        // Sum
        [TestMethod]
        public void AllTheCarsCostALot()
        {
            Assert.AreEqual(449000, carDealership.PriceOfAllCars());
        }

        // ToList
        [TestMethod]
        public void GetAListOfTheBlueCars()
        {
            Assert.IsInstanceOfType(carDealership.GetBlueCarsAsList(), typeof(List<Car>));
        }

        // Select
        [TestMethod]
        public void CanGetAListOfModels()
        {
            var models = carDealership.AllModels();

            Assert.AreEqual(5, models.Count());
            Assert.IsTrue(models.Contains("golf"));
            Assert.IsFalse(models.Contains("polo"));
        }

        // Distinct
        [TestMethod]
        public void CanGetAListOfAllAvailableColours()
        {
            var colours = carDealership.AvailableColours();

            Assert.AreEqual(4, colours.Count());
            Assert.IsTrue(colours.Contains("blue"));
            Assert.IsFalse(colours.Contains("gold"));
        }
    }
}
