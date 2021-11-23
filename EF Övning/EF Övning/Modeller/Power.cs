using System.ComponentModel.DataAnnotations;

namespace EF_Övning.Modeller
{
    internal class Power
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public List<Hero> Heroes { get; set; }
    }
}
