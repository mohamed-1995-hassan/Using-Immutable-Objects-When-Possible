using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Immutable_Objects_When_Possible
{
    public interface IWarranty
    {
        void Claim(DateTime onDate, Action onValidClaim);
    }
}
