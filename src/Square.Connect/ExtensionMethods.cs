using Square.Connect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square.Connect
{
    public static class ExtensionMethods
    {
        public static decimal MoneyToDecimal(this V1Money money)
        {
            decimal result = 0;

            if (money != null)
            {
                decimal? total = (decimal)money.Amount / 100;

                if (!total.HasValue)
                    total = 0;

                result = total.Value;
            }

            return result;
        }
    }
}
