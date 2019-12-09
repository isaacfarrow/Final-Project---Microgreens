using System.ComponentModel.DataAnnotations;

namespace Microgreens.Models
{
    public class StaffNames
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int VisitorCount { get; set; }



    }
}
