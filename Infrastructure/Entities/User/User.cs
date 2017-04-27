using System;
using System.Collections.Generic;
using Infrastructure.Contracts;
using Infrastructure.Entities.Contract;


namespace Infrastructure.User
{
    public class User :IEntity
    {
        public  int Id { get; set; }
        public  string FirstName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public  string Phone { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
   
        public string Password { get; set; }
        public int? ConfirmCode { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfRegistered { get; set; }
        public DateTime? UpdateDate { get; set; }
        public List<Aquarium.Aquarium> Aquariums { get; set; }
        public List<Contract> Contracts { get; set; }

        public int? EmployeeId { get; set; }
        public DateTime UpdatedDateOfBirth { get; set; }

        public bool IsConfirmPhone { get; set; }
        public bool IsEmail { get; set; }

        public int? RegionId { get; set; }
        public int? CityId { get; set; }

        public double Discount { get; set; }

        public double Balance { get; set; }


    }
}
