using System.ComponentModel.DataAnnotations;

namespace EF_Övning.Modeller
{
    internal class Hero
    {
        [Key]
        public int ID { get; set; }
        public string RealName { get; set; }
        public string Alias { get; set; }
        public List<Power> Powers { get; set; }
    }
}
