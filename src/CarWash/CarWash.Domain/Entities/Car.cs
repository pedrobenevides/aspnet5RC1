namespace CarWash.Domain.Entities
{
    public class Car
    {
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public Client Client { get; set; }
    }
}