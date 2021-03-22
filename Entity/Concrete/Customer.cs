﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class Customer:IEntity
    {
        public int Id { get; set; }
        public int CustomerGruopId { get; set; }
        public string CommericalTitle { get; set; } // Cari Ünvanı
        public string Contact { get; set; } // Yetkili kişi
        public string Phone { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public string TraderNumber { get; set; }
        public int CityId { get; set; }
        public string AddressDetail { get; set; }
    }
}
