using System;

namespace GymWebApp.Models {
    public class Client {
        public long id { get; set; }
        public string name { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public DateTime birthdate { get; set; }
    }
}