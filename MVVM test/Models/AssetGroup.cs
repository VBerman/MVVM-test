using System;
using System.Collections.Generic;

#nullable disable

namespace MVVM_test.Models
{
    public partial class AssetGroup
    {
        public AssetGroup()
        {
            Assets = new HashSet<Asset>();
        }

        public long ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }
    }
}
