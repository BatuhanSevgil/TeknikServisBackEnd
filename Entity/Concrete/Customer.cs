using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class Customer:IEntity
    {
        public int Id { get; set; }
        public int CustomerGroupId { get; set; }
        public string CommericalTitle { get; set; } // Cari Ünvanı
        public string Contact { get; set; } // Yetkili kişi
        public string Phone { get; set; }
        public string Address { get;set;}
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public string TraderNumber { get; set; }

    }
}
