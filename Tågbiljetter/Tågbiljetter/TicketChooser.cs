using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tågbiljetter
{
    public class TicketChooser
    {
        public enum Biljetter
        {
            Enkelbiljett,
            Månadsbiljett,
            Nittiobiljett,
            Årsbiljett,
            Error
        }

        public double[] DayPrice { get; set; } = new double[] { 34, 68, 102 };
        public double[] MonthPrice { get; set; } = new double[] { 795, 1195, 1825 };
        public double[] TrimesterPrice { get; set; } = new double[] { 2145, 3225, 4930 };
        public double[] YearPrice { get; set; } = new double[] { 7950, 11950, 18250 };
    }
}
