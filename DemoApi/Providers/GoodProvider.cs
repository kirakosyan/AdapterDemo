using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Providers
{
    public class GoodProvider : IProvider
    {
        public string Forecast(string providerId)
        {
            return "Forecast from Good provider, it is always sunny!";
        }
    }
}
