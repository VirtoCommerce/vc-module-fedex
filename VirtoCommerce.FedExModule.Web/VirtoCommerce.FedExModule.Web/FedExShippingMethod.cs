using System;
using System.Collections.Generic;
using VirtoCommerce.Domain.Common;
using VirtoCommerce.Domain.Shipping.Model;

namespace VirtoCommerce.FedExModule.Web
{
    public class FedExShippingMethod : ShippingMethod
    {
        // https://github.com/VirtoCommerce/vc-module-core/blob/210bc9c16d68284fa50fda9c1df226a0519b4386/VirtoCommerce.CoreModule.Data/Shipping/FixedRateShipmentMethod.cs
        
        public FedexWebServiceSettings FedExSettings { get; private set; }

        public FedExShippingMethod(FedexWebServiceSettings settings, string code) : base(code)
        {
            FedExSettings = settings;
            Name = "Fedex Shipping Method";
            Description = "Simple shipping method for a rough cost.";
        }

        public override IEnumerable<ShippingRate> CalculateRates(IEvaluationContext context)
        {
            var shippingEvalContext = context as ShippingEvaluationContext;
            if (shippingEvalContext == null)
            {
                throw new NullReferenceException("shippingEvalContext");
            }

            var service = new FedExRateService();
            return service.GetRatesForShoppingCart(this, shippingEvalContext.ShoppingCart);

        }
}
}