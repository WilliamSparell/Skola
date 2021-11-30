using System.ComponentModel.DataAnnotations;

namespace WS_Genealogi.Models
{
    internal class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; } // Bara för VG
        public string DeathDate { get; set; } // Bara för VG
        public string Mor { get; set; }
        public string Far { get; set; }
    }
}
