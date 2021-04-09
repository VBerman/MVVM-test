using System;
using System.Collections.Generic;

#nullable disable

namespace MVVM_test.Models
{
    public partial class Department
    {
        public Department()
        {
            DepartmentLocations = new HashSet<DepartmentLocation>();
        }

        public long ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DepartmentLocation> DepartmentLocations { get; set; }
    }
}
