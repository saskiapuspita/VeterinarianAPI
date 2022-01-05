using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinarianAPI.Models;

namespace VeterinarianAPI.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly ApplicationDbContext _context;

        public AppointmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Appointment> Create(Appointment appointment)
        {
            _context.Appointment.Add(appointment);
            await _context.SaveChangesAsync();

            return appointment;
        }

        public async Task Delete(int id)
        {
            var appointmentToDelete = await _context.Appointment.FindAsync(id);
            _context.Appointment.Remove(appointmentToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Appointment>> Get()
        {
            return await _context.Appointment.ToListAsync();
        }

        public async Task<Appointment> Get(int id)
        {
            return await _context.Appointment.FindAsync(id);
        }

        public async Task Update(Appointment appointment)
        {
            _context.Entry(appointment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
