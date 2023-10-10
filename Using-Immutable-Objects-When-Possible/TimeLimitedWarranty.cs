using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Immutable_Objects_When_Possible
{
    public class TimeLimitedWarranty : IWarranty
    {
        private DateTime DateIssued { get; }
        private TimeSpan Duration { get; }
        public TimeLimitedWarranty(DateTime dateIssued, TimeSpan duration)
        {
            DateIssued = dateIssued;
            Duration = duration;
        }

        private bool IsValidOn(DateTime dateTime) =>
            dateTime.Date >= this.DateIssued &&
            dateTime.Date < DateIssued + Duration;

        public void Claim(DateTime onDate, Action onValidClaim)
        {
            if (!IsValidOn(onDate))
                return;
            onValidClaim();
        }
    }
}
