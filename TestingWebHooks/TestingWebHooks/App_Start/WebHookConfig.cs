




using System.Web.Http;

namespace TestingWebHooks
{
    public static class WebHookConfig
    {
        public static void Register(HttpConfiguration config)
        {

			config.InitializeReceiveGitHubWebHooks();

        }
    }
}
