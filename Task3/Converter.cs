using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task3
{
    public class Converter
    {
        private readonly decimal usdRate; // UAH per USD
        private readonly decimal eurRate; // UAH per EUR

        public Converter(decimal usdToUah, decimal eurToUah)
        {
            usdRate = usdToUah > 0 ? usdToUah : 1m;
            eurRate = eurToUah > 0 ? eurToUah : 1m;
        }

        public decimal UahToUsd(decimal uah) => uah / usdRate;
        public decimal UsdToUah(decimal usd) => usd * usdRate;

        public decimal UahToEur(decimal uah) => uah / eurRate;
        public decimal EurToUah(decimal eur) => eur * eurRate;
    }
}