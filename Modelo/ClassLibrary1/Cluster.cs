using Model;
using System;

namespace Model
{
    public class Cluster
    {
        public int ClusterID { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public virtual Datacenter _Datacenter { get; set; }
    }
}
