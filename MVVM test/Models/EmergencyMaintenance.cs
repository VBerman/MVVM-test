using System;
using System.Collections.Generic;

#nullable disable

namespace MVVM_test.Models
{
    public partial class EmergencyMaintenance
    {
        public EmergencyMaintenance()
        {
            ChangedParts = new HashSet<ChangedPart>();
        }

        public long ID { get; set; }
        public long AssetID { get; set; }
        public long PriorityID { get; set; }
        public string DescriptionEmergency { get; set; }
        public string OtherConsiderations { get; set; }
        public DateTime EMReportDate { get; set; }
        public DateTime? EMStartDate { get; set; }
        public DateTime? EMEndDate { get; set; }
        public string EMTechnicianNote { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual ICollection<ChangedPart> ChangedParts { get; set; }
    }
}
