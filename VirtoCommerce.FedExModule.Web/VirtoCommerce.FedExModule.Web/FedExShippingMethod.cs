using System;
using System.Collections.Generic;
using VirtoCommerce.Domain.Common;
using VirtoCommerce.Domain.Shipping.Model;
using VirtoCommerce.Platform.Core.Settings;

namespace VirtoCommerce.FedExModule.Web
{
    public class FedExShippingMethod : ShippingMethod
    {
        // https://github.com/VirtoCommerce/vc-module-core/blob/210bc9c16d68284fa50fda9c1df226a0519b4386/VirtoCommerce.CoreModule.Data/Shipping/FixedRateShipmentMethod.cs

        private readonly SettingEntry[] _settings;

        public FedExShippingMethod(SettingEntry[] settings, string code) : base(code)
        {
            _settings = settings;
        }

        public override IEnumerable<ShippingRate> CalculateRates(IEvaluationContext context)
        {
            var shippingEvalContext = context as ShippingEvaluationContext;
            if (shippingEvalContext == null)
            {
                throw new NullReferenceException("shippingEvalContext");
            }

            return new List<ShippingRate>
            {
                new ShippingRate
                {
                    Currency = "USD",
                    DiscountAmount = 0,
                    DiscountAmountWithTax = 0,
                    OptionDescription = "Standard",
                    OptionName = "Standard",
                    Rate = 1.5M,
                    RateWithTax = 1.75M,
                    ShippingMethod = this
                }
            };
        }
    }
}