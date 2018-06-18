using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
