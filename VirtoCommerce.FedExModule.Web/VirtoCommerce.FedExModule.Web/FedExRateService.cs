using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using VirtoCommerce.Domain.Cart.Model;
using VirtoCommerce.Domain.Shipping.Model;
using VirtoCommerce.FedExModule.Web.Integration;
using Payment = VirtoCommerce.FedExModule.Web.Integration.Payment;

namespace VirtoCommerce.FedExModule.Web
{
    public class FedExRateService
    {
        public IEnumerable<ShippingRate> GetRatesForShoppingCart(FedExShippingMethod fedExShippingMethod, ShoppingCart shoppingCart, FedexWebServiceSettings settings)
        {
            var packages = CreatePackagesFromShoppingCart(shoppingCart);

            var rateService = new RateService(settings.WebServiceUrl);

            var rateRequest = CreateDefaultRateRequest(settings);

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

        private RequestedPackageLineItem[] CreatePackagesFromShoppingCart(ShoppingCart shoppingCart)
        {
            decimal totalVolume = 0;
            foreach (var shoppingCartItem in shoppingCart.Items)
            {
                // Cubic whatever he measurement is.
                decimal volume = (shoppingCartItem.Height ?? 0) * (shoppingCartItem.Width ?? 0) * (shoppingCartItem.Length ?? 0);


                var measureUnit = shoppingCartItem.MeasureUnit;
                if (measureUnit != "in")
                {
                    // convert
                }
                totalVolume += volume;
            }

            var packageDimension = Math.Round((totalVolume / 3), MidpointRounding.AwayFromZero).ToString(CultureInfo.InvariantCulture);

            var package = new RequestedPackageLineItem
            {
                ContentRecords = new ContentRecord[0],
                CustomerReferences = new CustomerReference[0],
                Dimensions = new Dimensions
                {
                    Height = packageDimension,
                    Length = packageDimension,
                    Units = LinearUnits.IN,
                    UnitsSpecified = true,
                    Width = packageDimension
                },
                GroupNumber = string.Empty,
                GroupPackageCount = string.Empty,
                InsuredValue = null,
                ItemDescription = string.Empty,
                ItemDescriptionForClearance = string.Empty,
                PhysicalPackaging = PhysicalPackagingType.CARTON,
                PhysicalPackagingSpecified = true,
                SequenceNumber = string.Empty,
                SpecialServicesRequested = null,
                VariableHandlingChargeDetail = null,
                Weight = new Weight
                {
                    Units = WeightUnits.LB,
                    UnitsSpecified = true,
                    Value = shoppingCart.Weight ?? 1,
                    ValueSpecified = true
                }
            };

            return new[] { package };
        }

    }
}