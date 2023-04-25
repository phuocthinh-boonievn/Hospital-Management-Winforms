using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AppointmentRepository : IRepositoryBase<Appointment>
    {
        public IEnumerable<Appointment> GetAll() => AppointmentDAO.Instance.GetAppointments();

        public Appointment GetByID(int id) => AppointmentDAO.Instance.GetAppointmentByID(id);

        public void Insert(Appointment entity) => AppointmentDAO.Instance.AddAppointment(entity);

        public void Update(Appointment entity) => AppointmentDAO.Instance.UpdateAppointment(entity);
        public void Delete(int id) => AppointmentDAO.Instance.RemoveAppointment(id);
    }
}
