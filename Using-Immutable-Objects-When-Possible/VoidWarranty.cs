using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Immutable_Objects_When_Possible
{
    public class VoidWarranty : IWarranty
    {
        [ThreadStatic]
        private static VoidWarranty _instance;

        private VoidWarranty() { }

        public static VoidWarranty Instance
        {
            get 
            {
                if(_instance == null)
                    _instance = new VoidWarranty();
                return _instance;
            }
        }

        public void Claim(DateTime onDate, Action onValidClaim){}

        private bool IsValidOn(DateTime date) => false;
    }
}
