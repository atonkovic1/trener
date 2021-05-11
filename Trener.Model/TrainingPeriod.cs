using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.Model
{
    public class TrainingPeriod
    {
        public int PeriodId { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan PeriodStart { get; set; }
        public TimeSpan PeriodEnd { get; set; }

        public TrainingPeriod(DayOfWeek dayOfWeek, TimeSpan periodStart, TimeSpan periodEnd)
        {
            if (periodStart != null && periodEnd != null)
            {
                PeriodId = -1;
                DayOfWeek = dayOfWeek;
                PeriodStart = periodStart;
                PeriodEnd = periodEnd;
            }
            else
            {
                throw new IncompleteDataException();
            }
        }
    }
}