using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Immutable_Objects_When_Possible
{
    public class SoldArticle
    {
        public IWarranty MoneyBackGuarantee { get; private set; }
        public IWarranty ExpressWarranty { get; private set; }
        public IWarranty NotOperationalWarranty { get; private set; }

        public SoldArticle(IWarranty moneyBackGuarantee, IWarranty expressWarranty, IWarranty notOperationalWarranty)
        {
            if(moneyBackGuarantee == null)
                throw new ArgumentException(nameof(moneyBackGuarantee));
            MoneyBackGuarantee = moneyBackGuarantee;
            if (expressWarranty == null)
                throw new ArgumentException(nameof(expressWarranty));

            ExpressWarranty = VoidWarranty.Instance;

            NotOperationalWarranty = notOperationalWarranty;
        }
        public void visibleDamage()
        {
            this.MoneyBackGuarantee = VoidWarranty.Instance;
        }
        public void NotOperational()
        {
            this.MoneyBackGuarantee = VoidWarranty.Instance;
            this.ExpressWarranty = NotOperationalWarranty;
        }
    }
}
