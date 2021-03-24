using Core.Entity;

namespace Entity.Concrete.DTOs
{
    public class CustomerForAddDto:IDto
    {
        public Customer Customer { get; set; }
        public Address Address { get; set; }

    }
}