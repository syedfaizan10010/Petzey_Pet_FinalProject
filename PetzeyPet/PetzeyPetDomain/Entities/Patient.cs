using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetzeyPetDomain.Entities
{
    public class Patient
    {
        [Key]
        public int PetId { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public string OwnerEmail { get; set; }
        public string PetName { get; set; }
        public string PetBreed { get; set; }
        public string PetAge { get; set; }
        public gender Gender { get; set; }
        public string Address { get; set; }
        
        public string OwnerPhoneNo { get; set; }
        public string Avatar { get; set; }
        public string ShortBiography { get; set; }
        public status Status { get; set; }

        //Enumaration class
        public enum gender
        {
            Male,
            Female
        }
        public enum status
        {
            Active,
            InActive
        }
    }
}
