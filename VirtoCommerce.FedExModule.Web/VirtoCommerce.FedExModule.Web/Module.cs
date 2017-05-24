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
            shippingService.RegisterShippingMethod(
                () => new FedExShippingMethod(settingManager.GetModuleSettings("FedExShippingMethodModule"), "FedEx"));
        }
    }
}