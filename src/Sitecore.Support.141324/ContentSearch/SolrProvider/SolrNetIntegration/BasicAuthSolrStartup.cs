namespace Sitecore.Support.ContentSearch.SolrProvider.SolrNetIntegration
{
    using Sitecore.ContentSearch.SolrProvider;
    using Sitecore.ContentSearch.SolrProvider.SolrNetIntegration;
    using SolrNet;
    using SolrNet.Impl;

    public class BasicAuthSolrStartup : DefaultSolrStartUp
    {
        protected override ISolrConnection CreateConnection(string serverUrl)
        {
            SolrConnection connection = new SolrConnection(serverUrl)
            {
                Timeout = SolrContentSearchManager.ConnectionTimeout,
                HttpWebRequestFactory = SolrContentSearchManager.HttpWebRequestFactory
            };
            if (SolrContentSearchManager.EnableHttpCache)
            {
                connection.Cache = new HttpRuntimeCache();
            }
            return connection;
        }
    }
}