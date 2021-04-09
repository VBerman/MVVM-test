using System;
using System.Collections.Generic;

#nullable disable

namespace MVVM_test.Models
{
    public partial class DepartmentLocation
    {
        public DepartmentLocation()
        {
            Assets = new HashSet<Asset>();
        }

        public long ID { get; set; }
        public long DepartmentID { get; set; }
        public long LocationID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Department Department { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
    }
}
