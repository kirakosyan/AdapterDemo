using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Providers
{
    public class BadProvider : IProvider
    {
        public string Forecast(string providerId)
        {
            return "Forecast from Bad provider, it is always raining!";
        }
    }
}
