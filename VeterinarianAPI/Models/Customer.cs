using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinarianAPI.Models
{
    public class Customer
    {
        [Key]
        public int idCustomer { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public int PostalCode { get; set; }

        public List<Appointment> Appointment { get; set; }
    }
}
