public class Program
{
    static async void Main()
    {
        CarRentalManagementservice carRentalManager = new CarRentalManagementservice();
        CarRental bmw1 = new Bmw("X5");
        CarRental bmw2 = new Bmw("X6");
        CarRental bmw3 = new Bmw("X7");
        carRentalManager.Add(bmw1);
        carRentalManager.Add(bmw2);
        carRentalManager.Add(bmw3);
        CarRental audi1 = new Audi("Q6");
        CarRental audi2 = new Audi("Q7");
        CarRental audi3 = new Audi("T5");
        carRentalManager.Add(audi1);
        carRentalManager.Add(audi2);
        carRentalManager.Add(audi3);
        carRentalManager.Rent("Bmw");
        carRentalManager.Rent("Audi");

        await System.Threading.Tasks.Task.Delay(5000);
        carRentalManager.Return(bmw1.id, bmw1.RentPricePerHour);
        carRentalManager.Return(audi1.id, audi1.RentPricePerHour);
        carRentalManager.CalculateBalance();

    }
}
public abstract class CarRental
    {
        public CarRental(string brandName)
        {
            this.BrandName = brandName;
            this.id = Guid.NewGuid();
        }
        public bool IsRented { get; set; }
        public DateTime RentStartTime { get; set; }
        public decimal Balance { get; set; }

        public string BrandName { get; set; }
        public Guid id { get; set; }
        public abstract int RentPricePerHour { get; }
        public abstract string ModelName { get; }

}

public sealed class Bmw : CarRental
{
    public Bmw(string modelName) : base("BMW")
    {
        this.ModelName = modelName;
    }

    public override int RentPricePerHour { get; } = 30;
    public override string ModelName { get; }
}

public sealed class Audi : CarRental
{
    public Audi(string modelName) : base("Audi")
    {
        this.ModelName = modelName;
    }

    public override int RentPricePerHour { get; } = 20;
    public override string ModelName { get; }
}



public class CarRentalManagementservice
{
    public List<CarRental> Cars { get; private set; }

    public CarRentalManagementservice()
    {
         Cars = new List<CarRental>();

    }
    public void Add(CarRental Car) 
    {
        Cars.Add(Car);
    }
    

    public void Rent(string brandName)
    {
        CarRental carRent = Cars.Find(car => car.BrandName == brandName && !car.IsRented);
        if(carRent != null)
        {
            carRent.RentStartTime = DateTime.Now;
            carRent.IsRented = true;
        }
        else
        {
            Console.WriteLine("Uzr, hozirda ijaraga moshina yo'q");
        }
    } 

    public CarRental Return(Guid id, int renPrice)
    {
        CarRental carId = Cars.Find(car => car.id == id);
        if(carId != null)
        {
            TimeSpan rentDuration = DateTime.Now - carId.RentStartTime;
            int seconds = (int) rentDuration.TotalSeconds;
            carId.Balance += renPrice * seconds;
            carId.IsRented = false;
            carId.RentStartTime = default(DateTime);
        }
        return carId; 
    }

    public void CalculateBalance()
    {
        decimal totalbalance = 0;
        foreach(var car in Cars)
        {
            totalbalance += car.Balance;
        }
        Console.WriteLine($"Barcha moshinlarning jami Balance miqdori {totalbalance}");
    }
}