
namespace Domain.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string UrlImg { get; set; }
        public int Year { get; set; }
        public decimal Cost { get; set; }
        public Transmission? Transmission { get; set; }
        public EnginesType? EnginesType{ get; set; }
        public int? Mileage { get; set; }
        public int? EngineCapacity { get; set; }
        public string CarBody { get; set; }
        public DriveUnit? DriveUnit { get; set; }
    }
    public enum EnginesType
    {
        petrol,
        diesel,
        electro,
        hybrid
    }
    public enum Transmission
    {
        avtomatical,
        mechanical
    }
    public enum DriveUnit
    {
        back,
        front,
        full
    }
}
