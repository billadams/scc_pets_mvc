using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SCCPetsMVC.Models
{
    public class Pet
    {
        [Required]
        public int id { get; set; }

        [Required]
        [MaxLength(15)]
        public string PetName { get; set; }

        [Required]
        public string Breed { get; set; }

        [Required]
        public bool IsFixed { get; set; }
    }
}