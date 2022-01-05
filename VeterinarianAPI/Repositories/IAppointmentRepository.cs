using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinarianAPI.Models;

namespace VeterinarianAPI.Repositories
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<Appointment>> Get();

        Task<Appointment> Get(int id);

        Task<Appointment> Create(Appointment appointment);

        Task Update(Appointment appointment);

        Task Delete(int id);
    }
}
