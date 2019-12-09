using System;
using System.ComponentModel.DataAnnotations;

namespace Microgreens.Models
{
    public class Visitors
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Business { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public StaffNames StaffName { get; set; }




    }
}
