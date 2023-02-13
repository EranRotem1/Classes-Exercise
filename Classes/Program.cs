namespace Classes
{
    public class Car
    {
        public Car(string _make, string _model, string _year)
        {
            Make = _make;
            Model = _model;
            Year = _year;   

        }
        public string Make;
        public string Model;
        public string Year;

        static void Main(string[] args)
        {
            Car dreamCar = new Car("Audi", "R8", "2023");
            Console.WriteLine(string.Join(" ", dreamCar.Make , dreamCar.Model , dreamCar.Year));
            Console.WriteLine(dreamCar.Model);
            Console.WriteLine(dreamCar.Year);
        }
    }
}
