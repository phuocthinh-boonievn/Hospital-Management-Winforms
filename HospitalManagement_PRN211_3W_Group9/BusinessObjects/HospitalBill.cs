using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class HospitalBill
    {
        public short BillId { get; set; }
        public DateTime BillDate { get; set; }
        public double TotalPrice { get; set; }
        public short AppointmentId { get; set; }

        public virtual Appointment Bill { get; set; }
    }
}
