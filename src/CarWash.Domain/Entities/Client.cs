namespace CarWash.Domain.Entities
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public Car Car { get; set; }
    }
}
