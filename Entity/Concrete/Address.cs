using Core.Entity;

namespace Entity.Concrete
{
    public class Address:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string Detail { get; set; }

        
    }
}