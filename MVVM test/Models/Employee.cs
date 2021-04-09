using System;
using System.Collections.Generic;

#nullable disable

namespace MVVM_test.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Assets = new HashSet<Asset>();
        }

        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public bool? isAdmin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }
    }
}
