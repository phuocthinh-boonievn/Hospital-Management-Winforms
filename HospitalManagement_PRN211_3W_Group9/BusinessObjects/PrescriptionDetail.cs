using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class PrescriptionDetail
    {
        public string PrescriptedDose { get; set; }
        public byte PrescriptedAmount { get; set; }
        public string PrescriptionDescription { get; set; }
        public short BillId { get; set; }
        public short MedicineId { get; set; }

        public virtual HospitalBill Bill { get; set; }
        public virtual MedicineStorage Medicine { get; set; }
    }
}
