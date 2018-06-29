using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Machine
    {
        [Key]
        public int MachineID { get; set; }

        public string Name { get; set; }

        public string Ip { get; set; }

        public string OperatingSystem { get; set; }

        public string Manufacturer { get; set; }

        public virtual Cluster _Cluster {get; set;}
    }
}
