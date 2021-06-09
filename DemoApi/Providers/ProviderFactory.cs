namespace DemoApi.Providers
{
    public class ProviderFactory : IProvider
    {
        IProvider _g;
        IProvider _b;
        public ProviderFactory(GoodProvider g, BadProvider b)
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
