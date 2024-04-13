namespace Lecture_5_HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("Audi", "A4");
            audi.CarWeight = 2000;
            audi.Cost = 15000;
            Car BMW = new Car("BMW", "M5");
            audi.CarWeight = 2100;
            audi.Cost = 25000;
            Car WV = new Car("WV", "Transparter");
            WV.carWeight = 3500;
            WV.Cost = 20000;
            Car Lexus = new Car("Lexus", "S10");
        }
    }
}