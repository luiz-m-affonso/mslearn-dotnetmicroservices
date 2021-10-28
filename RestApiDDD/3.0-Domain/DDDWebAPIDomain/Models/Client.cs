using System;

namespace DDDWebAPI.Domain.Models
{
    public class Client : Base
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool isActive { get; set; }
    }
}