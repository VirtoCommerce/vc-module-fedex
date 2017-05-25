using System;
using System.Collections.Generic;
using VirtoCommerce.Domain.Common;
using VirtoCommerce.Domain.Shipping.Model;
using VirtoCommerce.FedExModule.Web.Integration;

namespace VirtoCommerce.FedExModule.Web
{
    public class FedExShippingMethod : ShippingMethod
    {
        // https://github.com/VirtoCommerce/vc-module-core/blob/210bc9c16d68284fa50fda9c1df226a0519b4386/VirtoCommerce.CoreModule.Data/Shipping/FixedRateShipmentMethod.cs

        private readonly FedexWebServiceSettings _settings;

        public FedExShippingMethod(FedexWebServiceSettings settings, string code) : base(code)
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
            
            var rateService = new RateService();
            rateService.Url = _settings.WebServiceUrl;

            var rateRequest = new RateRequest
            {
                CarrierCodes = new CarrierCodeType[0],
                ClientDetail = new ClientDetail
                {
                    AccountNumber = _settings.AccountNumber,
                    IntegratorId = _settings.IntegratorId,
                    Localization = new Localization {LanguageCode = "", LocaleCode = ""},
                    MeterNumber = _settings.MeterNumber,
                    Region = ExpressRegionCode.US,
                    RegionSpecified = true
                },
                ConsolidationKey = null,
                RequestedShipment = new RequestedShipment
                {
                    BlockInsightVisibility = false,
                    BlockInsightVisibilitySpecified = false,
                    ConfigurationData = new DangerousGoodsDetail[0],
                    CustomsClearanceDetail = new CustomsClearanceDetail(),
                    DeliveryInstructions = "",
                    DropoffType = DropoffType.BUSINESS_SERVICE_CENTER,
                    DropoffTypeSpecified = true,
                    EdtRequestType = EdtRequestType.ALL,
                    EdtRequestTypeSpecified = true,
                    ExpressFreightDetail = new ExpressFreightDetail(),
                    FreightShipmentDetail = new FreightShipmentDetail(),
                    LabelSpecification = new LabelSpecification(),
                    Origin = new ContactAndAddress(),
                    PackageCount = "",
                    PackagingType = PackagingType.YOUR_PACKAGING,
                    PackagingTypeSpecified = true,
                    PickupDetail = new PickupDetail(),
                    PreferredCurrency = "",
                    RateRequestTypes = new RateRequestType[0],
                    Recipient = new Party(),
                    RecipientLocationNumber = "",
                    RequestedPackageLineItems = new RequestedPackageLineItem[0],
                    ServiceType = ServiceType.FEDEX_GROUND,
                    ServiceTypeSpecified = true,
                    ShipTimestamp = DateTime.Now,
                    ShipTimestampSpecified = true,
                    ShipmentAuthorizationDetail = new ShipmentAuthorizationDetail(),
                    ShipmentOnlyFields = new ShipmentOnlyFieldsType[0],
                    Shipper = new Party(),
                    ShippingChargesPayment = new Payment(),
                    ShippingDocumentSpecification = new ShippingDocumentSpecification(),
                    SmartPostDetail = new SmartPostShipmentDetail(),
                    SoldTo = new Party(),
                    SpecialServicesRequested = new ShipmentSpecialServicesRequested(),
                    TotalInsuredValue = new Money(),
                    TotalWeight = new Weight(),
                    VariableHandlingChargeDetail = new VariableHandlingChargeDetail(),
                    VariationOptions = new ShipmentVariationOptionDetail[0]
                },
                ReturnTransitAndCommit = false,
                ReturnTransitAndCommitSpecified = false,
                TransactionDetail = new TransactionDetail
                {
                    CustomerTransactionId = "",
                    Localization = new Localization {LanguageCode = "", LocaleCode = ""}
                },
                VariableOptions = new ServiceOptionType[0],
                Version = new VersionId(),
                WebAuthenticationDetail = new WebAuthenticationDetail
                {
                    ParentCredential = null,
                    UserCredential = new WebAuthenticationCredential
                    {
                        Key = _settings.DeveloperKey,
                        Password = _settings.Password
                    }
                }
            };

            var result = rateService.getRates(rateRequest);

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