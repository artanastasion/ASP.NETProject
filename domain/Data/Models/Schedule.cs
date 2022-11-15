using System;

namespace domain.Data.Models
{
    public class Schedule
    {
        public virtual Doctor Doctor { get; set; }

        public DateTime StartDay { get; set; }

        public DateTime EndDay { get; set;}


    }
}
