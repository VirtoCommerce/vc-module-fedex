using Microsoft.Practices.Unity;
using VirtoCommerce.Domain.Commerce.Services;
using VirtoCommerce.Domain.Shipping.Services;
using VirtoCommerce.Domain.Store.Services;
using VirtoCommerce.Platform.Core.Modularity;
using VirtoCommerce.Platform.Core.Settings;

namespace VirtoCommerce.FedExModule.Web
{
    public class Module : ModuleBase
    {
        private readonly IUnityContainer _container;

        public Module(IUnityContainer container)
        {
            _container = container;
        }

        public override void PostInitialize()
        {
            var settingManager = _container.Resolve<ISettingsManager>();
            var shippingService = _container.Resolve<IShippingMethodsService>();

            var settings = settingManager.GetModuleSettings("VirtoCommerce.FedEx");
            var fedexSettings = new FedexWebServiceSettings();

            foreach (var settingEntry in settings)
            {
                if (settingEntry.Name == "FedEx.Connection.DeveloperKey")
                {
                    fedexSettings.DeveloperKey = settingEntry.Value;
                }

                if (settingEntry.Name == "FedEx.Connection.AccountNumber")
                {
                    fedexSettings.AccountNumber = settingEntry.Value;
                }

                if (settingEntry.Name == "FedEx.Connection.MeterNumber")
                {
                    fedexSettings.MeterNumber = settingEntry.Value;
                }

                if (settingEntry.Name == "FedEx.Connection.IntegratorId")
                {
                    fedexSettings.IntegratorId = settingEntry.Value;
                }

                if (settingEntry.Name == "FedEx.Connection.Password")
                {
                    fedexSettings.Password = settingEntry.Value;
                }

                if (settingEntry.Name == "FedEx.Connection.WebServiceUrl")
                {
                    fedexSettings.WebServiceUrl = settingEntry.Value;
                }
            }

            shippingService.RegisterShippingMethod(
                () => new FedExShippingMethod(fedexSettings, _container.Resolve<IStoreService>(),
                    _container.Resolve<ICommerceService>(), "FedEx"));
        }
    }
}