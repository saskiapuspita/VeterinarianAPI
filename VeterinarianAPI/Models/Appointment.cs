using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinarianAPI.Models
{
    public class Appointment
    {
        [Key]
        public int idAppointment { get; set; }

        public DateTime DateOfAppointment { get; set; }

        public string PetName { get; set; }

        public string ContactPerson { get; set; }

        public string Notes { get; set; }

        public Customer customer { get; set; }
    }
}
