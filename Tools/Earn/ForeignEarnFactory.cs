using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    public class ForeignEarnFactory : EarnFactory
    {
        private decimal _percentage;
        private decimal _extra;

        public ForeignEarnFactory(decimal percentage, decimal extra) 
        {
            _extra = extra;
            _percentage = percentage;
        }
        public override IEarn GetEarn()
        {
            return new ForeignEarn(_percentage, _extra);
        }
    }
}
