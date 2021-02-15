using System.Collections.Generic;

namespace BlueModasApi.Models {
    public class Payment {
        public int Id { get; set; }
        public string NameCard { get; set; }
        public string NumberCard { get; set; }
        public string ExpirationDate { get; set; }
        public int SecurityCode { get; set; }
        public Sale Sale { get; set; }
    }
}