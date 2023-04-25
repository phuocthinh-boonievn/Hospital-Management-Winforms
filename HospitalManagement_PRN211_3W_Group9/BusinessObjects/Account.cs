using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Account
    {
        public Account()
        {
            Doctors = new HashSet<Doctor>();
            Patients = new HashSet<Patient>();
        }

        public short AccountId { get; set; }
        public short Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
