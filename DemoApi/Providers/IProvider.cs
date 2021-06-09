using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Providers
{
    public interface IProvider
    {
        string Forecast(string providerId);
    }
}
