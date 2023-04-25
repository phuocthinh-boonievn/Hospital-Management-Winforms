using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class MedicineStorage
    {
        public short MedicineId { get; set; }
        public string MedicineName { get; set; }
        public long MedicinePrice { get; set; }
        public long MedicineAmount { get; set; }
    }
}
