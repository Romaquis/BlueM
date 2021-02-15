using System;
using System.Collections.Generic;

namespace BlueModasApi.Models {
    public class Sale {
        public int Id { get; set; }
        public Account Account { get; set; }
        public Payment Payment { get; set; }
        public IEnumerable<SaleItem> SaleItem{ get; set; }
        public DateTime CreateDate { get; set; }
    }
}