using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Cart
    {
        public string PrescriptedDose { get; set; }
        public byte PrescriptedAmount { get; set; }
        public long MedicinePrice { get; set; }
        public string PrescriptionDescription { get; set; }
        public short MedicineId { get; set; }
    }
}
