namespace TheShop.Models
{
    public class Services
    {
        public int ServicesId { get; set; }
        public string ServicesName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int ServiceTypeId { get; set; }


    }

    public class ServiceType
    {
        public int ServiceTypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }

    }
}
