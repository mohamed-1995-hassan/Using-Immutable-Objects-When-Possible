using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Immutable_Objects_When_Possible
{
    public class LifeTimeWarranty : IWarranty
    {
        private DateTime DateIssued { get; }
        public LifeTimeWarranty(DateTime dateIssued)
        {
            DateIssued = dateIssued;
        }
        private bool IsValidOn(DateTime date) => date.Date >= DateIssued;

        public void Claim(DateTime onDate, Action onValidClaim)
        {
            if (!IsValidOn(onDate))
                return;
            onValidClaim();
        }
    }
}
