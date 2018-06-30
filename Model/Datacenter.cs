using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Datacenter
    {
        [Key]
        public int DatacenterID { get; set;}

        public string Name { get; set; }

        public string Location { get; set; }

        public string OrganizationUnit { get; set; }
    }
}
