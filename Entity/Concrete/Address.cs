using Core.Entity;

namespace Entity.Concrete
{
    public class Address:IEntity
    {
        public int AddressId { get; set; }
        public int CustomerAddressId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string AddressDetails { get; set; }

        
    }
}