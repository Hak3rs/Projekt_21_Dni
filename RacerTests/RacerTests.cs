using Projekt_21_Dni;

namespace RacerTests
{
    public class Tests
    {

        [Test]
        public void WhenIndicatorOnTheSameShouldTrue()
        {
            var racer1 = new RacerInMemory(1, "Max", "Verstappen", 25);
            var racer2 = new RacerInMemory(2, "Lewis", "Hamilton", 35);
            var racer3 = racer1;

            Assert.AreEqual(racer1, racer3);
        }
        [Test]
        public void WhenGivePointsShouldShowSum()
        {
            var racer1 = new RacerInMemory(1, "Max", "Verstappen", 25);
            racer1.AddPoints(25);
            racer1.AddPoints(20);
            racer1.AddPoints("15");
            var stat1 = racer1.GetStatistics();
            Assert.AreEqual(60, stat1.Suma);
        }
        [Test]
        public void WhenGivePointsShouldShowAverage()
        {
            var racer1 = new RacerInMemory(1, "Max", "Verstappen", 25);
            racer1.AddPoints(15);
            racer1.AddPoints(10);
            racer1.AddPoints("8");
            var stat1 = racer1.GetStatistics();
            Assert.AreEqual(11, stat1.Srednia);
        }
        [Test]
        public void WhenGivePointsShouldShowMinMax()
        {
            var racer1 = new RacerInMemory(1, "Max", "Verstappen", 25);
            racer1.AddPoints(15);
            racer1.AddPoints(8);
            racer1.AddPoints("10");
            racer1.AddPoints(20);
            racer1.AddPoints(20);
            racer1.AddPoints("25");
            var stat1 = racer1.GetStatistics();
            Assert.AreEqual(25, stat1.Max);
            Assert.AreEqual(8, stat1.Min);
        }
        [Test]
        public void WhenGiveNewRacerShouldShowNewRacerDatails()
        {
            var racer1 = new RacerInMemory(1, "Max", "Verstappen", 25);
            var r1 = racer1.Name + " " + racer1.Surname;
            Assert.AreEqual("Max Verstappen", r1);
        }
    }
}