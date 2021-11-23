using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagbok.Modell
{
    internal class Anteckningar
    {
        [Key]
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string Titel { get; set; }
        public string Anteckning { get; set; }
    }
}
