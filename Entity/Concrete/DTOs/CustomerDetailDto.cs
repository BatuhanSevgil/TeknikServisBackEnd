using Core.Entity;

namespace Entity.Concrete.DTOs
{
    public class CustomerDetailDto:IDto
    {
        public int Id { get; set; }
        public string CustomerGroup { get; set; }
        public string Contact { get; set; } // Yetkili kişi
        public string CommercialTitle { get; set; }
        public string AddressDetail { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string District { get; set; }

    }
}