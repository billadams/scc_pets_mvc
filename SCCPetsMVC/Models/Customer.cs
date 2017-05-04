using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SCCPetsMVC.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your state")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your zip")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", 
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }

        public int id { get; set; }
        
        public Customer() { }

        public Customer (string firstName, string lastName, string address, string city,
            string state, string zip, string email, string phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Email = email;
            this.Phone = phone;
        }
    }
}