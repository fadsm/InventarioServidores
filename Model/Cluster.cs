using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Cluster
    {
        [Key]
        public int ClusterID { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public int DatacenterID { get; set; }

        public virtual Datacenter _Datacenter { get; set; }
    }
}
