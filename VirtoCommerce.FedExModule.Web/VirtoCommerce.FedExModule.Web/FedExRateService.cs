using System;
using System.Collections.Generic;
using System.Linq;
using VirtoCommerce.Domain.Cart.Model;
using VirtoCommerce.Domain.Shipping.Model;
using VirtoCommerce.FedExModule.Web.Integration;

namespace VirtoCommerce.FedExModule.Web
{
    public class FedExRateService
    {
        public IEnumerable<ShippingRate> GetRatesForShoppingCart(FedExShippingMethod fedExShippingMethod, ShoppingCart shoppingCart, FedexWebServiceSettings settings)
        {
            var packages = FedExPackageCreator.CreatePackagesFromShoppingCart(shoppingCart);

            var rateService = new RateService(settings.WebServiceUrl);

            var rateRequest = CreateDefaultRateRequest(settings);
            rateRequest.RequestedShipment.RequestedPackageLineItems = packages;

            var result = rateService.getRates(rateRequest);

            return result.RateReplyDetails.Select(r => new ShippingRate
            {
                Currency = "USD",
                DiscountAmount = 0,
                DiscountAmountWithTax = 0,
                OptionDescription = r.ServiceType.ToString(),
                OptionName = r.ServiceType.ToString(),
                Rate = 1.70m,
                RateWithTax = 1.75M,
                ShippingMethod = fedExShippingMethod
            });
        }

        private RateRequest CreateDefaultRateRequest(FedexWebServiceSettings settings)
        {
            return new RateRequest
            {
                CarrierCodes = new CarrierCodeType[0],
                ClientDetail = new ClientDetail
                {
                    AccountNumber = settings.AccountNumber,
                    IntegratorId = settings.IntegratorId,
                    Localization = new Localization { LanguageCode = "", LocaleCode = "" },
                    MeterNumber = settings.MeterNumber,
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
                    RateRequestTypes = new[]
                    {
                        RateRequestType.LIST
                    },
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
                    ShippingChargesPayment = new Integration.Payment(),
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
                    Localization = new Localization { LanguageCode = "", LocaleCode = "" }
                },
                VariableOptions = new ServiceOptionType[0],
                Version = new VersionId(),
                WebAuthenticationDetail = new WebAuthenticationDetail
                {
                    ParentCredential = null,
                    UserCredential = new WebAuthenticationCredential
                    {
                        Key = settings.DeveloperKey,
                        Password = settings.Password
                    }
                }
            };
        }
    }
}