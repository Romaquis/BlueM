using System.Collections.Generic;

namespace BlueModasApi.Models {
    public class Account {
        public int Id {get; set;}
        public string Name {get; set;}
        public string LastName {get; set;}
        public string Document {get; set;}
        public string Email {get; set;}
        public string Phone { get; set; }
        public string Address {get; set;}
        public int Number {get; set;}
        public string ZipCode {get; set;}
        public string Neighborhood {get; set;}
        public string City {get; set;}
        public Sale Sale { get; set; }
    }
}