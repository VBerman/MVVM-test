using System;
using System.Collections.Generic;

#nullable disable

namespace MVVM_test.Models
{
    public partial class Asset
    {
        public Asset()
        {
            EmergencyMaintenances = new HashSet<EmergencyMaintenance>();
        }

        public long ID { get; set; }
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
        public long DepartmentLocationID { get; set; }
        public long EmployeeID { get; set; }
        public long AssetGroupID { get; set; }
        public string Description { get; set; }
        public DateTime? WarrantyDate { get; set; }

        public virtual AssetGroup AssetGroup { get; set; }
        public virtual DepartmentLocation DepartmentLocation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<EmergencyMaintenance> EmergencyMaintenances { get; set; }
    }
}
