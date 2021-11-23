using System.ComponentModel.DataAnnotations;

namespace EntityFrameWorkDemo.Models
{
    internal class HiScore
    {
        [Key]
        public int Id { get; set; }
        public int Score { get; set; }
    }
}
