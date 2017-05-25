using Microsoft.Practices.Unity;
using VirtoCommerce.Domain.Shipping.Services;
using VirtoCommerce.Platform.Core.Modularity;
using VirtoCommerce.Platform.Core.Settings;

namespace VirtoCommerce.FedExModule.Web
{
    public class Module : ModuleBase
    {
        public static string FedExServiceUrl = "https://wsbeta.fedex.com:443/web-services/rate";

        private readonly IUnityContainer _container;

        public Module(IUnityContainer container)
        {
            _container = container;
        }

        public override void SetupDatabase()
        {
        }

        public override void Initialize()
        {
        }

        public override void PostInitialize()
        {
            var settingManager = _container.Resolve<ISettingsManager>();
            var shippingService = _container.Resolve<IShippingMethodsService>();

            var settings = settingManager.GetModuleSettings("FedExShippingMethodModule");
            var fedexSettings = new FedexWebServiceSettings();

            foreach (var settingEntry in settings)
            {
                if (settingEntry.Name == "Fedex.Connection.DeveloperKey")
                {
                    fedexSettings.DeveloperKey = settingEntry.Value;
                }

                if (settingEntry.Name == "Catalog.Connection.AccountNumber")
                {
                    fedexSettings.AccountNumber = settingEntry.Value;
                }

                if (settingEntry.Name == "Catalog.Connection.MeterNumber")
                {
                    fedexSettings.MeterNumber = settingEntry.Value;
                }
                
                if (settingEntry.Name == "Catalog.Connection.IntegratorId")
                {
                    fedexSettings.IntegratorId = settingEntry.Value;
                }

                if (settingEntry.Name == "Catalog.Connection.Password")
                {
                    fedexSettings.Password = settingEntry.Value;
                }

                if (settingEntry.Name == "Catalog.Connection.WebServiceUrl")
                {
                    fedexSettings.WebServiceUrl = settingEntry.Value;
                }
            }

            shippingService.RegisterShippingMethod(
                () => new FedExShippingMethod(fedexSettings, "FedEx"));
        }
    }
}