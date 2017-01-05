namespace Sitecore.Support.ContentSearch.SolrProvider.Pipelines.Loader
{
    using Sitecore.ContentSearch.SolrProvider;
    using Sitecore.ContentSearch.SolrProvider.SolrNetIntegration;
    using Sitecore.Pipelines;
    using Sitecore.Support.ContentSearch.SolrProvider.SolrNetIntegration;

    public class InitializeSolrProvider
    {
        public InitializeSolrProvider()
        {
        }

        public void Process(PipelineArgs args)
        {
            if (SolrContentSearchManager.IsEnabled)
            {
                if (IntegrationHelper.IsSolrConfigured())
                {
                    IntegrationHelper.ReportDoubleSolrConfigurationAttempt(base.GetType());
                }
                else
                {
                    new BasicAuthSolrStartup().Initialize();
                }
            }
        }
    }
}