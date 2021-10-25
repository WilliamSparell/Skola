using System;
using System.Collections.Generic;

namespace Tågbiljetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TicketChooser();
            var des = new TicketChoose();
            var plannedTrips = 32;
            var zones = 2;
            double sum = 0;
            foreach (var biljett in des.Västtrafik(zones, plannedTrips))
            {
                double price = 0;
                switch (biljett)
                {
                    case TicketChooser.Biljetter.Enkelbiljett:
                        price = des.DayPrice[zones - 1]; break;
                    case TicketChooser.Biljetter.Månadsbiljett:
                        price = des.MonthPrice[zones - 1]; break;
                    case TicketChooser.Biljetter.Nittiobiljett:
                        price = des.TrimesterPrice[zones - 1]; break;
                    case TicketChooser.Biljetter.Årsbiljett:
                        price = des.YearPrice[zones - 1]; break;
                    case TicketChooser.Biljetter.Error:
                        price = des.DayPrice[zones - 1]; break;
                    default:
                        price = 0; break;

                }
                sum += price;
                Console.WriteLine(biljett + " " + price);
            }
            Console.WriteLine("Summa : " + sum);
        }

    }
    public class TicketChooser
    {
        public Biljetter[] Västtrafik(int zones = 1, int tripsPlanned = 1)
        {
            int turRetur = 2;
            List<Biljetter> biljetter = new List<Biljetter>();

            if (zones < 1) zones = 1;
            if (zones > 3) zones = 3;
            zones--;

            while (tripsPlanned > 0)
            {
                var sumDay = DayPrice[zones] * tripsPlanned;
                var sumMonth = MonthPrice[zones];
                var sumThreeMonths = TrimesterPrice[zones];
                var sumYear = YearPrice[zones];

                double[] sorted = new[] { sumDay, sumMonth, sumThreeMonths, sumYear };
                Array.Sort(sorted);

                if (sorted[0] == sumDay)
                {
                    // bearbetar data
                    biljetter.Add(Biljetter.Enkelbiljett);
                    biljetter.Add(Biljetter.Enkelbiljett);
                    tripsPlanned -= turRetur;
                }
                else if (sorted[0] == sumMonth)
                {
                    // bearbetar data
                    biljetter.Add(Biljetter.Månadsbiljett);
                    tripsPlanned -= 30 * turRetur;
                }
                else if (sorted[0] == sumThreeMonths)
                {
                    // bearbetar data
                    biljetter.Add(Biljetter.Nittiobiljett);
                    tripsPlanned -= 90 * turRetur;
                }
                else if (sorted[0] == sumYear)
                {
                    // bearbetar data
                    biljetter.Add(Biljetter.Årsbiljett);
                    tripsPlanned -= 365 * turRetur;
                }
                else
                {
                    biljetter.Add(Biljetter.Error);
                    break;
                }
            }
            // Presenterar resultatet
            return biljetter.ToArray();
        }
    }
}

