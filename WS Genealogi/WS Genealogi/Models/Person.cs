using System.ComponentModel.DataAnnotations;

namespace WS_Genealogi.Models
{
    internal class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? Mor { get; set; }
        public string? Far { get; set; }

        public override string ToString()
        {
            // Här kan du returnera allt som en sträng
            return $"{Name} {LastName ?? "Efternamn saknas"} osv...";
        } 
        //okok, tack för hjälpen!
        // när du försöker skriva ut ett objekt av typen Person (som i foreachen) så anropas ToString automagiskt
        // :)
        // du kan prova med exempelvis "${Name ?? "Namn saknas"}", då skriver den "namn saknas" om Name är null
        // Måste rusa iväg, men vi kan höras av senare ikväll så kollar vi på det mer

    }
}
