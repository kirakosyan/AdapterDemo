namespace DemoApi.Providers
{
    public class ProviderAdapter : IProvider
    {
        IProvider _g;
        IProvider _b;
        public ProviderAdapter(GoodProvider g, BadProvider b)
        {
            _g = g;
            _b = b;
        }

        public string Forecast(string providerId)
        {
            var factory = providerId.StartsWith("1") ? _b : _g;

            return factory.Forecast(providerId);
        }
    }
}
