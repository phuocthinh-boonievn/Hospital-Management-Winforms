using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class AppointmentDAO
    {
        private static AppointmentDAO instance;
        private static readonly object instanceLock = new object();
        public static AppointmentDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AppointmentDAO();
                    }
                    return instance;
                }
            }
        }
        /*public IEnumerable<Category> GetCategories()
        {
            var categories = new List<Category>();
            try
            {
                using var context = new HospitalManagementContext();
                categories = context.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return categories;
        }*/
        public IEnumerable<Appointment> GetAppointments()
        {
            var appointments = new List<Appointment>();
            try
            {
                using var context = new HospitalManagementContext();
                appointments = context.Appointments.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return appointments;
        }
        public Appointment GetAppointmentByID(int id)
        {
            Appointment appointments = null;
            try
            {
                using var context = new HospitalManagementContext();
                appointments = context.Appointments.SingleOrDefault(p => p.AppointmentId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return appointments;
        }
        public void AddAppointment(Appointment appointment)
        {
            try
            {
                Appointment appointment1 = GetAppointmentByID(appointment.AppointmentId);
                if (appointment1 == null)
                {
                    using var context = new HospitalManagementContext();
                    context.Appointments.Add(appointment);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Appointment Already existed");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateAppointment(Appointment appointment)
        {
            try
            {
                Appointment appointment1 = GetAppointmentByID(appointment.AppointmentId);
                if (appointment1 != null)
                {
                    using var context = new HospitalManagementContext();
                    context.Appointments.Update(appointment);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Appointment does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemoveAppointment(int appointmentID)
        {
            try
            {
                Appointment appointment = GetAppointmentByID(appointmentID);
                if (appointment != null)
                {
                    using var context = new HospitalManagementContext();
                    context.Appointments.Remove(appointment);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The appointment does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
