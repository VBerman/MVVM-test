using System;
using System.Collections.Generic;

#nullable disable

namespace MVVM_test.Models
{
    public partial class Priority
    {
        public Priority()
        {
            EmergencyMaintenances = new HashSet<EmergencyMaintenance>();
        }

        public long ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EmergencyMaintenance> EmergencyMaintenances { get; set; }
    }
}
