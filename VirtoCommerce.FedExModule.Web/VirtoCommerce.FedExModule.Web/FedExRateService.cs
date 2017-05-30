using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VirtoCommerce.Domain.Cart.Model;
using VirtoCommerce.Domain.Cart.Services;
using VirtoCommerce.Domain.Shipping.Model;
using VirtoCommerce.FedExModule.Web.Integration;

namespace VirtoCommerce.FedExModule.Web
{
    public class FedExRateService
    {
        public IEnumerable<ShippingRate> GetRatesForShoppingCart(FedExShippingMethod fedExShippingMethod, ShoppingCart shoppingCart, IShoppingCartService shoppingCartService)
        {
            var packages = FedExPackageCreator.CreatePackagesFromShoppingCart(shoppingCart);

            var rateService = new RateService(fedExShippingMethod.FedExSettings.WebServiceUrl);

            var rateRequest = CreateDefaultRateRequest(fedExShippingMethod.FedExSettings);
            rateRequest.RequestedShipment.RequestedPackageLineItems = packages;
            rateRequest.RequestedShipment.PackageCount = packages.Length.ToString();
            
            rateRequest.RequestedShipment.Shipper = new Party
            {
                Address = new Integration.Address
                {
                    City = "Great Falls",
                    CountryCode = "US",
                    CountryName = "United States",
                    PostalCode = "59401",
                    Residential = true,
                    ResidentialSpecified = true,
                    StateOrProvinceCode = "MT",
                    StreetLines = new[] { "513 27th St. North" },
                    UrbanizationCode = string.Empty
                }
            };
            
                rateRequest.RequestedShipment.Recipient = new Party
                {
                    Address = GetRecipientAddress(shoppingCart)
                };
            
            var result = rateService.getRates(rateRequest);

            if (result.HighestSeverity != NotificationSeverityType.SUCCESS)
            {
                throw new Exception($"Request: {JsonConvert.SerializeObject(rateRequest)} Result: {JsonConvert.SerializeObject(result)}");
            }

            return result.RateReplyDetails.Select(r => new ShippingRate
            {
                Currency = "USD",
                DiscountAmount = 0,
                DiscountAmountWithTax = 0,
                OptionDescription = r.ServiceType.ToString(),
                OptionName = r.ServiceType.ToString(),
                Rate = r.RatedShipmentDetails[0].ShipmentRateDetail.TotalNetCharge.Amount,
                RateWithTax = r.RatedShipmentDetails[0].ShipmentRateDetail.TotalNetChargeWithDutiesAndTaxes.Amount,
                ShippingMethod = fedExShippingMethod
            });
        }

        private Integration.Address GetRecipientAddress(ShoppingCart shoppingCart)
        {
            try
            {
                var address = shoppingCart.Shipments.First().DeliveryAddress;
                return new Integration.Address
                {
                    City = address.City,
                    CountryCode = "US",
                    CountryName = address.CountryCode,
                    PostalCode = address.PostalCode,
                    Residential = true,
                    ResidentialSpecified = true,
                    StateOrProvinceCode = address.RegionId,
                    StreetLines = new[] {address.Line1},
                    UrbanizationCode = string.Empty
                };
            }
            catch (Exception e)
            {
                throw new Exception($"Shopping Cart {JsonConvert.SerializeObject(shoppingCart)}");
            }
        }

        private RateRequest CreateDefaultRateRequest(FedexWebServiceSettings settings)
        {
            return new RateRequest
            {
                ClientDetail = new ClientDetail
                {
                    AccountNumber = settings.AccountNumber,
                    IntegratorId = settings.IntegratorId,
                    MeterNumber = settings.MeterNumber,
                    Region = ExpressRegionCode.US,
                    RegionSpecified = true
                },
                RequestedShipment = new RequestedShipment
                {
                    DropoffType = DropoffType.REGULAR_PICKUP,
                    DropoffTypeSpecified = true,
                    PackagingType = PackagingType.YOUR_PACKAGING,
                    PackagingTypeSpecified = true,
                    RateRequestTypes = new [] { RateRequestType.LIST },
                },
                ReturnTransitAndCommit = false,
                ReturnTransitAndCommitSpecified = false,
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