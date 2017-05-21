using System;
using System.Collections.Generic;
using VirtoCommerce.Domain.Common;
using VirtoCommerce.Domain.Shipping.Model;
using VirtoCommerce.Platform.Core.Settings;

namespace VirtoCommerce.FedExModule.Web
{
    public class FedExShippingMethod : ShippingMethod
    {
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