using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Appointment
    {
        public short AppointmentId { get; set; }
        public string Status { get; set; }
        public DateTime AppointedDate { get; set; }
        public short DoctorId { get; set; }
        public short PatientId { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual HospitalBill HospitalBill { get; set; }
    }
}
