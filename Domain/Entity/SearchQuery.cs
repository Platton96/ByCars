namespace Domain.Entity
{
    public class SearchQuery
    {
        public int Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int? YearLowerLimit { get; set; }
        public int? YearUpperLimit { get; set; }
        public decimal? CostLowerLimit { get; set; }
        public decimal? CostUpperLimit { get; set; }
        public Transmission Transmission { get; set; }
        public EnginesType EnginesType { get; set; }
        public int? MileageLowerLimit { get; set; }
        public int? MileageUpperLimit { get; set; }
        public int? EngineCapacityLowerLimit { get; set; }
        public int? EngineCapacityUpperLimit { get; set; }
        public string CarBody { get; set; }
        public DriveUnit DriveUnit { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
    }
}
