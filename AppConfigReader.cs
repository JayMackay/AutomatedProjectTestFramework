using System.Configuration;

namespace AutomationProjectTestFramework
{
    //Global reader for the App.config attirbutes
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string ShoppingCartUrl = ConfigurationManager.AppSettings["shoppingcart_url"];
    }
}
