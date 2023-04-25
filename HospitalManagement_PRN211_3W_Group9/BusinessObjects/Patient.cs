using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Patient
    {
        public Patient()
        {
            Appointments = new HashSet<Appointment>();
        }

        public short PatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public short AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
