using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Doctor
    {
        public Doctor()
        {
            Appointments = new HashSet<Appointment>();
        }

        public short DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSpecialization { get; set; }
        public short AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
