using System;
using System.Collections.Generic;

#nullable disable

namespace MVVM_test.Models
{
    public partial class Part
    {
        public Part()
        {
            ChangedParts = new HashSet<ChangedPart>();
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public long? EffectiveLife { get; set; }

        public virtual ICollection<ChangedPart> ChangedParts { get; set; }
    }
}
