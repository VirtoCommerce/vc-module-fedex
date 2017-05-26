﻿namespace VirtoCommerce.FedExModule.Web.Integration {
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="RateServiceSoapBinding", Namespace="http://fedex.com/ws/rate/v20")]
    public partial class RateService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getRatesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public RateService(string url)
        {
            this.Url = url;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getRatesCompletedEventHandler getRatesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://fedex.com/ws/rate/v20/getRates", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("RateReply", Namespace="http://fedex.com/ws/rate/v20")]
        public RateReply getRates([System.Xml.Serialization.XmlElementAttribute(Namespace="http://fedex.com/ws/rate/v20")] RateRequest RateRequest) {
            object[] results = this.Invoke("getRates", new object[] {
                        RateRequest});
            return ((RateReply)(results[0]));
        }
        
        /// <remarks/>
        public void getRatesAsync(RateRequest RateRequest) {
            this.getRatesAsync(RateRequest, null);
        }
        
        /// <remarks/>
        public void getRatesAsync(RateRequest RateRequest, object userState) {
            if ((this.getRatesOperationCompleted == null)) {
                this.getRatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetRatesOperationCompleted);
            }
            this.InvokeAsync("getRates", new object[] {
                        RateRequest}, this.getRatesOperationCompleted, userState);
        }
        
        private void OngetRatesOperationCompleted(object arg) {
            if ((this.getRatesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getRatesCompleted(this, new getRatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class RateRequest {
        
        private WebAuthenticationDetail webAuthenticationDetailField;
        
        private ClientDetail clientDetailField;
        
        private TransactionDetail transactionDetailField;
        
        private VersionId versionField;
        
        private bool returnTransitAndCommitField;
        
        private bool returnTransitAndCommitFieldSpecified;
        
        private CarrierCodeType[] carrierCodesField;
        
        private ServiceOptionType[] variableOptionsField;
        
        private ConsolidationKey consolidationKeyField;
        
        private RequestedShipment requestedShipmentField;
        
        /// <remarks/>
        public WebAuthenticationDetail WebAuthenticationDetail {
            get {
                return this.webAuthenticationDetailField;
            }
            set {
                this.webAuthenticationDetailField = value;
            }
        }
        
        /// <remarks/>
        public ClientDetail ClientDetail {
            get {
                return this.clientDetailField;
            }
            set {
                this.clientDetailField = value;
            }
        }
        
        /// <remarks/>
        public TransactionDetail TransactionDetail {
            get {
                return this.transactionDetailField;
            }
            set {
                this.transactionDetailField = value;
            }
        }
        
        /// <remarks/>
        public VersionId Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        public bool ReturnTransitAndCommit {
            get {
                return this.returnTransitAndCommitField;
            }
            set {
                this.returnTransitAndCommitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnTransitAndCommitSpecified {
            get {
                return this.returnTransitAndCommitFieldSpecified;
            }
            set {
                this.returnTransitAndCommitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CarrierCodes")]
        public CarrierCodeType[] CarrierCodes {
            get {
                return this.carrierCodesField;
            }
            set {
                this.carrierCodesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VariableOptions")]
        public ServiceOptionType[] VariableOptions {
            get {
                return this.variableOptionsField;
            }
            set {
                this.variableOptionsField = value;
            }
        }
        
        /// <remarks/>
        public ConsolidationKey ConsolidationKey {
            get {
                return this.consolidationKeyField;
            }
            set {
                this.consolidationKeyField = value;
            }
        }
        
        /// <remarks/>
        public RequestedShipment RequestedShipment {
            get {
                return this.requestedShipmentField;
            }
            set {
                this.requestedShipmentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class WebAuthenticationDetail {
        
        private WebAuthenticationCredential parentCredentialField;
        
        private WebAuthenticationCredential userCredentialField;
        
        /// <remarks/>
        public WebAuthenticationCredential ParentCredential {
            get {
                return this.parentCredentialField;
            }
            set {
                this.parentCredentialField = value;
            }
        }
        
        /// <remarks/>
        public WebAuthenticationCredential UserCredential {
            get {
                return this.userCredentialField;
            }
            set {
                this.userCredentialField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class WebAuthenticationCredential {
        
        private string keyField;
        
        private string passwordField;
        
        /// <remarks/>
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class PackageRateDetail {
        
        private ReturnedRateType rateTypeField;
        
        private bool rateTypeFieldSpecified;
        
        private RatedWeightMethod ratedWeightMethodField;
        
        private bool ratedWeightMethodFieldSpecified;
        
        private MinimumChargeType minimumChargeTypeField;
        
        private bool minimumChargeTypeFieldSpecified;
        
        private Weight billingWeightField;
        
        private Weight dimWeightField;
        
        private Weight oversizeWeightField;
        
        private Money baseChargeField;
        
        private Money totalFreightDiscountsField;
        
        private Money netFreightField;
        
        private Money totalSurchargesField;
        
        private Money netFedExChargeField;
        
        private Money totalTaxesField;
        
        private Money netChargeField;
        
        private Money totalRebatesField;
        
        private RateDiscount[] freightDiscountsField;
        
        private Rebate[] rebatesField;
        
        private Surcharge[] surchargesField;
        
        private Tax[] taxesField;
        
        private VariableHandlingCharges variableHandlingChargesField;
        
        /// <remarks/>
        public ReturnedRateType RateType {
            get {
                return this.rateTypeField;
            }
            set {
                this.rateTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateTypeSpecified {
            get {
                return this.rateTypeFieldSpecified;
            }
            set {
                this.rateTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public RatedWeightMethod RatedWeightMethod {
            get {
                return this.ratedWeightMethodField;
            }
            set {
                this.ratedWeightMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RatedWeightMethodSpecified {
            get {
                return this.ratedWeightMethodFieldSpecified;
            }
            set {
                this.ratedWeightMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public MinimumChargeType MinimumChargeType {
            get {
                return this.minimumChargeTypeField;
            }
            set {
                this.minimumChargeTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinimumChargeTypeSpecified {
            get {
                return this.minimumChargeTypeFieldSpecified;
            }
            set {
                this.minimumChargeTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Weight BillingWeight {
            get {
                return this.billingWeightField;
            }
            set {
                this.billingWeightField = value;
            }
        }
        
        /// <remarks/>
        public Weight DimWeight {
            get {
                return this.dimWeightField;
            }
            set {
                this.dimWeightField = value;
            }
        }
        
        /// <remarks/>
        public Weight OversizeWeight {
            get {
                return this.oversizeWeightField;
            }
            set {
                this.oversizeWeightField = value;
            }
        }
        
        /// <remarks/>
        public Money BaseCharge {
            get {
                return this.baseChargeField;
            }
            set {
                this.baseChargeField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalFreightDiscounts {
            get {
                return this.totalFreightDiscountsField;
            }
            set {
                this.totalFreightDiscountsField = value;
            }
        }
        
        /// <remarks/>
        public Money NetFreight {
            get {
                return this.netFreightField;
            }
            set {
                this.netFreightField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalSurcharges {
            get {
                return this.totalSurchargesField;
            }
            set {
                this.totalSurchargesField = value;
            }
        }
        
        /// <remarks/>
        public Money NetFedExCharge {
            get {
                return this.netFedExChargeField;
            }
            set {
                this.netFedExChargeField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalTaxes {
            get {
                return this.totalTaxesField;
            }
            set {
                this.totalTaxesField = value;
            }
        }
        
        /// <remarks/>
        public Money NetCharge {
            get {
                return this.netChargeField;
            }
            set {
                this.netChargeField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalRebates {
            get {
                return this.totalRebatesField;
            }
            set {
                this.totalRebatesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FreightDiscounts")]
        public RateDiscount[] FreightDiscounts {
            get {
                return this.freightDiscountsField;
            }
            set {
                this.freightDiscountsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rebates")]
        public Rebate[] Rebates {
            get {
                return this.rebatesField;
            }
            set {
                this.rebatesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Surcharges")]
        public Surcharge[] Surcharges {
            get {
                return this.surchargesField;
            }
            set {
                this.surchargesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Taxes")]
        public Tax[] Taxes {
            get {
                return this.taxesField;
            }
            set {
                this.taxesField = value;
            }
        }
        
        /// <remarks/>
        public VariableHandlingCharges VariableHandlingCharges {
            get {
                return this.variableHandlingChargesField;
            }
            set {
                this.variableHandlingChargesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ReturnedRateType {
        
        /// <remarks/>
        PAYOR_ACCOUNT_PACKAGE,
        
        /// <remarks/>
        PAYOR_ACCOUNT_SHIPMENT,
        
        /// <remarks/>
        PAYOR_LIST_PACKAGE,
        
        /// <remarks/>
        PAYOR_LIST_SHIPMENT,
        
        /// <remarks/>
        PREFERRED_ACCOUNT_PACKAGE,
        
        /// <remarks/>
        PREFERRED_ACCOUNT_SHIPMENT,
        
        /// <remarks/>
        PREFERRED_LIST_PACKAGE,
        
        /// <remarks/>
        PREFERRED_LIST_SHIPMENT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RatedWeightMethod {
        
        /// <remarks/>
        ACTUAL,
        
        /// <remarks/>
        AVERAGE_PACKAGE_WEIGHT_MINIMUM,
        
        /// <remarks/>
        BALLOON,
        
        /// <remarks/>
        DEFAULT_WEIGHT_APPLIED,
        
        /// <remarks/>
        DIM,
        
        /// <remarks/>
        FREIGHT_MINIMUM,
        
        /// <remarks/>
        MIXED,
        
        /// <remarks/>
        OVERSIZE,
        
        /// <remarks/>
        OVERSIZE_1,
        
        /// <remarks/>
        OVERSIZE_2,
        
        /// <remarks/>
        OVERSIZE_3,
        
        /// <remarks/>
        PACKAGING_MINIMUM,
        
        /// <remarks/>
        WEIGHT_BREAK,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum MinimumChargeType {
        
        /// <remarks/>
        CUSTOMER,
        
        /// <remarks/>
        CUSTOMER_FREIGHT_WEIGHT,
        
        /// <remarks/>
        EARNED_DISCOUNT,
        
        /// <remarks/>
        MIXED,
        
        /// <remarks/>
        RATE_SCALE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Weight {
        
        private WeightUnits unitsField;
        
        private bool unitsFieldSpecified;
        
        private decimal valueField;
        
        private bool valueFieldSpecified;
        
        /// <remarks/>
        public WeightUnits Units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitsSpecified {
            get {
                return this.unitsFieldSpecified;
            }
            set {
                this.unitsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueSpecified {
            get {
                return this.valueFieldSpecified;
            }
            set {
                this.valueFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum WeightUnits {
        
        /// <remarks/>
        KG,
        
        /// <remarks/>
        LB,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Money {
        
        private string currencyField;
        
        private decimal amountField;
        
        private bool amountFieldSpecified;
        
        /// <remarks/>
        public string Currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        public decimal Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified {
            get {
                return this.amountFieldSpecified;
            }
            set {
                this.amountFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class RateDiscount {
        
        private RateDiscountType rateDiscountTypeField;
        
        private bool rateDiscountTypeFieldSpecified;
        
        private string descriptionField;
        
        private Money amountField;
        
        private decimal percentField;
        
        private bool percentFieldSpecified;
        
        /// <remarks/>
        public RateDiscountType RateDiscountType {
            get {
                return this.rateDiscountTypeField;
            }
            set {
                this.rateDiscountTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateDiscountTypeSpecified {
            get {
                return this.rateDiscountTypeFieldSpecified;
            }
            set {
                this.rateDiscountTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public Money Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public decimal Percent {
            get {
                return this.percentField;
            }
            set {
                this.percentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentSpecified {
            get {
                return this.percentFieldSpecified;
            }
            set {
                this.percentFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RateDiscountType {
        
        /// <remarks/>
        BONUS,
        
        /// <remarks/>
        COUPON,
        
        /// <remarks/>
        EARNED,
        
        /// <remarks/>
        OTHER,
        
        /// <remarks/>
        VOLUME,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Rebate {
        
        private RebateType rebateTypeField;
        
        private bool rebateTypeFieldSpecified;
        
        private string descriptionField;
        
        private Money amountField;
        
        private decimal percentField;
        
        private bool percentFieldSpecified;
        
        /// <remarks/>
        public RebateType RebateType {
            get {
                return this.rebateTypeField;
            }
            set {
                this.rebateTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RebateTypeSpecified {
            get {
                return this.rebateTypeFieldSpecified;
            }
            set {
                this.rebateTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public Money Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public decimal Percent {
            get {
                return this.percentField;
            }
            set {
                this.percentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentSpecified {
            get {
                return this.percentFieldSpecified;
            }
            set {
                this.percentFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RebateType {
        
        /// <remarks/>
        BONUS,
        
        /// <remarks/>
        EARNED,
        
        /// <remarks/>
        OTHER,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Surcharge {
        
        private SurchargeType surchargeTypeField;
        
        private bool surchargeTypeFieldSpecified;
        
        private SurchargeLevelType levelField;
        
        private bool levelFieldSpecified;
        
        private string descriptionField;
        
        private Money amountField;
        
        /// <remarks/>
        public SurchargeType SurchargeType {
            get {
                return this.surchargeTypeField;
            }
            set {
                this.surchargeTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SurchargeTypeSpecified {
            get {
                return this.surchargeTypeFieldSpecified;
            }
            set {
                this.surchargeTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public SurchargeLevelType Level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LevelSpecified {
            get {
                return this.levelFieldSpecified;
            }
            set {
                this.levelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public Money Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum SurchargeType {
        
        /// <remarks/>
        ADDITIONAL_HANDLING,
        
        /// <remarks/>
        ANCILLARY_FEE,
        
        /// <remarks/>
        APPOINTMENT_DELIVERY,
        
        /// <remarks/>
        BROKER_SELECT_OPTION,
        
        /// <remarks/>
        CANADIAN_DESTINATION,
        
        /// <remarks/>
        CLEARANCE_ENTRY_FEE,
        
        /// <remarks/>
        COD,
        
        /// <remarks/>
        CUT_FLOWERS,
        
        /// <remarks/>
        DANGEROUS_GOODS,
        
        /// <remarks/>
        DELIVERY_AREA,
        
        /// <remarks/>
        DELIVERY_CONFIRMATION,
        
        /// <remarks/>
        DOCUMENTATION_FEE,
        
        /// <remarks/>
        DRY_ICE,
        
        /// <remarks/>
        EMAIL_LABEL,
        
        /// <remarks/>
        EUROPE_FIRST,
        
        /// <remarks/>
        EXCESS_VALUE,
        
        /// <remarks/>
        EXHIBITION,
        
        /// <remarks/>
        EXPORT,
        
        /// <remarks/>
        EXTRA_SURFACE_HANDLING_CHARGE,
        
        /// <remarks/>
        EXTREME_LENGTH,
        
        /// <remarks/>
        FEDEX_INTRACOUNTRY_FEES,
        
        /// <remarks/>
        FEDEX_TAG,
        
        /// <remarks/>
        FICE,
        
        /// <remarks/>
        FLATBED,
        
        /// <remarks/>
        FREIGHT_GUARANTEE,
        
        /// <remarks/>
        FREIGHT_ON_VALUE,
        
        /// <remarks/>
        FREIGHT_TO_COLLECT,
        
        /// <remarks/>
        FUEL,
        
        /// <remarks/>
        HOLD_AT_LOCATION,
        
        /// <remarks/>
        HOME_DELIVERY_APPOINTMENT,
        
        /// <remarks/>
        HOME_DELIVERY_DATE_CERTAIN,
        
        /// <remarks/>
        HOME_DELIVERY_EVENING,
        
        /// <remarks/>
        INSIDE_DELIVERY,
        
        /// <remarks/>
        INSIDE_PICKUP,
        
        /// <remarks/>
        INSURED_VALUE,
        
        /// <remarks/>
        INTERHAWAII,
        
        /// <remarks/>
        LIFTGATE_DELIVERY,
        
        /// <remarks/>
        LIFTGATE_PICKUP,
        
        /// <remarks/>
        LIMITED_ACCESS_DELIVERY,
        
        /// <remarks/>
        LIMITED_ACCESS_PICKUP,
        
        /// <remarks/>
        METRO_DELIVERY,
        
        /// <remarks/>
        METRO_PICKUP,
        
        /// <remarks/>
        NON_MACHINABLE,
        
        /// <remarks/>
        OFFSHORE,
        
        /// <remarks/>
        ON_CALL_PICKUP,
        
        /// <remarks/>
        OTHER,
        
        /// <remarks/>
        OUT_OF_DELIVERY_AREA,
        
        /// <remarks/>
        OUT_OF_PICKUP_AREA,
        
        /// <remarks/>
        OVERSIZE,
        
        /// <remarks/>
        OVER_DIMENSION,
        
        /// <remarks/>
        PIECE_COUNT_VERIFICATION,
        
        /// <remarks/>
        PRE_DELIVERY_NOTIFICATION,
        
        /// <remarks/>
        PRIORITY_ALERT,
        
        /// <remarks/>
        PROTECTION_FROM_FREEZING,
        
        /// <remarks/>
        REGIONAL_MALL_DELIVERY,
        
        /// <remarks/>
        REGIONAL_MALL_PICKUP,
        
        /// <remarks/>
        REROUTE,
        
        /// <remarks/>
        RESCHEDULE,
        
        /// <remarks/>
        RESIDENTIAL_DELIVERY,
        
        /// <remarks/>
        RESIDENTIAL_PICKUP,
        
        /// <remarks/>
        RETURN_LABEL,
        
        /// <remarks/>
        SATURDAY_DELIVERY,
        
        /// <remarks/>
        SATURDAY_PICKUP,
        
        /// <remarks/>
        SIGNATURE_OPTION,
        
        /// <remarks/>
        TARP,
        
        /// <remarks/>
        THIRD_PARTY_CONSIGNEE,
        
        /// <remarks/>
        TRANSMART_SERVICE_FEE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum SurchargeLevelType {
        
        /// <remarks/>
        PACKAGE,
        
        /// <remarks/>
        SHIPMENT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Tax {
        
        private TaxType taxTypeField;
        
        private bool taxTypeFieldSpecified;
        
        private string descriptionField;
        
        private Money amountField;
        
        /// <remarks/>
        public TaxType TaxType {
            get {
                return this.taxTypeField;
            }
            set {
                this.taxTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxTypeSpecified {
            get {
                return this.taxTypeFieldSpecified;
            }
            set {
                this.taxTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public Money Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum TaxType {
        
        /// <remarks/>
        EXPORT,
        
        /// <remarks/>
        GST,
        
        /// <remarks/>
        HST,
        
        /// <remarks/>
        INTRACOUNTRY,
        
        /// <remarks/>
        OTHER,
        
        /// <remarks/>
        PST,
        
        /// <remarks/>
        VAT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class VariableHandlingCharges {
        
        private Money variableHandlingChargeField;
        
        private Money fixedVariableHandlingChargeField;
        
        private Money percentVariableHandlingChargeField;
        
        private Money totalCustomerChargeField;
        
        /// <remarks/>
        public Money VariableHandlingCharge {
            get {
                return this.variableHandlingChargeField;
            }
            set {
                this.variableHandlingChargeField = value;
            }
        }
        
        /// <remarks/>
        public Money FixedVariableHandlingCharge {
            get {
                return this.fixedVariableHandlingChargeField;
            }
            set {
                this.fixedVariableHandlingChargeField = value;
            }
        }
        
        /// <remarks/>
        public Money PercentVariableHandlingCharge {
            get {
                return this.percentVariableHandlingChargeField;
            }
            set {
                this.percentVariableHandlingChargeField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalCustomerCharge {
            get {
                return this.totalCustomerChargeField;
            }
            set {
                this.totalCustomerChargeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class RatedPackageDetail {
        
        private TrackingId[] trackingIdsField;
        
        private string groupNumberField;
        
        private Money effectiveNetDiscountField;
        
        private Money adjustedCodCollectionAmountField;
        
        private OversizeClassType oversizeClassField;
        
        private bool oversizeClassFieldSpecified;
        
        private PackageRateDetail packageRateDetailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TrackingIds")]
        public TrackingId[] TrackingIds {
            get {
                return this.trackingIdsField;
            }
            set {
                this.trackingIdsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string GroupNumber {
            get {
                return this.groupNumberField;
            }
            set {
                this.groupNumberField = value;
            }
        }
        
        /// <remarks/>
        public Money EffectiveNetDiscount {
            get {
                return this.effectiveNetDiscountField;
            }
            set {
                this.effectiveNetDiscountField = value;
            }
        }
        
        /// <remarks/>
        public Money AdjustedCodCollectionAmount {
            get {
                return this.adjustedCodCollectionAmountField;
            }
            set {
                this.adjustedCodCollectionAmountField = value;
            }
        }
        
        /// <remarks/>
        public OversizeClassType OversizeClass {
            get {
                return this.oversizeClassField;
            }
            set {
                this.oversizeClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OversizeClassSpecified {
            get {
                return this.oversizeClassFieldSpecified;
            }
            set {
                this.oversizeClassFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PackageRateDetail PackageRateDetail {
            get {
                return this.packageRateDetailField;
            }
            set {
                this.packageRateDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class TrackingId {
        
        private TrackingIdType trackingIdTypeField;
        
        private bool trackingIdTypeFieldSpecified;
        
        private string formIdField;
        
        private string trackingNumberField;
        
        /// <remarks/>
        public TrackingIdType TrackingIdType {
            get {
                return this.trackingIdTypeField;
            }
            set {
                this.trackingIdTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TrackingIdTypeSpecified {
            get {
                return this.trackingIdTypeFieldSpecified;
            }
            set {
                this.trackingIdTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string FormId {
            get {
                return this.formIdField;
            }
            set {
                this.formIdField = value;
            }
        }
        
        /// <remarks/>
        public string TrackingNumber {
            get {
                return this.trackingNumberField;
            }
            set {
                this.trackingNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum TrackingIdType {
        
        /// <remarks/>
        EXPRESS,
        
        /// <remarks/>
        FEDEX,
        
        /// <remarks/>
        GROUND,
        
        /// <remarks/>
        USPS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum OversizeClassType {
        
        /// <remarks/>
        OVERSIZE_1,
        
        /// <remarks/>
        OVERSIZE_2,
        
        /// <remarks/>
        OVERSIZE_3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class AncillaryFeeAndTax {
        
        private AncillaryFeeAndTaxType typeField;
        
        private bool typeFieldSpecified;
        
        private string descriptionField;
        
        private Money amountField;
        
        /// <remarks/>
        public AncillaryFeeAndTaxType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public Money Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum AncillaryFeeAndTaxType {
        
        /// <remarks/>
        CLEARANCE_ENTRY_FEE,
        
        /// <remarks/>
        GOODS_AND_SERVICES_TAX,
        
        /// <remarks/>
        HARMONIZED_SALES_TAX,
        
        /// <remarks/>
        OTHER,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class EdtTaxDetail {
        
        private EdtTaxType taxTypeField;
        
        private bool taxTypeFieldSpecified;
        
        private System.DateTime effectiveDateField;
        
        private bool effectiveDateFieldSpecified;
        
        private string nameField;
        
        private Money taxableValueField;
        
        private string descriptionField;
        
        private string formulaField;
        
        private Money amountField;
        
        /// <remarks/>
        public EdtTaxType TaxType {
            get {
                return this.taxTypeField;
            }
            set {
                this.taxTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxTypeSpecified {
            get {
                return this.taxTypeFieldSpecified;
            }
            set {
                this.taxTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime EffectiveDate {
            get {
                return this.effectiveDateField;
            }
            set {
                this.effectiveDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EffectiveDateSpecified {
            get {
                return this.effectiveDateFieldSpecified;
            }
            set {
                this.effectiveDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public Money TaxableValue {
            get {
                return this.taxableValueField;
            }
            set {
                this.taxableValueField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string Formula {
            get {
                return this.formulaField;
            }
            set {
                this.formulaField = value;
            }
        }
        
        /// <remarks/>
        public Money Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum EdtTaxType {
        
        /// <remarks/>
        ADDITIONAL_TAXES,
        
        /// <remarks/>
        CONSULAR_INVOICE_FEE,
        
        /// <remarks/>
        CUSTOMS_SURCHARGES,
        
        /// <remarks/>
        DUTY,
        
        /// <remarks/>
        EXCISE_TAX,
        
        /// <remarks/>
        FOREIGN_EXCHANGE_TAX,
        
        /// <remarks/>
        GENERAL_SALES_TAX,
        
        /// <remarks/>
        IMPORT_LICENSE_FEE,
        
        /// <remarks/>
        INTERNAL_ADDITIONAL_TAXES,
        
        /// <remarks/>
        INTERNAL_SENSITIVE_PRODUCTS_TAX,
        
        /// <remarks/>
        OTHER,
        
        /// <remarks/>
        SENSITIVE_PRODUCTS_TAX,
        
        /// <remarks/>
        STAMP_TAX,
        
        /// <remarks/>
        STATISTICAL_TAX,
        
        /// <remarks/>
        TRANSPORT_FACILITIES_TAX,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class EdtCommodityTax {
        
        private string harmonizedCodeField;
        
        private EdtTaxDetail[] taxesField;
        
        /// <remarks/>
        public string HarmonizedCode {
            get {
                return this.harmonizedCodeField;
            }
            set {
                this.harmonizedCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Taxes")]
        public EdtTaxDetail[] Taxes {
            get {
                return this.taxesField;
            }
            set {
                this.taxesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class FreightRateNotation {
        
        private string codeField;
        
        private string descriptionField;
        
        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class FreightBaseCharge {
        
        private FreightClassType freightClassField;
        
        private bool freightClassFieldSpecified;
        
        private FreightClassType ratedAsClassField;
        
        private bool ratedAsClassFieldSpecified;
        
        private string nmfcCodeField;
        
        private string descriptionField;
        
        private Weight weightField;
        
        private Money chargeRateField;
        
        private FreightChargeBasisType chargeBasisField;
        
        private bool chargeBasisFieldSpecified;
        
        private Money extendedAmountField;
        
        /// <remarks/>
        public FreightClassType FreightClass {
            get {
                return this.freightClassField;
            }
            set {
                this.freightClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FreightClassSpecified {
            get {
                return this.freightClassFieldSpecified;
            }
            set {
                this.freightClassFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public FreightClassType RatedAsClass {
            get {
                return this.ratedAsClassField;
            }
            set {
                this.ratedAsClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RatedAsClassSpecified {
            get {
                return this.ratedAsClassFieldSpecified;
            }
            set {
                this.ratedAsClassFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string NmfcCode {
            get {
                return this.nmfcCodeField;
            }
            set {
                this.nmfcCodeField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public Weight Weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }
        
        /// <remarks/>
        public Money ChargeRate {
            get {
                return this.chargeRateField;
            }
            set {
                this.chargeRateField = value;
            }
        }
        
        /// <remarks/>
        public FreightChargeBasisType ChargeBasis {
            get {
                return this.chargeBasisField;
            }
            set {
                this.chargeBasisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChargeBasisSpecified {
            get {
                return this.chargeBasisFieldSpecified;
            }
            set {
                this.chargeBasisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money ExtendedAmount {
            get {
                return this.extendedAmountField;
            }
            set {
                this.extendedAmountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum FreightClassType {
        
        /// <remarks/>
        CLASS_050,
        
        /// <remarks/>
        CLASS_055,
        
        /// <remarks/>
        CLASS_060,
        
        /// <remarks/>
        CLASS_065,
        
        /// <remarks/>
        CLASS_070,
        
        /// <remarks/>
        CLASS_077_5,
        
        /// <remarks/>
        CLASS_085,
        
        /// <remarks/>
        CLASS_092_5,
        
        /// <remarks/>
        CLASS_100,
        
        /// <remarks/>
        CLASS_110,
        
        /// <remarks/>
        CLASS_125,
        
        /// <remarks/>
        CLASS_150,
        
        /// <remarks/>
        CLASS_175,
        
        /// <remarks/>
        CLASS_200,
        
        /// <remarks/>
        CLASS_250,
        
        /// <remarks/>
        CLASS_300,
        
        /// <remarks/>
        CLASS_400,
        
        /// <remarks/>
        CLASS_500,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum FreightChargeBasisType {
        
        /// <remarks/>
        CWT,
        
        /// <remarks/>
        FLAT,
        
        /// <remarks/>
        MINIMUM,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class FreightRateDetail {
        
        private string quoteNumberField;
        
        private FreightRateQuoteType quoteTypeField;
        
        private bool quoteTypeFieldSpecified;
        
        private FreightBaseChargeCalculationType baseChargeCalculationField;
        
        private bool baseChargeCalculationFieldSpecified;
        
        private FreightBaseCharge[] baseChargesField;
        
        private FreightRateNotation[] notationsField;
        
        /// <remarks/>
        public string QuoteNumber {
            get {
                return this.quoteNumberField;
            }
            set {
                this.quoteNumberField = value;
            }
        }
        
        /// <remarks/>
        public FreightRateQuoteType QuoteType {
            get {
                return this.quoteTypeField;
            }
            set {
                this.quoteTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuoteTypeSpecified {
            get {
                return this.quoteTypeFieldSpecified;
            }
            set {
                this.quoteTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public FreightBaseChargeCalculationType BaseChargeCalculation {
            get {
                return this.baseChargeCalculationField;
            }
            set {
                this.baseChargeCalculationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BaseChargeCalculationSpecified {
            get {
                return this.baseChargeCalculationFieldSpecified;
            }
            set {
                this.baseChargeCalculationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BaseCharges")]
        public FreightBaseCharge[] BaseCharges {
            get {
                return this.baseChargesField;
            }
            set {
                this.baseChargesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Notations")]
        public FreightRateNotation[] Notations {
            get {
                return this.notationsField;
            }
            set {
                this.notationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum FreightRateQuoteType {
        
        /// <remarks/>
        AUTOMATED,
        
        /// <remarks/>
        MANUAL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum FreightBaseChargeCalculationType {
        
        /// <remarks/>
        LINE_ITEMS,
        
        /// <remarks/>
        UNIT_PRICING,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShipmentLegRateDetail {
        
        private string legDescriptionField;
        
        private Address legOriginField;
        
        private string legOriginLocationIdField;
        
        private Address legDestinationField;
        
        private string legDestinationLocationIdField;
        
        private ReturnedRateType rateTypeField;
        
        private bool rateTypeFieldSpecified;
        
        private string rateScaleField;
        
        private string rateZoneField;
        
        private PricingCodeType pricingCodeField;
        
        private bool pricingCodeFieldSpecified;
        
        private RatedWeightMethod ratedWeightMethodField;
        
        private bool ratedWeightMethodFieldSpecified;
        
        private MinimumChargeType minimumChargeTypeField;
        
        private bool minimumChargeTypeFieldSpecified;
        
        private CurrencyExchangeRate currencyExchangeRateField;
        
        private SpecialRatingAppliedType[] specialRatingAppliedField;
        
        private string dimDivisorField;
        
        private RateDimensionalDivisorType dimDivisorTypeField;
        
        private bool dimDivisorTypeFieldSpecified;
        
        private decimal fuelSurchargePercentField;
        
        private bool fuelSurchargePercentFieldSpecified;
        
        private Weight totalBillingWeightField;
        
        private Weight totalDimWeightField;
        
        private Money totalBaseChargeField;
        
        private Money totalFreightDiscountsField;
        
        private Money totalNetFreightField;
        
        private Money totalSurchargesField;
        
        private Money totalNetFedExChargeField;
        
        private Money totalTaxesField;
        
        private Money totalNetChargeField;
        
        private Money totalRebatesField;
        
        private Money totalDutiesAndTaxesField;
        
        private Money totalNetChargeWithDutiesAndTaxesField;
        
        private FreightRateDetail freightRateDetailField;
        
        private RateDiscount[] freightDiscountsField;
        
        private Rebate[] rebatesField;
        
        private Surcharge[] surchargesField;
        
        private Tax[] taxesField;
        
        private EdtCommodityTax[] dutiesAndTaxesField;
        
        private VariableHandlingCharges variableHandlingChargesField;
        
        private VariableHandlingCharges totalVariableHandlingChargesField;
        
        /// <remarks/>
        public string LegDescription {
            get {
                return this.legDescriptionField;
            }
            set {
                this.legDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public Address LegOrigin {
            get {
                return this.legOriginField;
            }
            set {
                this.legOriginField = value;
            }
        }
        
        /// <remarks/>
        public string LegOriginLocationId {
            get {
                return this.legOriginLocationIdField;
            }
            set {
                this.legOriginLocationIdField = value;
            }
        }
        
        /// <remarks/>
        public Address LegDestination {
            get {
                return this.legDestinationField;
            }
            set {
                this.legDestinationField = value;
            }
        }
        
        /// <remarks/>
        public string LegDestinationLocationId {
            get {
                return this.legDestinationLocationIdField;
            }
            set {
                this.legDestinationLocationIdField = value;
            }
        }
        
        /// <remarks/>
        public ReturnedRateType RateType {
            get {
                return this.rateTypeField;
            }
            set {
                this.rateTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateTypeSpecified {
            get {
                return this.rateTypeFieldSpecified;
            }
            set {
                this.rateTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string RateScale {
            get {
                return this.rateScaleField;
            }
            set {
                this.rateScaleField = value;
            }
        }
        
        /// <remarks/>
        public string RateZone {
            get {
                return this.rateZoneField;
            }
            set {
                this.rateZoneField = value;
            }
        }
        
        /// <remarks/>
        public PricingCodeType PricingCode {
            get {
                return this.pricingCodeField;
            }
            set {
                this.pricingCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PricingCodeSpecified {
            get {
                return this.pricingCodeFieldSpecified;
            }
            set {
                this.pricingCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public RatedWeightMethod RatedWeightMethod {
            get {
                return this.ratedWeightMethodField;
            }
            set {
                this.ratedWeightMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RatedWeightMethodSpecified {
            get {
                return this.ratedWeightMethodFieldSpecified;
            }
            set {
                this.ratedWeightMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public MinimumChargeType MinimumChargeType {
            get {
                return this.minimumChargeTypeField;
            }
            set {
                this.minimumChargeTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinimumChargeTypeSpecified {
            get {
                return this.minimumChargeTypeFieldSpecified;
            }
            set {
                this.minimumChargeTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CurrencyExchangeRate CurrencyExchangeRate {
            get {
                return this.currencyExchangeRateField;
            }
            set {
                this.currencyExchangeRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialRatingApplied")]
        public SpecialRatingAppliedType[] SpecialRatingApplied {
            get {
                return this.specialRatingAppliedField;
            }
            set {
                this.specialRatingAppliedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string DimDivisor {
            get {
                return this.dimDivisorField;
            }
            set {
                this.dimDivisorField = value;
            }
        }
        
        /// <remarks/>
        public RateDimensionalDivisorType DimDivisorType {
            get {
                return this.dimDivisorTypeField;
            }
            set {
                this.dimDivisorTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DimDivisorTypeSpecified {
            get {
                return this.dimDivisorTypeFieldSpecified;
            }
            set {
                this.dimDivisorTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal FuelSurchargePercent {
            get {
                return this.fuelSurchargePercentField;
            }
            set {
                this.fuelSurchargePercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FuelSurchargePercentSpecified {
            get {
                return this.fuelSurchargePercentFieldSpecified;
            }
            set {
                this.fuelSurchargePercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Weight TotalBillingWeight {
            get {
                return this.totalBillingWeightField;
            }
            set {
                this.totalBillingWeightField = value;
            }
        }
        
        /// <remarks/>
        public Weight TotalDimWeight {
            get {
                return this.totalDimWeightField;
            }
            set {
                this.totalDimWeightField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalBaseCharge {
            get {
                return this.totalBaseChargeField;
            }
            set {
                this.totalBaseChargeField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalFreightDiscounts {
            get {
                return this.totalFreightDiscountsField;
            }
            set {
                this.totalFreightDiscountsField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalNetFreight {
            get {
                return this.totalNetFreightField;
            }
            set {
                this.totalNetFreightField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalSurcharges {
            get {
                return this.totalSurchargesField;
            }
            set {
                this.totalSurchargesField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalNetFedExCharge {
            get {
                return this.totalNetFedExChargeField;
            }
            set {
                this.totalNetFedExChargeField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalTaxes {
            get {
                return this.totalTaxesField;
            }
            set {
                this.totalTaxesField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalNetCharge {
            get {
                return this.totalNetChargeField;
            }
            set {
                this.totalNetChargeField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalRebates {
            get {
                return this.totalRebatesField;
            }
            set {
                this.totalRebatesField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalDutiesAndTaxes {
            get {
                return this.totalDutiesAndTaxesField;
            }
            set {
                this.totalDutiesAndTaxesField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalNetChargeWithDutiesAndTaxes {
            get {
                return this.totalNetChargeWithDutiesAndTaxesField;
            }
            set {
                this.totalNetChargeWithDutiesAndTaxesField = value;
            }
        }
        
        /// <remarks/>
        public FreightRateDetail FreightRateDetail {
            get {
                return this.freightRateDetailField;
            }
            set {
                this.freightRateDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FreightDiscounts")]
        public RateDiscount[] FreightDiscounts {
            get {
                return this.freightDiscountsField;
            }
            set {
                this.freightDiscountsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rebates")]
        public Rebate[] Rebates {
            get {
                return this.rebatesField;
            }
            set {
                this.rebatesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Surcharges")]
        public Surcharge[] Surcharges {
            get {
                return this.surchargesField;
            }
            set {
                this.surchargesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Taxes")]
        public Tax[] Taxes {
            get {
                return this.taxesField;
            }
            set {
                this.taxesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DutiesAndTaxes")]
        public EdtCommodityTax[] DutiesAndTaxes {
            get {
                return this.dutiesAndTaxesField;
            }
            set {
                this.dutiesAndTaxesField = value;
            }
        }
        
        /// <remarks/>
        public VariableHandlingCharges VariableHandlingCharges {
            get {
                return this.variableHandlingChargesField;
            }
            set {
                this.variableHandlingChargesField = value;
            }
        }
        
        /// <remarks/>
        public VariableHandlingCharges TotalVariableHandlingCharges {
            get {
                return this.totalVariableHandlingChargesField;
            }
            set {
                this.totalVariableHandlingChargesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Address {
        
        private string[] streetLinesField;
        
        private string cityField;
        
        private string stateOrProvinceCodeField;
        
        private string postalCodeField;
        
        private string urbanizationCodeField;
        
        private string countryCodeField;
        
        private string countryNameField;
        
        private bool residentialField;
        
        private bool residentialFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StreetLines")]
        public string[] StreetLines {
            get {
                return this.streetLinesField;
            }
            set {
                this.streetLinesField = value;
            }
        }
        
        /// <remarks/>
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string StateOrProvinceCode {
            get {
                return this.stateOrProvinceCodeField;
            }
            set {
                this.stateOrProvinceCodeField = value;
            }
        }
        
        /// <remarks/>
        public string PostalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        public string UrbanizationCode {
            get {
                return this.urbanizationCodeField;
            }
            set {
                this.urbanizationCodeField = value;
            }
        }
        
        /// <remarks/>
        public string CountryCode {
            get {
                return this.countryCodeField;
            }
            set {
                this.countryCodeField = value;
            }
        }
        
        /// <remarks/>
        public string CountryName {
            get {
                return this.countryNameField;
            }
            set {
                this.countryNameField = value;
            }
        }
        
        /// <remarks/>
        public bool Residential {
            get {
                return this.residentialField;
            }
            set {
                this.residentialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidentialSpecified {
            get {
                return this.residentialFieldSpecified;
            }
            set {
                this.residentialFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum PricingCodeType {
        
        /// <remarks/>
        ACTUAL,
        
        /// <remarks/>
        ALTERNATE,
        
        /// <remarks/>
        BASE,
        
        /// <remarks/>
        HUNDREDWEIGHT,
        
        /// <remarks/>
        HUNDREDWEIGHT_ALTERNATE,
        
        /// <remarks/>
        INTERNATIONAL_DISTRIBUTION,
        
        /// <remarks/>
        INTERNATIONAL_ECONOMY_SERVICE,
        
        /// <remarks/>
        LTL_FREIGHT,
        
        /// <remarks/>
        PACKAGE,
        
        /// <remarks/>
        SHIPMENT,
        
        /// <remarks/>
        SHIPMENT_FIVE_POUND_OPTIONAL,
        
        /// <remarks/>
        SHIPMENT_OPTIONAL,
        
        /// <remarks/>
        SPECIAL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CurrencyExchangeRate {
        
        private string fromCurrencyField;
        
        private string intoCurrencyField;
        
        private decimal rateField;
        
        private bool rateFieldSpecified;
        
        /// <remarks/>
        public string FromCurrency {
            get {
                return this.fromCurrencyField;
            }
            set {
                this.fromCurrencyField = value;
            }
        }
        
        /// <remarks/>
        public string IntoCurrency {
            get {
                return this.intoCurrencyField;
            }
            set {
                this.intoCurrencyField = value;
            }
        }
        
        /// <remarks/>
        public decimal Rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateSpecified {
            get {
                return this.rateFieldSpecified;
            }
            set {
                this.rateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum SpecialRatingAppliedType {
        
        /// <remarks/>
        FEDEX_ONE_RATE,
        
        /// <remarks/>
        FIXED_FUEL_SURCHARGE,
        
        /// <remarks/>
        IMPORT_PRICING,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RateDimensionalDivisorType {
        
        /// <remarks/>
        COUNTRY,
        
        /// <remarks/>
        CUSTOMER,
        
        /// <remarks/>
        OTHER,
        
        /// <remarks/>
        PRODUCT,
        
        /// <remarks/>
        WAIVED,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShipmentRateDetail {
        
        private ReturnedRateType rateTypeField;
        
        private bool rateTypeFieldSpecified;
        
        private string rateScaleField;
        
        private string rateZoneField;
        
        private PricingCodeType pricingCodeField;
        
        private bool pricingCodeFieldSpecified;
        
        private RatedWeightMethod ratedWeightMethodField;
        
        private bool ratedWeightMethodFieldSpecified;
        
        private MinimumChargeType minimumChargeTypeField;
        
        private bool minimumChargeTypeFieldSpecified;
        
        private CurrencyExchangeRate currencyExchangeRateField;
        
        private SpecialRatingAppliedType[] specialRatingAppliedField;
        
        private string dimDivisorField;
        
        private RateDimensionalDivisorType dimDivisorTypeField;
        
        private bool dimDivisorTypeFieldSpecified;
        
        private decimal fuelSurchargePercentField;
        
        private bool fuelSurchargePercentFieldSpecified;
        
        private Weight totalBillingWeightField;
        
        private Weight totalDimWeightField;
        
        private Money totalBaseChargeField;
        
        private Money totalFreightDiscountsField;
        
        private Money totalNetFreightField;
        
        private Money totalSurchargesField;
        
        private Money totalNetFedExChargeField;
        
        private Money totalTaxesField;
        
        private Money totalNetChargeField;
        
        private Money totalRebatesField;
        
        private Money totalDutiesAndTaxesField;
        
        private Money totalAncillaryFeesAndTaxesField;
        
        private Money totalDutiesTaxesAndFeesField;
        
        private Money totalNetChargeWithDutiesAndTaxesField;
        
        private ShipmentLegRateDetail[] shipmentLegRateDetailsField;
        
        private FreightRateDetail freightRateDetailField;
        
        private RateDiscount[] freightDiscountsField;
        
        private Rebate[] rebatesField;
        
        private Surcharge[] surchargesField;
        
        private Tax[] taxesField;
        
        private EdtCommodityTax[] dutiesAndTaxesField;
        
        private AncillaryFeeAndTax[] ancillaryFeesAndTaxesField;
        
        private VariableHandlingCharges variableHandlingChargesField;
        
        private VariableHandlingCharges totalVariableHandlingChargesField;
        
        /// <remarks/>
        public ReturnedRateType RateType {
            get {
                return this.rateTypeField;
            }
            set {
                this.rateTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateTypeSpecified {
            get {
                return this.rateTypeFieldSpecified;
            }
            set {
                this.rateTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string RateScale {
            get {
                return this.rateScaleField;
            }
            set {
                this.rateScaleField = value;
            }
        }
        
        /// <remarks/>
        public string RateZone {
            get {
                return this.rateZoneField;
            }
            set {
                this.rateZoneField = value;
            }
        }
        
        /// <remarks/>
        public PricingCodeType PricingCode {
            get {
                return this.pricingCodeField;
            }
            set {
                this.pricingCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PricingCodeSpecified {
            get {
                return this.pricingCodeFieldSpecified;
            }
            set {
                this.pricingCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public RatedWeightMethod RatedWeightMethod {
            get {
                return this.ratedWeightMethodField;
            }
            set {
                this.ratedWeightMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RatedWeightMethodSpecified {
            get {
                return this.ratedWeightMethodFieldSpecified;
            }
            set {
                this.ratedWeightMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public MinimumChargeType MinimumChargeType {
            get {
                return this.minimumChargeTypeField;
            }
            set {
                this.minimumChargeTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinimumChargeTypeSpecified {
            get {
                return this.minimumChargeTypeFieldSpecified;
            }
            set {
                this.minimumChargeTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CurrencyExchangeRate CurrencyExchangeRate {
            get {
                return this.currencyExchangeRateField;
            }
            set {
                this.currencyExchangeRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialRatingApplied")]
        public SpecialRatingAppliedType[] SpecialRatingApplied {
            get {
                return this.specialRatingAppliedField;
            }
            set {
                this.specialRatingAppliedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string DimDivisor {
            get {
                return this.dimDivisorField;
            }
            set {
                this.dimDivisorField = value;
            }
        }
        
        /// <remarks/>
        public RateDimensionalDivisorType DimDivisorType {
            get {
                return this.dimDivisorTypeField;
            }
            set {
                this.dimDivisorTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DimDivisorTypeSpecified {
            get {
                return this.dimDivisorTypeFieldSpecified;
            }
            set {
                this.dimDivisorTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal FuelSurchargePercent {
            get {
                return this.fuelSurchargePercentField;
            }
            set {
                this.fuelSurchargePercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FuelSurchargePercentSpecified {
            get {
                return this.fuelSurchargePercentFieldSpecified;
            }
            set {
                this.fuelSurchargePercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Weight TotalBillingWeight {
            get {
                return this.totalBillingWeightField;
            }
            set {
                this.totalBillingWeightField = value;
            }
        }
        
        /// <remarks/>
        public Weight TotalDimWeight {
            get {
                return this.totalDimWeightField;
            }
            set {
                this.totalDimWeightField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalBaseCharge {
            get {
                return this.totalBaseChargeField;
            }
            set {
                this.totalBaseChargeField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalFreightDiscounts {
            get {
                return this.totalFreightDiscountsField;
            }
            set {
                this.totalFreightDiscountsField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalNetFreight {
            get {
                return this.totalNetFreightField;
            }
            set {
                this.totalNetFreightField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalSurcharges {
            get {
                return this.totalSurchargesField;
            }
            set {
                this.totalSurchargesField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalNetFedExCharge {
            get {
                return this.totalNetFedExChargeField;
            }
            set {
                this.totalNetFedExChargeField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalTaxes {
            get {
                return this.totalTaxesField;
            }
            set {
                this.totalTaxesField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalNetCharge {
            get {
                return this.totalNetChargeField;
            }
            set {
                this.totalNetChargeField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalRebates {
            get {
                return this.totalRebatesField;
            }
            set {
                this.totalRebatesField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalDutiesAndTaxes {
            get {
                return this.totalDutiesAndTaxesField;
            }
            set {
                this.totalDutiesAndTaxesField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalAncillaryFeesAndTaxes {
            get {
                return this.totalAncillaryFeesAndTaxesField;
            }
            set {
                this.totalAncillaryFeesAndTaxesField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalDutiesTaxesAndFees {
            get {
                return this.totalDutiesTaxesAndFeesField;
            }
            set {
                this.totalDutiesTaxesAndFeesField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalNetChargeWithDutiesAndTaxes {
            get {
                return this.totalNetChargeWithDutiesAndTaxesField;
            }
            set {
                this.totalNetChargeWithDutiesAndTaxesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentLegRateDetails")]
        public ShipmentLegRateDetail[] ShipmentLegRateDetails {
            get {
                return this.shipmentLegRateDetailsField;
            }
            set {
                this.shipmentLegRateDetailsField = value;
            }
        }
        
        /// <remarks/>
        public FreightRateDetail FreightRateDetail {
            get {
                return this.freightRateDetailField;
            }
            set {
                this.freightRateDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FreightDiscounts")]
        public RateDiscount[] FreightDiscounts {
            get {
                return this.freightDiscountsField;
            }
            set {
                this.freightDiscountsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rebates")]
        public Rebate[] Rebates {
            get {
                return this.rebatesField;
            }
            set {
                this.rebatesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Surcharges")]
        public Surcharge[] Surcharges {
            get {
                return this.surchargesField;
            }
            set {
                this.surchargesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Taxes")]
        public Tax[] Taxes {
            get {
                return this.taxesField;
            }
            set {
                this.taxesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DutiesAndTaxes")]
        public EdtCommodityTax[] DutiesAndTaxes {
            get {
                return this.dutiesAndTaxesField;
            }
            set {
                this.dutiesAndTaxesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AncillaryFeesAndTaxes")]
        public AncillaryFeeAndTax[] AncillaryFeesAndTaxes {
            get {
                return this.ancillaryFeesAndTaxesField;
            }
            set {
                this.ancillaryFeesAndTaxesField = value;
            }
        }
        
        /// <remarks/>
        public VariableHandlingCharges VariableHandlingCharges {
            get {
                return this.variableHandlingChargesField;
            }
            set {
                this.variableHandlingChargesField = value;
            }
        }
        
        /// <remarks/>
        public VariableHandlingCharges TotalVariableHandlingCharges {
            get {
                return this.totalVariableHandlingChargesField;
            }
            set {
                this.totalVariableHandlingChargesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class RatedShipmentDetail {
        
        private Money effectiveNetDiscountField;
        
        private Money adjustedCodCollectionAmountField;
        
        private ShipmentRateDetail shipmentRateDetailField;
        
        private RatedPackageDetail[] ratedPackagesField;
        
        /// <remarks/>
        public Money EffectiveNetDiscount {
            get {
                return this.effectiveNetDiscountField;
            }
            set {
                this.effectiveNetDiscountField = value;
            }
        }
        
        /// <remarks/>
        public Money AdjustedCodCollectionAmount {
            get {
                return this.adjustedCodCollectionAmountField;
            }
            set {
                this.adjustedCodCollectionAmountField = value;
            }
        }
        
        /// <remarks/>
        public ShipmentRateDetail ShipmentRateDetail {
            get {
                return this.shipmentRateDetailField;
            }
            set {
                this.shipmentRateDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RatedPackages")]
        public RatedPackageDetail[] RatedPackages {
            get {
                return this.ratedPackagesField;
            }
            set {
                this.ratedPackagesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Distance {
        
        private decimal valueField;
        
        private bool valueFieldSpecified;
        
        private DistanceUnits unitsField;
        
        private bool unitsFieldSpecified;
        
        /// <remarks/>
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueSpecified {
            get {
                return this.valueFieldSpecified;
            }
            set {
                this.valueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DistanceUnits Units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitsSpecified {
            get {
                return this.unitsFieldSpecified;
            }
            set {
                this.unitsFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum DistanceUnits {
        
        /// <remarks/>
        KM,
        
        /// <remarks/>
        MI,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class FreightServiceCenterDetail {
        
        private string interlineCarrierCodeField;
        
        private string interlineCarrierNameField;
        
        private int additionalDaysField;
        
        private bool additionalDaysFieldSpecified;
        
        private ServiceType localServiceField;
        
        private bool localServiceFieldSpecified;
        
        private Distance localDistanceField;
        
        private string localDurationField;
        
        private FreightServiceSchedulingType localServiceSchedulingField;
        
        private bool localServiceSchedulingFieldSpecified;
        
        private DayOfWeekType[] limitedServiceDaysField;
        
        private string gatewayLocationIdField;
        
        private string locationField;
        
        private ContactAndAddress contactAndAddressField;
        
        /// <remarks/>
        public string InterlineCarrierCode {
            get {
                return this.interlineCarrierCodeField;
            }
            set {
                this.interlineCarrierCodeField = value;
            }
        }
        
        /// <remarks/>
        public string InterlineCarrierName {
            get {
                return this.interlineCarrierNameField;
            }
            set {
                this.interlineCarrierNameField = value;
            }
        }
        
        /// <remarks/>
        public int AdditionalDays {
            get {
                return this.additionalDaysField;
            }
            set {
                this.additionalDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdditionalDaysSpecified {
            get {
                return this.additionalDaysFieldSpecified;
            }
            set {
                this.additionalDaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ServiceType LocalService {
            get {
                return this.localServiceField;
            }
            set {
                this.localServiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LocalServiceSpecified {
            get {
                return this.localServiceFieldSpecified;
            }
            set {
                this.localServiceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Distance LocalDistance {
            get {
                return this.localDistanceField;
            }
            set {
                this.localDistanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string LocalDuration {
            get {
                return this.localDurationField;
            }
            set {
                this.localDurationField = value;
            }
        }
        
        /// <remarks/>
        public FreightServiceSchedulingType LocalServiceScheduling {
            get {
                return this.localServiceSchedulingField;
            }
            set {
                this.localServiceSchedulingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LocalServiceSchedulingSpecified {
            get {
                return this.localServiceSchedulingFieldSpecified;
            }
            set {
                this.localServiceSchedulingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LimitedServiceDays")]
        public DayOfWeekType[] LimitedServiceDays {
            get {
                return this.limitedServiceDaysField;
            }
            set {
                this.limitedServiceDaysField = value;
            }
        }
        
        /// <remarks/>
        public string GatewayLocationId {
            get {
                return this.gatewayLocationIdField;
            }
            set {
                this.gatewayLocationIdField = value;
            }
        }
        
        /// <remarks/>
        public string Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
        
        /// <remarks/>
        public ContactAndAddress ContactAndAddress {
            get {
                return this.contactAndAddressField;
            }
            set {
                this.contactAndAddressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ServiceType {
        
        /// <remarks/>
        EUROPE_FIRST_INTERNATIONAL_PRIORITY,
        
        /// <remarks/>
        FEDEX_1_DAY_FREIGHT,
        
        /// <remarks/>
        FEDEX_2_DAY,
        
        /// <remarks/>
        FEDEX_2_DAY_AM,
        
        /// <remarks/>
        FEDEX_2_DAY_FREIGHT,
        
        /// <remarks/>
        FEDEX_3_DAY_FREIGHT,
        
        /// <remarks/>
        FEDEX_DISTANCE_DEFERRED,
        
        /// <remarks/>
        FEDEX_EXPRESS_SAVER,
        
        /// <remarks/>
        FEDEX_FIRST_FREIGHT,
        
        /// <remarks/>
        FEDEX_FREIGHT_ECONOMY,
        
        /// <remarks/>
        FEDEX_FREIGHT_PRIORITY,
        
        /// <remarks/>
        FEDEX_GROUND,
        
        /// <remarks/>
        FEDEX_NEXT_DAY_AFTERNOON,
        
        /// <remarks/>
        FEDEX_NEXT_DAY_EARLY_MORNING,
        
        /// <remarks/>
        FEDEX_NEXT_DAY_END_OF_DAY,
        
        /// <remarks/>
        FEDEX_NEXT_DAY_FREIGHT,
        
        /// <remarks/>
        FEDEX_NEXT_DAY_MID_MORNING,
        
        /// <remarks/>
        FIRST_OVERNIGHT,
        
        /// <remarks/>
        GROUND_HOME_DELIVERY,
        
        /// <remarks/>
        INTERNATIONAL_ECONOMY,
        
        /// <remarks/>
        INTERNATIONAL_ECONOMY_FREIGHT,
        
        /// <remarks/>
        INTERNATIONAL_FIRST,
        
        /// <remarks/>
        INTERNATIONAL_PRIORITY,
        
        /// <remarks/>
        INTERNATIONAL_PRIORITY_FREIGHT,
        
        /// <remarks/>
        PRIORITY_OVERNIGHT,
        
        /// <remarks/>
        SAME_DAY,
        
        /// <remarks/>
        SAME_DAY_CITY,
        
        /// <remarks/>
        SMART_POST,
        
        /// <remarks/>
        STANDARD_OVERNIGHT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum FreightServiceSchedulingType {
        
        /// <remarks/>
        LIMITED,
        
        /// <remarks/>
        STANDARD,
        
        /// <remarks/>
        WILL_CALL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum DayOfWeekType {
        
        /// <remarks/>
        FRI,
        
        /// <remarks/>
        MON,
        
        /// <remarks/>
        SAT,
        
        /// <remarks/>
        SUN,
        
        /// <remarks/>
        THU,
        
        /// <remarks/>
        TUE,
        
        /// <remarks/>
        WED,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ContactAndAddress {
        
        private Contact contactField;
        
        private Address addressField;
        
        /// <remarks/>
        public Contact Contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }
        
        /// <remarks/>
        public Address Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Contact {
        
        private string contactIdField;
        
        private string personNameField;
        
        private string titleField;
        
        private string companyNameField;
        
        private string phoneNumberField;
        
        private string phoneExtensionField;
        
        private string tollFreePhoneNumberField;
        
        private string pagerNumberField;
        
        private string faxNumberField;
        
        private string eMailAddressField;
        
        /// <remarks/>
        public string ContactId {
            get {
                return this.contactIdField;
            }
            set {
                this.contactIdField = value;
            }
        }
        
        /// <remarks/>
        public string PersonName {
            get {
                return this.personNameField;
            }
            set {
                this.personNameField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        public string PhoneNumber {
            get {
                return this.phoneNumberField;
            }
            set {
                this.phoneNumberField = value;
            }
        }
        
        /// <remarks/>
        public string PhoneExtension {
            get {
                return this.phoneExtensionField;
            }
            set {
                this.phoneExtensionField = value;
            }
        }
        
        /// <remarks/>
        public string TollFreePhoneNumber {
            get {
                return this.tollFreePhoneNumberField;
            }
            set {
                this.tollFreePhoneNumberField = value;
            }
        }
        
        /// <remarks/>
        public string PagerNumber {
            get {
                return this.pagerNumberField;
            }
            set {
                this.pagerNumberField = value;
            }
        }
        
        /// <remarks/>
        public string FaxNumber {
            get {
                return this.faxNumberField;
            }
            set {
                this.faxNumberField = value;
            }
        }
        
        /// <remarks/>
        public string EMailAddress {
            get {
                return this.eMailAddressField;
            }
            set {
                this.eMailAddressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class FreightCommitDetail {
        
        private FreightServiceCenterDetail originDetailField;
        
        private FreightServiceCenterDetail destinationDetailField;
        
        private Distance totalDistanceField;
        
        /// <remarks/>
        public FreightServiceCenterDetail OriginDetail {
            get {
                return this.originDetailField;
            }
            set {
                this.originDetailField = value;
            }
        }
        
        /// <remarks/>
        public FreightServiceCenterDetail DestinationDetail {
            get {
                return this.destinationDetailField;
            }
            set {
                this.destinationDetailField = value;
            }
        }
        
        /// <remarks/>
        public Distance TotalDistance {
            get {
                return this.totalDistanceField;
            }
            set {
                this.totalDistanceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class DelayDetail {
        
        private System.DateTime dateField;
        
        private bool dateFieldSpecified;
        
        private DayOfWeekType dayOfWeekField;
        
        private bool dayOfWeekFieldSpecified;
        
        private DelayLevelType levelField;
        
        private bool levelFieldSpecified;
        
        private DelayPointType pointField;
        
        private bool pointFieldSpecified;
        
        private CommitmentDelayType typeField;
        
        private bool typeFieldSpecified;
        
        private string descriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateSpecified {
            get {
                return this.dateFieldSpecified;
            }
            set {
                this.dateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DayOfWeekType DayOfWeek {
            get {
                return this.dayOfWeekField;
            }
            set {
                this.dayOfWeekField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DayOfWeekSpecified {
            get {
                return this.dayOfWeekFieldSpecified;
            }
            set {
                this.dayOfWeekFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DelayLevelType Level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LevelSpecified {
            get {
                return this.levelFieldSpecified;
            }
            set {
                this.levelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DelayPointType Point {
            get {
                return this.pointField;
            }
            set {
                this.pointField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PointSpecified {
            get {
                return this.pointFieldSpecified;
            }
            set {
                this.pointFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CommitmentDelayType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum DelayLevelType {
        
        /// <remarks/>
        CITY,
        
        /// <remarks/>
        COUNTRY,
        
        /// <remarks/>
        LOCATION,
        
        /// <remarks/>
        POSTAL_CODE,
        
        /// <remarks/>
        SERVICE_AREA,
        
        /// <remarks/>
        SERVICE_AREA_SPECIAL_SERVICE,
        
        /// <remarks/>
        SPECIAL_SERVICE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum DelayPointType {
        
        /// <remarks/>
        BROKER,
        
        /// <remarks/>
        DESTINATION,
        
        /// <remarks/>
        ORIGIN,
        
        /// <remarks/>
        ORIGIN_DESTINATION_PAIR,
        
        /// <remarks/>
        PROOF_OF_DELIVERY_POINT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum CommitmentDelayType {
        
        /// <remarks/>
        HOLIDAY,
        
        /// <remarks/>
        NON_WORKDAY,
        
        /// <remarks/>
        NO_CITY_DELIVERY,
        
        /// <remarks/>
        NO_HOLD_AT_LOCATION,
        
        /// <remarks/>
        NO_LOCATION_DELIVERY,
        
        /// <remarks/>
        NO_SERVICE_AREA_DELIVERY,
        
        /// <remarks/>
        NO_SERVICE_AREA_SPECIAL_SERVICE_DELIVERY,
        
        /// <remarks/>
        NO_SPECIAL_SERVICE_DELIVERY,
        
        /// <remarks/>
        NO_ZIP_DELIVERY,
        
        /// <remarks/>
        WEEKEND,
        
        /// <remarks/>
        WEEKEND_SPECIAL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CleansedAddressAndLocationDetail {
        
        private string countryCodeField;
        
        private string stateOrProvinceCodeField;
        
        private string postalCodeField;
        
        private string serviceAreaField;
        
        private string locationIdField;
        
        private int locationNumberField;
        
        private bool locationNumberFieldSpecified;
        
        private string airportIdField;
        
        /// <remarks/>
        public string CountryCode {
            get {
                return this.countryCodeField;
            }
            set {
                this.countryCodeField = value;
            }
        }
        
        /// <remarks/>
        public string StateOrProvinceCode {
            get {
                return this.stateOrProvinceCodeField;
            }
            set {
                this.stateOrProvinceCodeField = value;
            }
        }
        
        /// <remarks/>
        public string PostalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        public string ServiceArea {
            get {
                return this.serviceAreaField;
            }
            set {
                this.serviceAreaField = value;
            }
        }
        
        /// <remarks/>
        public string LocationId {
            get {
                return this.locationIdField;
            }
            set {
                this.locationIdField = value;
            }
        }
        
        /// <remarks/>
        public int LocationNumber {
            get {
                return this.locationNumberField;
            }
            set {
                this.locationNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LocationNumberSpecified {
            get {
                return this.locationNumberFieldSpecified;
            }
            set {
                this.locationNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string AirportId {
            get {
                return this.airportIdField;
            }
            set {
                this.airportIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CommitDetail {
        
        private string commodityNameField;
        
        private ServiceType serviceTypeField;
        
        private bool serviceTypeFieldSpecified;
        
        private ServiceOptionType[] appliedOptionsField;
        
        private ServiceSubOptionDetail appliedSubOptionsField;
        
        private SignatureOptionDetail derivedShipmentSignatureOptionField;
        
        private SignatureOptionDetail[] derivedPackageSignatureOptionsField;
        
        private CleansedAddressAndLocationDetail derivedOriginDetailField;
        
        private CleansedAddressAndLocationDetail derivedDestinationDetailField;
        
        private System.DateTime commitTimestampField;
        
        private bool commitTimestampFieldSpecified;
        
        private DayOfWeekType dayOfWeekField;
        
        private bool dayOfWeekFieldSpecified;
        
        private TransitTimeType transitTimeField;
        
        private bool transitTimeFieldSpecified;
        
        private TransitTimeType maximumTransitTimeField;
        
        private bool maximumTransitTimeFieldSpecified;
        
        private string destinationServiceAreaField;
        
        private Address brokerAddressField;
        
        private string brokerLocationIdField;
        
        private System.DateTime brokerCommitTimestampField;
        
        private bool brokerCommitTimestampFieldSpecified;
        
        private DayOfWeekType brokerCommitDayOfWeekField;
        
        private bool brokerCommitDayOfWeekFieldSpecified;
        
        private string brokerToDestinationDaysField;
        
        private System.DateTime proofOfDeliveryDateField;
        
        private bool proofOfDeliveryDateFieldSpecified;
        
        private DayOfWeekType proofOfDeliveryDayOfWeekField;
        
        private bool proofOfDeliveryDayOfWeekFieldSpecified;
        
        private Notification[] commitMessagesField;
        
        private string[] deliveryMessagesField;
        
        private DelayDetail[] delayDetailsField;
        
        private InternationalDocumentContentType documentContentField;
        
        private bool documentContentFieldSpecified;
        
        private RequiredShippingDocumentType[] requiredDocumentsField;
        
        private FreightCommitDetail freightCommitDetailField;
        
        /// <remarks/>
        public string CommodityName {
            get {
                return this.commodityNameField;
            }
            set {
                this.commodityNameField = value;
            }
        }
        
        /// <remarks/>
        public ServiceType ServiceType {
            get {
                return this.serviceTypeField;
            }
            set {
                this.serviceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServiceTypeSpecified {
            get {
                return this.serviceTypeFieldSpecified;
            }
            set {
                this.serviceTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AppliedOptions")]
        public ServiceOptionType[] AppliedOptions {
            get {
                return this.appliedOptionsField;
            }
            set {
                this.appliedOptionsField = value;
            }
        }
        
        /// <remarks/>
        public ServiceSubOptionDetail AppliedSubOptions {
            get {
                return this.appliedSubOptionsField;
            }
            set {
                this.appliedSubOptionsField = value;
            }
        }
        
        /// <remarks/>
        public SignatureOptionDetail DerivedShipmentSignatureOption {
            get {
                return this.derivedShipmentSignatureOptionField;
            }
            set {
                this.derivedShipmentSignatureOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DerivedPackageSignatureOptions")]
        public SignatureOptionDetail[] DerivedPackageSignatureOptions {
            get {
                return this.derivedPackageSignatureOptionsField;
            }
            set {
                this.derivedPackageSignatureOptionsField = value;
            }
        }
        
        /// <remarks/>
        public CleansedAddressAndLocationDetail DerivedOriginDetail {
            get {
                return this.derivedOriginDetailField;
            }
            set {
                this.derivedOriginDetailField = value;
            }
        }
        
        /// <remarks/>
        public CleansedAddressAndLocationDetail DerivedDestinationDetail {
            get {
                return this.derivedDestinationDetailField;
            }
            set {
                this.derivedDestinationDetailField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CommitTimestamp {
            get {
                return this.commitTimestampField;
            }
            set {
                this.commitTimestampField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CommitTimestampSpecified {
            get {
                return this.commitTimestampFieldSpecified;
            }
            set {
                this.commitTimestampFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DayOfWeekType DayOfWeek {
            get {
                return this.dayOfWeekField;
            }
            set {
                this.dayOfWeekField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DayOfWeekSpecified {
            get {
                return this.dayOfWeekFieldSpecified;
            }
            set {
                this.dayOfWeekFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public TransitTimeType TransitTime {
            get {
                return this.transitTimeField;
            }
            set {
                this.transitTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransitTimeSpecified {
            get {
                return this.transitTimeFieldSpecified;
            }
            set {
                this.transitTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public TransitTimeType MaximumTransitTime {
            get {
                return this.maximumTransitTimeField;
            }
            set {
                this.maximumTransitTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaximumTransitTimeSpecified {
            get {
                return this.maximumTransitTimeFieldSpecified;
            }
            set {
                this.maximumTransitTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string DestinationServiceArea {
            get {
                return this.destinationServiceAreaField;
            }
            set {
                this.destinationServiceAreaField = value;
            }
        }
        
        /// <remarks/>
        public Address BrokerAddress {
            get {
                return this.brokerAddressField;
            }
            set {
                this.brokerAddressField = value;
            }
        }
        
        /// <remarks/>
        public string BrokerLocationId {
            get {
                return this.brokerLocationIdField;
            }
            set {
                this.brokerLocationIdField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime BrokerCommitTimestamp {
            get {
                return this.brokerCommitTimestampField;
            }
            set {
                this.brokerCommitTimestampField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BrokerCommitTimestampSpecified {
            get {
                return this.brokerCommitTimestampFieldSpecified;
            }
            set {
                this.brokerCommitTimestampFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DayOfWeekType BrokerCommitDayOfWeek {
            get {
                return this.brokerCommitDayOfWeekField;
            }
            set {
                this.brokerCommitDayOfWeekField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BrokerCommitDayOfWeekSpecified {
            get {
                return this.brokerCommitDayOfWeekFieldSpecified;
            }
            set {
                this.brokerCommitDayOfWeekFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string BrokerToDestinationDays {
            get {
                return this.brokerToDestinationDaysField;
            }
            set {
                this.brokerToDestinationDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime ProofOfDeliveryDate {
            get {
                return this.proofOfDeliveryDateField;
            }
            set {
                this.proofOfDeliveryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProofOfDeliveryDateSpecified {
            get {
                return this.proofOfDeliveryDateFieldSpecified;
            }
            set {
                this.proofOfDeliveryDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DayOfWeekType ProofOfDeliveryDayOfWeek {
            get {
                return this.proofOfDeliveryDayOfWeekField;
            }
            set {
                this.proofOfDeliveryDayOfWeekField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProofOfDeliveryDayOfWeekSpecified {
            get {
                return this.proofOfDeliveryDayOfWeekFieldSpecified;
            }
            set {
                this.proofOfDeliveryDayOfWeekFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommitMessages")]
        public Notification[] CommitMessages {
            get {
                return this.commitMessagesField;
            }
            set {
                this.commitMessagesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryMessages")]
        public string[] DeliveryMessages {
            get {
                return this.deliveryMessagesField;
            }
            set {
                this.deliveryMessagesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DelayDetails")]
        public DelayDetail[] DelayDetails {
            get {
                return this.delayDetailsField;
            }
            set {
                this.delayDetailsField = value;
            }
        }
        
        /// <remarks/>
        public InternationalDocumentContentType DocumentContent {
            get {
                return this.documentContentField;
            }
            set {
                this.documentContentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocumentContentSpecified {
            get {
                return this.documentContentFieldSpecified;
            }
            set {
                this.documentContentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredDocuments")]
        public RequiredShippingDocumentType[] RequiredDocuments {
            get {
                return this.requiredDocumentsField;
            }
            set {
                this.requiredDocumentsField = value;
            }
        }
        
        /// <remarks/>
        public FreightCommitDetail FreightCommitDetail {
            get {
                return this.freightCommitDetailField;
            }
            set {
                this.freightCommitDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ServiceOptionType {
        
        /// <remarks/>
        FEDEX_ONE_RATE,
        
        /// <remarks/>
        FREIGHT_GUARANTEE,
        
        /// <remarks/>
        SATURDAY_DELIVERY,
        
        /// <remarks/>
        SMART_POST_ALLOWED_INDICIA,
        
        /// <remarks/>
        SMART_POST_HUB_ID,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ServiceSubOptionDetail {
        
        private FreightGuaranteeType freightGuaranteeField;
        
        private bool freightGuaranteeFieldSpecified;
        
        private string smartPostHubIdField;
        
        private SmartPostIndiciaType smartPostIndiciaField;
        
        private bool smartPostIndiciaFieldSpecified;
        
        /// <remarks/>
        public FreightGuaranteeType FreightGuarantee {
            get {
                return this.freightGuaranteeField;
            }
            set {
                this.freightGuaranteeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FreightGuaranteeSpecified {
            get {
                return this.freightGuaranteeFieldSpecified;
            }
            set {
                this.freightGuaranteeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string SmartPostHubId {
            get {
                return this.smartPostHubIdField;
            }
            set {
                this.smartPostHubIdField = value;
            }
        }
        
        /// <remarks/>
        public SmartPostIndiciaType SmartPostIndicia {
            get {
                return this.smartPostIndiciaField;
            }
            set {
                this.smartPostIndiciaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SmartPostIndiciaSpecified {
            get {
                return this.smartPostIndiciaFieldSpecified;
            }
            set {
                this.smartPostIndiciaFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum FreightGuaranteeType {
        
        /// <remarks/>
        GUARANTEED_DATE,
        
        /// <remarks/>
        GUARANTEED_MORNING,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum SmartPostIndiciaType {
        
        /// <remarks/>
        MEDIA_MAIL,
        
        /// <remarks/>
        PARCEL_RETURN,
        
        /// <remarks/>
        PARCEL_SELECT,
        
        /// <remarks/>
        PRESORTED_BOUND_PRINTED_MATTER,
        
        /// <remarks/>
        PRESORTED_STANDARD,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class SignatureOptionDetail {
        
        private SignatureOptionType optionTypeField;
        
        private bool optionTypeFieldSpecified;
        
        private string signatureReleaseNumberField;
        
        /// <remarks/>
        public SignatureOptionType OptionType {
            get {
                return this.optionTypeField;
            }
            set {
                this.optionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OptionTypeSpecified {
            get {
                return this.optionTypeFieldSpecified;
            }
            set {
                this.optionTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string SignatureReleaseNumber {
            get {
                return this.signatureReleaseNumberField;
            }
            set {
                this.signatureReleaseNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum SignatureOptionType {
        
        /// <remarks/>
        ADULT,
        
        /// <remarks/>
        DIRECT,
        
        /// <remarks/>
        INDIRECT,
        
        /// <remarks/>
        NO_SIGNATURE_REQUIRED,
        
        /// <remarks/>
        SERVICE_DEFAULT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum TransitTimeType {
        
        /// <remarks/>
        EIGHTEEN_DAYS,
        
        /// <remarks/>
        EIGHT_DAYS,
        
        /// <remarks/>
        ELEVEN_DAYS,
        
        /// <remarks/>
        FIFTEEN_DAYS,
        
        /// <remarks/>
        FIVE_DAYS,
        
        /// <remarks/>
        FOURTEEN_DAYS,
        
        /// <remarks/>
        FOUR_DAYS,
        
        /// <remarks/>
        NINETEEN_DAYS,
        
        /// <remarks/>
        NINE_DAYS,
        
        /// <remarks/>
        ONE_DAY,
        
        /// <remarks/>
        SEVENTEEN_DAYS,
        
        /// <remarks/>
        SEVEN_DAYS,
        
        /// <remarks/>
        SIXTEEN_DAYS,
        
        /// <remarks/>
        SIX_DAYS,
        
        /// <remarks/>
        TEN_DAYS,
        
        /// <remarks/>
        THIRTEEN_DAYS,
        
        /// <remarks/>
        THREE_DAYS,
        
        /// <remarks/>
        TWELVE_DAYS,
        
        /// <remarks/>
        TWENTY_DAYS,
        
        /// <remarks/>
        TWO_DAYS,
        
        /// <remarks/>
        UNKNOWN,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Notification {
        
        private NotificationSeverityType severityField;
        
        private bool severityFieldSpecified;
        
        private string sourceField;
        
        private string codeField;
        
        private string messageField;
        
        private string localizedMessageField;
        
        private NotificationParameter[] messageParametersField;
        
        /// <remarks/>
        public NotificationSeverityType Severity {
            get {
                return this.severityField;
            }
            set {
                this.severityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SeveritySpecified {
            get {
                return this.severityFieldSpecified;
            }
            set {
                this.severityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        public string LocalizedMessage {
            get {
                return this.localizedMessageField;
            }
            set {
                this.localizedMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MessageParameters")]
        public NotificationParameter[] MessageParameters {
            get {
                return this.messageParametersField;
            }
            set {
                this.messageParametersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum NotificationSeverityType {
        
        /// <remarks/>
        ERROR,
        
        /// <remarks/>
        FAILURE,
        
        /// <remarks/>
        NOTE,
        
        /// <remarks/>
        SUCCESS,
        
        /// <remarks/>
        WARNING,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class NotificationParameter {
        
        private string idField;
        
        private string valueField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum InternationalDocumentContentType {
        
        /// <remarks/>
        DOCUMENTS_ONLY,
        
        /// <remarks/>
        NON_DOCUMENTS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RequiredShippingDocumentType {
        
        /// <remarks/>
        CANADIAN_B13A,
        
        /// <remarks/>
        CERTIFICATE_OF_ORIGIN,
        
        /// <remarks/>
        COMMERCIAL_INVOICE,
        
        /// <remarks/>
        INTERNATIONAL_AIRWAY_BILL,
        
        /// <remarks/>
        MAIL_SERVICE_AIRWAY_BILL,
        
        /// <remarks/>
        SHIPPERS_EXPORT_DECLARATION,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class RateReplyDetail {
        
        private ServiceType serviceTypeField;
        
        private bool serviceTypeFieldSpecified;
        
        private PackagingType packagingTypeField;
        
        private bool packagingTypeFieldSpecified;
        
        private ServiceOptionType[] appliedOptionsField;
        
        private ServiceSubOptionDetail appliedSubOptionsField;
        
        private string deliveryStationField;
        
        private DayOfWeekType deliveryDayOfWeekField;
        
        private bool deliveryDayOfWeekFieldSpecified;
        
        private System.DateTime deliveryTimestampField;
        
        private bool deliveryTimestampFieldSpecified;
        
        private CommitDetail[] commitDetailsField;
        
        private string destinationAirportIdField;
        
        private bool ineligibleForMoneyBackGuaranteeField;
        
        private bool ineligibleForMoneyBackGuaranteeFieldSpecified;
        
        private string originServiceAreaField;
        
        private string destinationServiceAreaField;
        
        private TransitTimeType transitTimeField;
        
        private bool transitTimeFieldSpecified;
        
        private TransitTimeType maximumTransitTimeField;
        
        private bool maximumTransitTimeFieldSpecified;
        
        private SignatureOptionType signatureOptionField;
        
        private bool signatureOptionFieldSpecified;
        
        private ReturnedRateType actualRateTypeField;
        
        private bool actualRateTypeFieldSpecified;
        
        private RatedShipmentDetail[] ratedShipmentDetailsField;
        
        /// <remarks/>
        public ServiceType ServiceType {
            get {
                return this.serviceTypeField;
            }
            set {
                this.serviceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServiceTypeSpecified {
            get {
                return this.serviceTypeFieldSpecified;
            }
            set {
                this.serviceTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PackagingType PackagingType {
            get {
                return this.packagingTypeField;
            }
            set {
                this.packagingTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackagingTypeSpecified {
            get {
                return this.packagingTypeFieldSpecified;
            }
            set {
                this.packagingTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AppliedOptions")]
        public ServiceOptionType[] AppliedOptions {
            get {
                return this.appliedOptionsField;
            }
            set {
                this.appliedOptionsField = value;
            }
        }
        
        /// <remarks/>
        public ServiceSubOptionDetail AppliedSubOptions {
            get {
                return this.appliedSubOptionsField;
            }
            set {
                this.appliedSubOptionsField = value;
            }
        }
        
        /// <remarks/>
        public string DeliveryStation {
            get {
                return this.deliveryStationField;
            }
            set {
                this.deliveryStationField = value;
            }
        }
        
        /// <remarks/>
        public DayOfWeekType DeliveryDayOfWeek {
            get {
                return this.deliveryDayOfWeekField;
            }
            set {
                this.deliveryDayOfWeekField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryDayOfWeekSpecified {
            get {
                return this.deliveryDayOfWeekFieldSpecified;
            }
            set {
                this.deliveryDayOfWeekFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime DeliveryTimestamp {
            get {
                return this.deliveryTimestampField;
            }
            set {
                this.deliveryTimestampField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryTimestampSpecified {
            get {
                return this.deliveryTimestampFieldSpecified;
            }
            set {
                this.deliveryTimestampFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommitDetails")]
        public CommitDetail[] CommitDetails {
            get {
                return this.commitDetailsField;
            }
            set {
                this.commitDetailsField = value;
            }
        }
        
        /// <remarks/>
        public string DestinationAirportId {
            get {
                return this.destinationAirportIdField;
            }
            set {
                this.destinationAirportIdField = value;
            }
        }
        
        /// <remarks/>
        public bool IneligibleForMoneyBackGuarantee {
            get {
                return this.ineligibleForMoneyBackGuaranteeField;
            }
            set {
                this.ineligibleForMoneyBackGuaranteeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IneligibleForMoneyBackGuaranteeSpecified {
            get {
                return this.ineligibleForMoneyBackGuaranteeFieldSpecified;
            }
            set {
                this.ineligibleForMoneyBackGuaranteeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string OriginServiceArea {
            get {
                return this.originServiceAreaField;
            }
            set {
                this.originServiceAreaField = value;
            }
        }
        
        /// <remarks/>
        public string DestinationServiceArea {
            get {
                return this.destinationServiceAreaField;
            }
            set {
                this.destinationServiceAreaField = value;
            }
        }
        
        /// <remarks/>
        public TransitTimeType TransitTime {
            get {
                return this.transitTimeField;
            }
            set {
                this.transitTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransitTimeSpecified {
            get {
                return this.transitTimeFieldSpecified;
            }
            set {
                this.transitTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public TransitTimeType MaximumTransitTime {
            get {
                return this.maximumTransitTimeField;
            }
            set {
                this.maximumTransitTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaximumTransitTimeSpecified {
            get {
                return this.maximumTransitTimeFieldSpecified;
            }
            set {
                this.maximumTransitTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public SignatureOptionType SignatureOption {
            get {
                return this.signatureOptionField;
            }
            set {
                this.signatureOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SignatureOptionSpecified {
            get {
                return this.signatureOptionFieldSpecified;
            }
            set {
                this.signatureOptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ReturnedRateType ActualRateType {
            get {
                return this.actualRateTypeField;
            }
            set {
                this.actualRateTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActualRateTypeSpecified {
            get {
                return this.actualRateTypeFieldSpecified;
            }
            set {
                this.actualRateTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RatedShipmentDetails")]
        public RatedShipmentDetail[] RatedShipmentDetails {
            get {
                return this.ratedShipmentDetailsField;
            }
            set {
                this.ratedShipmentDetailsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum PackagingType {
        
        /// <remarks/>
        FEDEX_10KG_BOX,
        
        /// <remarks/>
        FEDEX_25KG_BOX,
        
        /// <remarks/>
        FEDEX_BOX,
        
        /// <remarks/>
        FEDEX_ENVELOPE,
        
        /// <remarks/>
        FEDEX_EXTRA_LARGE_BOX,
        
        /// <remarks/>
        FEDEX_LARGE_BOX,
        
        /// <remarks/>
        FEDEX_MEDIUM_BOX,
        
        /// <remarks/>
        FEDEX_PAK,
        
        /// <remarks/>
        FEDEX_SMALL_BOX,
        
        /// <remarks/>
        FEDEX_TUBE,
        
        /// <remarks/>
        YOUR_PACKAGING,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class RateReply {
        
        private NotificationSeverityType highestSeverityField;
        
        private Notification[] notificationsField;
        
        private TransactionDetail transactionDetailField;
        
        private VersionId versionField;
        
        private RateReplyDetail[] rateReplyDetailsField;
        
        /// <remarks/>
        public NotificationSeverityType HighestSeverity {
            get {
                return this.highestSeverityField;
            }
            set {
                this.highestSeverityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Notifications")]
        public Notification[] Notifications {
            get {
                return this.notificationsField;
            }
            set {
                this.notificationsField = value;
            }
        }
        
        /// <remarks/>
        public TransactionDetail TransactionDetail {
            get {
                return this.transactionDetailField;
            }
            set {
                this.transactionDetailField = value;
            }
        }
        
        /// <remarks/>
        public VersionId Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RateReplyDetails")]
        public RateReplyDetail[] RateReplyDetails {
            get {
                return this.rateReplyDetailsField;
            }
            set {
                this.rateReplyDetailsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class TransactionDetail {
        
        private string customerTransactionIdField;
        
        private Localization localizationField;
        
        /// <remarks/>
        public string CustomerTransactionId {
            get {
                return this.customerTransactionIdField;
            }
            set {
                this.customerTransactionIdField = value;
            }
        }
        
        /// <remarks/>
        public Localization Localization {
            get {
                return this.localizationField;
            }
            set {
                this.localizationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Localization {
        
        private string languageCodeField;
        
        private string localeCodeField;
        
        /// <remarks/>
        public string LanguageCode {
            get {
                return this.languageCodeField;
            }
            set {
                this.languageCodeField = value;
            }
        }
        
        /// <remarks/>
        public string LocaleCode {
            get {
                return this.localeCodeField;
            }
            set {
                this.localeCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class VersionId {
        
        private string serviceIdField;
        
        private int majorField;
        
        private int intermediateField;
        
        private int minorField;
        
        public VersionId() {
            this.serviceIdField = "crs";
            this.majorField = 20;
            this.intermediateField = 0;
            this.minorField = 0;
        }
        
        /// <remarks/>
        public string ServiceId {
            get {
                return this.serviceIdField;
            }
            set {
                this.serviceIdField = value;
            }
        }
        
        /// <remarks/>
        public int Major {
            get {
                return this.majorField;
            }
            set {
                this.majorField = value;
            }
        }
        
        /// <remarks/>
        public int Intermediate {
            get {
                return this.intermediateField;
            }
            set {
                this.intermediateField = value;
            }
        }
        
        /// <remarks/>
        public int Minor {
            get {
                return this.minorField;
            }
            set {
                this.minorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ContentRecord {
        
        private string partNumberField;
        
        private string itemNumberField;
        
        private string receivedQuantityField;
        
        private string descriptionField;
        
        /// <remarks/>
        public string PartNumber {
            get {
                return this.partNumberField;
            }
            set {
                this.partNumberField = value;
            }
        }
        
        /// <remarks/>
        public string ItemNumber {
            get {
                return this.itemNumberField;
            }
            set {
                this.itemNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string ReceivedQuantity {
            get {
                return this.receivedQuantityField;
            }
            set {
                this.receivedQuantityField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class AlcoholDetail {
        
        private AlcoholRecipientType recipientTypeField;
        
        private bool recipientTypeFieldSpecified;
        
        /// <remarks/>
        public AlcoholRecipientType RecipientType {
            get {
                return this.recipientTypeField;
            }
            set {
                this.recipientTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecipientTypeSpecified {
            get {
                return this.recipientTypeFieldSpecified;
            }
            set {
                this.recipientTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum AlcoholRecipientType {
        
        /// <remarks/>
        CONSUMER,
        
        /// <remarks/>
        LICENSEE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class PriorityAlertDetail {
        
        private PriorityAlertEnhancementType[] enhancementTypesField;
        
        private string[] contentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnhancementTypes")]
        public PriorityAlertEnhancementType[] EnhancementTypes {
            get {
                return this.enhancementTypesField;
            }
            set {
                this.enhancementTypesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Content")]
        public string[] Content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum PriorityAlertEnhancementType {
        
        /// <remarks/>
        PRIORITY_ALERT_PLUS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class PackageSpecialServicesRequested {
        
        private PackageSpecialServiceType[] specialServiceTypesField;
        
        private CodDetail codDetailField;
        
        private DangerousGoodsDetail dangerousGoodsDetailField;
        
        private Weight dryIceWeightField;
        
        private SignatureOptionDetail signatureOptionDetailField;
        
        private PriorityAlertDetail priorityAlertDetailField;
        
        private AlcoholDetail alcoholDetailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialServiceTypes")]
        public PackageSpecialServiceType[] SpecialServiceTypes {
            get {
                return this.specialServiceTypesField;
            }
            set {
                this.specialServiceTypesField = value;
            }
        }
        
        /// <remarks/>
        public CodDetail CodDetail {
            get {
                return this.codDetailField;
            }
            set {
                this.codDetailField = value;
            }
        }
        
        /// <remarks/>
        public DangerousGoodsDetail DangerousGoodsDetail {
            get {
                return this.dangerousGoodsDetailField;
            }
            set {
                this.dangerousGoodsDetailField = value;
            }
        }
        
        /// <remarks/>
        public Weight DryIceWeight {
            get {
                return this.dryIceWeightField;
            }
            set {
                this.dryIceWeightField = value;
            }
        }
        
        /// <remarks/>
        public SignatureOptionDetail SignatureOptionDetail {
            get {
                return this.signatureOptionDetailField;
            }
            set {
                this.signatureOptionDetailField = value;
            }
        }
        
        /// <remarks/>
        public PriorityAlertDetail PriorityAlertDetail {
            get {
                return this.priorityAlertDetailField;
            }
            set {
                this.priorityAlertDetailField = value;
            }
        }
        
        /// <remarks/>
        public AlcoholDetail AlcoholDetail {
            get {
                return this.alcoholDetailField;
            }
            set {
                this.alcoholDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum PackageSpecialServiceType {
        
        /// <remarks/>
        ALCOHOL,
        
        /// <remarks/>
        APPOINTMENT_DELIVERY,
        
        /// <remarks/>
        COD,
        
        /// <remarks/>
        DANGEROUS_GOODS,
        
        /// <remarks/>
        DRY_ICE,
        
        /// <remarks/>
        NON_STANDARD_CONTAINER,
        
        /// <remarks/>
        PRIORITY_ALERT,
        
        /// <remarks/>
        SIGNATURE_OPTION,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CodDetail {
        
        private Money codCollectionAmountField;
        
        private CodAddTransportationChargesDetail addTransportationChargesDetailField;
        
        private CodCollectionType collectionTypeField;
        
        private bool collectionTypeFieldSpecified;
        
        private Party codRecipientField;
        
        private ContactAndAddress financialInstitutionContactAndAddressField;
        
        private string remitToNameField;
        
        private CodReturnReferenceIndicatorType referenceIndicatorField;
        
        private bool referenceIndicatorFieldSpecified;
        
        private TrackingId returnTrackingIdField;
        
        /// <remarks/>
        public Money CodCollectionAmount {
            get {
                return this.codCollectionAmountField;
            }
            set {
                this.codCollectionAmountField = value;
            }
        }
        
        /// <remarks/>
        public CodAddTransportationChargesDetail AddTransportationChargesDetail {
            get {
                return this.addTransportationChargesDetailField;
            }
            set {
                this.addTransportationChargesDetailField = value;
            }
        }
        
        /// <remarks/>
        public CodCollectionType CollectionType {
            get {
                return this.collectionTypeField;
            }
            set {
                this.collectionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CollectionTypeSpecified {
            get {
                return this.collectionTypeFieldSpecified;
            }
            set {
                this.collectionTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Party CodRecipient {
            get {
                return this.codRecipientField;
            }
            set {
                this.codRecipientField = value;
            }
        }
        
        /// <remarks/>
        public ContactAndAddress FinancialInstitutionContactAndAddress {
            get {
                return this.financialInstitutionContactAndAddressField;
            }
            set {
                this.financialInstitutionContactAndAddressField = value;
            }
        }
        
        /// <remarks/>
        public string RemitToName {
            get {
                return this.remitToNameField;
            }
            set {
                this.remitToNameField = value;
            }
        }
        
        /// <remarks/>
        public CodReturnReferenceIndicatorType ReferenceIndicator {
            get {
                return this.referenceIndicatorField;
            }
            set {
                this.referenceIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReferenceIndicatorSpecified {
            get {
                return this.referenceIndicatorFieldSpecified;
            }
            set {
                this.referenceIndicatorFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public TrackingId ReturnTrackingId {
            get {
                return this.returnTrackingIdField;
            }
            set {
                this.returnTrackingIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CodAddTransportationChargesDetail {
        
        private RateTypeBasisType rateTypeBasisField;
        
        private bool rateTypeBasisFieldSpecified;
        
        private CodAddTransportationChargeBasisType chargeBasisField;
        
        private bool chargeBasisFieldSpecified;
        
        private ChargeBasisLevelType chargeBasisLevelField;
        
        private bool chargeBasisLevelFieldSpecified;
        
        /// <remarks/>
        public RateTypeBasisType RateTypeBasis {
            get {
                return this.rateTypeBasisField;
            }
            set {
                this.rateTypeBasisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateTypeBasisSpecified {
            get {
                return this.rateTypeBasisFieldSpecified;
            }
            set {
                this.rateTypeBasisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CodAddTransportationChargeBasisType ChargeBasis {
            get {
                return this.chargeBasisField;
            }
            set {
                this.chargeBasisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChargeBasisSpecified {
            get {
                return this.chargeBasisFieldSpecified;
            }
            set {
                this.chargeBasisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ChargeBasisLevelType ChargeBasisLevel {
            get {
                return this.chargeBasisLevelField;
            }
            set {
                this.chargeBasisLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChargeBasisLevelSpecified {
            get {
                return this.chargeBasisLevelFieldSpecified;
            }
            set {
                this.chargeBasisLevelFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RateTypeBasisType {
        
        /// <remarks/>
        ACCOUNT,
        
        /// <remarks/>
        LIST,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum CodAddTransportationChargeBasisType {
        
        /// <remarks/>
        COD_SURCHARGE,
        
        /// <remarks/>
        NET_CHARGE,
        
        /// <remarks/>
        NET_FREIGHT,
        
        /// <remarks/>
        TOTAL_CUSTOMER_CHARGE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ChargeBasisLevelType {
        
        /// <remarks/>
        CURRENT_PACKAGE,
        
        /// <remarks/>
        SUM_OF_PACKAGES,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum CodCollectionType {
        
        /// <remarks/>
        ANY,
        
        /// <remarks/>
        CASH,
        
        /// <remarks/>
        GUARANTEED_FUNDS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Party {
        
        private string accountNumberField;
        
        private TaxpayerIdentification[] tinsField;
        
        private Contact contactField;
        
        private Address addressField;
        
        /// <remarks/>
        public string AccountNumber {
            get {
                return this.accountNumberField;
            }
            set {
                this.accountNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Tins")]
        public TaxpayerIdentification[] Tins {
            get {
                return this.tinsField;
            }
            set {
                this.tinsField = value;
            }
        }
        
        /// <remarks/>
        public Contact Contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }
        
        /// <remarks/>
        public Address Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class TaxpayerIdentification {
        
        private TinType tinTypeField;
        
        private bool tinTypeFieldSpecified;
        
        private string numberField;
        
        private string usageField;
        
        private System.DateTime effectiveDateField;
        
        private bool effectiveDateFieldSpecified;
        
        private System.DateTime expirationDateField;
        
        private bool expirationDateFieldSpecified;
        
        /// <remarks/>
        public TinType TinType {
            get {
                return this.tinTypeField;
            }
            set {
                this.tinTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TinTypeSpecified {
            get {
                return this.tinTypeFieldSpecified;
            }
            set {
                this.tinTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        public string Usage {
            get {
                return this.usageField;
            }
            set {
                this.usageField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime EffectiveDate {
            get {
                return this.effectiveDateField;
            }
            set {
                this.effectiveDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EffectiveDateSpecified {
            get {
                return this.effectiveDateFieldSpecified;
            }
            set {
                this.effectiveDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime ExpirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpirationDateSpecified {
            get {
                return this.expirationDateFieldSpecified;
            }
            set {
                this.expirationDateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum TinType {
        
        /// <remarks/>
        BUSINESS_NATIONAL,
        
        /// <remarks/>
        BUSINESS_STATE,
        
        /// <remarks/>
        PERSONAL_NATIONAL,
        
        /// <remarks/>
        PERSONAL_STATE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum CodReturnReferenceIndicatorType {
        
        /// <remarks/>
        INVOICE,
        
        /// <remarks/>
        PO,
        
        /// <remarks/>
        REFERENCE,
        
        /// <remarks/>
        TRACKING,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class DangerousGoodsDetail {
        
        private HazardousCommodityRegulationType regulationField;
        
        private bool regulationFieldSpecified;
        
        private DangerousGoodsAccessibilityType accessibilityField;
        
        private bool accessibilityFieldSpecified;
        
        private bool cargoAircraftOnlyField;
        
        private bool cargoAircraftOnlyFieldSpecified;
        
        private HazardousCommodityOptionType[] optionsField;
        
        private DangerousGoodsPackingOptionType packingOptionField;
        
        private bool packingOptionFieldSpecified;
        
        private string referenceIdField;
        
        private DangerousGoodsContainer[] containersField;
        
        private HazardousCommodityPackagingDetail packagingField;
        
        private DangerousGoodsSignatory signatoryField;
        
        private string emergencyContactNumberField;
        
        private string offerorField;
        
        private Contact infectiousSubstanceResponsibleContactField;
        
        private string additionalHandlingField;
        
        private RadioactivityDetail radioactivityDetailField;
        
        /// <remarks/>
        public HazardousCommodityRegulationType Regulation {
            get {
                return this.regulationField;
            }
            set {
                this.regulationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegulationSpecified {
            get {
                return this.regulationFieldSpecified;
            }
            set {
                this.regulationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DangerousGoodsAccessibilityType Accessibility {
            get {
                return this.accessibilityField;
            }
            set {
                this.accessibilityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccessibilitySpecified {
            get {
                return this.accessibilityFieldSpecified;
            }
            set {
                this.accessibilityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool CargoAircraftOnly {
            get {
                return this.cargoAircraftOnlyField;
            }
            set {
                this.cargoAircraftOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CargoAircraftOnlySpecified {
            get {
                return this.cargoAircraftOnlyFieldSpecified;
            }
            set {
                this.cargoAircraftOnlyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Options")]
        public HazardousCommodityOptionType[] Options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
            }
        }
        
        /// <remarks/>
        public DangerousGoodsPackingOptionType PackingOption {
            get {
                return this.packingOptionField;
            }
            set {
                this.packingOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackingOptionSpecified {
            get {
                return this.packingOptionFieldSpecified;
            }
            set {
                this.packingOptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ReferenceId {
            get {
                return this.referenceIdField;
            }
            set {
                this.referenceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Containers")]
        public DangerousGoodsContainer[] Containers {
            get {
                return this.containersField;
            }
            set {
                this.containersField = value;
            }
        }
        
        /// <remarks/>
        public HazardousCommodityPackagingDetail Packaging {
            get {
                return this.packagingField;
            }
            set {
                this.packagingField = value;
            }
        }
        
        /// <remarks/>
        public DangerousGoodsSignatory Signatory {
            get {
                return this.signatoryField;
            }
            set {
                this.signatoryField = value;
            }
        }
        
        /// <remarks/>
        public string EmergencyContactNumber {
            get {
                return this.emergencyContactNumberField;
            }
            set {
                this.emergencyContactNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Offeror {
            get {
                return this.offerorField;
            }
            set {
                this.offerorField = value;
            }
        }
        
        /// <remarks/>
        public Contact InfectiousSubstanceResponsibleContact {
            get {
                return this.infectiousSubstanceResponsibleContactField;
            }
            set {
                this.infectiousSubstanceResponsibleContactField = value;
            }
        }
        
        /// <remarks/>
        public string AdditionalHandling {
            get {
                return this.additionalHandlingField;
            }
            set {
                this.additionalHandlingField = value;
            }
        }
        
        /// <remarks/>
        public RadioactivityDetail RadioactivityDetail {
            get {
                return this.radioactivityDetailField;
            }
            set {
                this.radioactivityDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum HazardousCommodityRegulationType {
        
        /// <remarks/>
        ADR,
        
        /// <remarks/>
        DOT,
        
        /// <remarks/>
        IATA,
        
        /// <remarks/>
        ORMD,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum DangerousGoodsAccessibilityType {
        
        /// <remarks/>
        ACCESSIBLE,
        
        /// <remarks/>
        INACCESSIBLE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum HazardousCommodityOptionType {
        
        /// <remarks/>
        BATTERY,
        
        /// <remarks/>
        HAZARDOUS_MATERIALS,
        
        /// <remarks/>
        LIMITED_QUANTITIES_COMMODITIES,
        
        /// <remarks/>
        ORM_D,
        
        /// <remarks/>
        REPORTABLE_QUANTITIES,
        
        /// <remarks/>
        SMALL_QUANTITY_EXCEPTION,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum DangerousGoodsPackingOptionType {
        
        /// <remarks/>
        OVERPACK,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class DangerousGoodsContainer {
        
        private HazardousContainerPackingType packingTypeField;
        
        private bool packingTypeFieldSpecified;
        
        private string containerTypeField;
        
        private RadioactiveContainerClassType radioactiveContainerClassField;
        
        private bool radioactiveContainerClassFieldSpecified;
        
        private string numberOfContainersField;
        
        private HazardousCommodityContent[] hazardousCommoditiesField;
        
        /// <remarks/>
        public HazardousContainerPackingType PackingType {
            get {
                return this.packingTypeField;
            }
            set {
                this.packingTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackingTypeSpecified {
            get {
                return this.packingTypeFieldSpecified;
            }
            set {
                this.packingTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ContainerType {
            get {
                return this.containerTypeField;
            }
            set {
                this.containerTypeField = value;
            }
        }
        
        /// <remarks/>
        public RadioactiveContainerClassType RadioactiveContainerClass {
            get {
                return this.radioactiveContainerClassField;
            }
            set {
                this.radioactiveContainerClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RadioactiveContainerClassSpecified {
            get {
                return this.radioactiveContainerClassFieldSpecified;
            }
            set {
                this.radioactiveContainerClassFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string NumberOfContainers {
            get {
                return this.numberOfContainersField;
            }
            set {
                this.numberOfContainersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HazardousCommodities")]
        public HazardousCommodityContent[] HazardousCommodities {
            get {
                return this.hazardousCommoditiesField;
            }
            set {
                this.hazardousCommoditiesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum HazardousContainerPackingType {
        
        /// <remarks/>
        ALL_PACKED_IN_ONE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RadioactiveContainerClassType {
        
        /// <remarks/>
        EXCEPTED_PACKAGE,
        
        /// <remarks/>
        INDUSTRIAL_IP1,
        
        /// <remarks/>
        INDUSTRIAL_IP2,
        
        /// <remarks/>
        INDUSTRIAL_IP3,
        
        /// <remarks/>
        TYPE_A,
        
        /// <remarks/>
        TYPE_B_M,
        
        /// <remarks/>
        TYPE_B_U,
        
        /// <remarks/>
        TYPE_C,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class HazardousCommodityContent {
        
        private HazardousCommodityDescription descriptionField;
        
        private HazardousCommodityQuantityDetail quantityField;
        
        private HazardousCommodityInnerReceptacleDetail[] innerReceptaclesField;
        
        private HazardousCommodityOptionDetail optionsField;
        
        private RadionuclideDetail radionuclideDetailField;
        
        private NetExplosiveDetail netExplosiveDetailField;
        
        /// <remarks/>
        public HazardousCommodityDescription Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public HazardousCommodityQuantityDetail Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InnerReceptacles")]
        public HazardousCommodityInnerReceptacleDetail[] InnerReceptacles {
            get {
                return this.innerReceptaclesField;
            }
            set {
                this.innerReceptaclesField = value;
            }
        }
        
        /// <remarks/>
        public HazardousCommodityOptionDetail Options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
            }
        }
        
        /// <remarks/>
        public RadionuclideDetail RadionuclideDetail {
            get {
                return this.radionuclideDetailField;
            }
            set {
                this.radionuclideDetailField = value;
            }
        }
        
        /// <remarks/>
        public NetExplosiveDetail NetExplosiveDetail {
            get {
                return this.netExplosiveDetailField;
            }
            set {
                this.netExplosiveDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class HazardousCommodityDescription {
        
        private string idField;
        
        private string sequenceNumberField;
        
        private HazardousCommodityPackingGroupType packingGroupField;
        
        private bool packingGroupFieldSpecified;
        
        private HazardousCommodityPackingDetail packingDetailsField;
        
        private bool reportableQuantityField;
        
        private bool reportableQuantityFieldSpecified;
        
        private string properShippingNameField;
        
        private string technicalNameField;
        
        private decimal percentageField;
        
        private bool percentageFieldSpecified;
        
        private string hazardClassField;
        
        private string[] subsidiaryClassesField;
        
        private string labelTextField;
        
        private HazardousCommodityDescriptionProcessingOptionType[] processingOptionsField;
        
        private string authorizationField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string SequenceNumber {
            get {
                return this.sequenceNumberField;
            }
            set {
                this.sequenceNumberField = value;
            }
        }
        
        /// <remarks/>
        public HazardousCommodityPackingGroupType PackingGroup {
            get {
                return this.packingGroupField;
            }
            set {
                this.packingGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackingGroupSpecified {
            get {
                return this.packingGroupFieldSpecified;
            }
            set {
                this.packingGroupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public HazardousCommodityPackingDetail PackingDetails {
            get {
                return this.packingDetailsField;
            }
            set {
                this.packingDetailsField = value;
            }
        }
        
        /// <remarks/>
        public bool ReportableQuantity {
            get {
                return this.reportableQuantityField;
            }
            set {
                this.reportableQuantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportableQuantitySpecified {
            get {
                return this.reportableQuantityFieldSpecified;
            }
            set {
                this.reportableQuantityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ProperShippingName {
            get {
                return this.properShippingNameField;
            }
            set {
                this.properShippingNameField = value;
            }
        }
        
        /// <remarks/>
        public string TechnicalName {
            get {
                return this.technicalNameField;
            }
            set {
                this.technicalNameField = value;
            }
        }
        
        /// <remarks/>
        public decimal Percentage {
            get {
                return this.percentageField;
            }
            set {
                this.percentageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentageSpecified {
            get {
                return this.percentageFieldSpecified;
            }
            set {
                this.percentageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string HazardClass {
            get {
                return this.hazardClassField;
            }
            set {
                this.hazardClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubsidiaryClasses")]
        public string[] SubsidiaryClasses {
            get {
                return this.subsidiaryClassesField;
            }
            set {
                this.subsidiaryClassesField = value;
            }
        }
        
        /// <remarks/>
        public string LabelText {
            get {
                return this.labelTextField;
            }
            set {
                this.labelTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessingOptions")]
        public HazardousCommodityDescriptionProcessingOptionType[] ProcessingOptions {
            get {
                return this.processingOptionsField;
            }
            set {
                this.processingOptionsField = value;
            }
        }
        
        /// <remarks/>
        public string Authorization {
            get {
                return this.authorizationField;
            }
            set {
                this.authorizationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum HazardousCommodityPackingGroupType {
        
        /// <remarks/>
        DEFAULT,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        II,
        
        /// <remarks/>
        III,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class HazardousCommodityPackingDetail {
        
        private bool cargoAircraftOnlyField;
        
        private bool cargoAircraftOnlyFieldSpecified;
        
        private string packingInstructionsField;
        
        /// <remarks/>
        public bool CargoAircraftOnly {
            get {
                return this.cargoAircraftOnlyField;
            }
            set {
                this.cargoAircraftOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CargoAircraftOnlySpecified {
            get {
                return this.cargoAircraftOnlyFieldSpecified;
            }
            set {
                this.cargoAircraftOnlyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string PackingInstructions {
            get {
                return this.packingInstructionsField;
            }
            set {
                this.packingInstructionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum HazardousCommodityDescriptionProcessingOptionType {
        
        /// <remarks/>
        INCLUDE_SPECIAL_PROVISIONS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class HazardousCommodityQuantityDetail {
        
        private decimal amountField;
        
        private bool amountFieldSpecified;
        
        private string unitsField;
        
        private HazardousCommodityQuantityType quantityTypeField;
        
        private bool quantityTypeFieldSpecified;
        
        /// <remarks/>
        public decimal Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified {
            get {
                return this.amountFieldSpecified;
            }
            set {
                this.amountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }
        
        /// <remarks/>
        public HazardousCommodityQuantityType QuantityType {
            get {
                return this.quantityTypeField;
            }
            set {
                this.quantityTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityTypeSpecified {
            get {
                return this.quantityTypeFieldSpecified;
            }
            set {
                this.quantityTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum HazardousCommodityQuantityType {
        
        /// <remarks/>
        GROSS,
        
        /// <remarks/>
        NET,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class HazardousCommodityInnerReceptacleDetail {
        
        private HazardousCommodityQuantityDetail quantityField;
        
        /// <remarks/>
        public HazardousCommodityQuantityDetail Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class HazardousCommodityOptionDetail {
        
        private HazardousCommodityLabelTextOptionType labelTextOptionField;
        
        private bool labelTextOptionFieldSpecified;
        
        private string customerSuppliedLabelTextField;
        
        /// <remarks/>
        public HazardousCommodityLabelTextOptionType LabelTextOption {
            get {
                return this.labelTextOptionField;
            }
            set {
                this.labelTextOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LabelTextOptionSpecified {
            get {
                return this.labelTextOptionFieldSpecified;
            }
            set {
                this.labelTextOptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string CustomerSuppliedLabelText {
            get {
                return this.customerSuppliedLabelTextField;
            }
            set {
                this.customerSuppliedLabelTextField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum HazardousCommodityLabelTextOptionType {
        
        /// <remarks/>
        APPEND,
        
        /// <remarks/>
        OVERRIDE,
        
        /// <remarks/>
        STANDARD,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class RadionuclideDetail {
        
        private string radionuclideField;
        
        private RadionuclideActivity activityField;
        
        private bool exceptedPackagingIsReportableQuantityField;
        
        private bool exceptedPackagingIsReportableQuantityFieldSpecified;
        
        private PhysicalFormType physicalFormField;
        
        private bool physicalFormFieldSpecified;
        
        private string chemicalFormField;
        
        /// <remarks/>
        public string Radionuclide {
            get {
                return this.radionuclideField;
            }
            set {
                this.radionuclideField = value;
            }
        }
        
        /// <remarks/>
        public RadionuclideActivity Activity {
            get {
                return this.activityField;
            }
            set {
                this.activityField = value;
            }
        }
        
        /// <remarks/>
        public bool ExceptedPackagingIsReportableQuantity {
            get {
                return this.exceptedPackagingIsReportableQuantityField;
            }
            set {
                this.exceptedPackagingIsReportableQuantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExceptedPackagingIsReportableQuantitySpecified {
            get {
                return this.exceptedPackagingIsReportableQuantityFieldSpecified;
            }
            set {
                this.exceptedPackagingIsReportableQuantityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PhysicalFormType PhysicalForm {
            get {
                return this.physicalFormField;
            }
            set {
                this.physicalFormField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PhysicalFormSpecified {
            get {
                return this.physicalFormFieldSpecified;
            }
            set {
                this.physicalFormFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ChemicalForm {
            get {
                return this.chemicalFormField;
            }
            set {
                this.chemicalFormField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class RadionuclideActivity {
        
        private decimal valueField;
        
        private bool valueFieldSpecified;
        
        private RadioactivityUnitOfMeasure unitOfMeasureField;
        
        private bool unitOfMeasureFieldSpecified;
        
        /// <remarks/>
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueSpecified {
            get {
                return this.valueFieldSpecified;
            }
            set {
                this.valueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public RadioactivityUnitOfMeasure UnitOfMeasure {
            get {
                return this.unitOfMeasureField;
            }
            set {
                this.unitOfMeasureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitOfMeasureSpecified {
            get {
                return this.unitOfMeasureFieldSpecified;
            }
            set {
                this.unitOfMeasureFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RadioactivityUnitOfMeasure {
        
        /// <remarks/>
        BQ,
        
        /// <remarks/>
        GBQ,
        
        /// <remarks/>
        KBQ,
        
        /// <remarks/>
        MBQ,
        
        /// <remarks/>
        PBQ,
        
        /// <remarks/>
        TBQ,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum PhysicalFormType {
        
        /// <remarks/>
        GAS,
        
        /// <remarks/>
        LIQUID,
        
        /// <remarks/>
        SOLID,
        
        /// <remarks/>
        SPECIAL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class NetExplosiveDetail {
        
        private NetExplosiveClassificationType typeField;
        
        private bool typeFieldSpecified;
        
        private decimal amountField;
        
        private bool amountFieldSpecified;
        
        private string unitsField;
        
        /// <remarks/>
        public NetExplosiveClassificationType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified {
            get {
                return this.amountFieldSpecified;
            }
            set {
                this.amountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum NetExplosiveClassificationType {
        
        /// <remarks/>
        NET_EXPLOSIVE_CONTENT,
        
        /// <remarks/>
        NET_EXPLOSIVE_MASS,
        
        /// <remarks/>
        NET_EXPLOSIVE_QUANTITY,
        
        /// <remarks/>
        NET_EXPLOSIVE_WEIGHT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class HazardousCommodityPackagingDetail {
        
        private string countField;
        
        private string unitsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        public string Units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class DangerousGoodsSignatory {
        
        private string contactNameField;
        
        private string titleField;
        
        private string placeField;
        
        /// <remarks/>
        public string ContactName {
            get {
                return this.contactNameField;
            }
            set {
                this.contactNameField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string Place {
            get {
                return this.placeField;
            }
            set {
                this.placeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class RadioactivityDetail {
        
        private decimal transportIndexField;
        
        private bool transportIndexFieldSpecified;
        
        private decimal surfaceReadingField;
        
        private bool surfaceReadingFieldSpecified;
        
        private decimal criticalitySafetyIndexField;
        
        private bool criticalitySafetyIndexFieldSpecified;
        
        private Dimensions dimensionsField;
        
        /// <remarks/>
        public decimal TransportIndex {
            get {
                return this.transportIndexField;
            }
            set {
                this.transportIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransportIndexSpecified {
            get {
                return this.transportIndexFieldSpecified;
            }
            set {
                this.transportIndexFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal SurfaceReading {
            get {
                return this.surfaceReadingField;
            }
            set {
                this.surfaceReadingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SurfaceReadingSpecified {
            get {
                return this.surfaceReadingFieldSpecified;
            }
            set {
                this.surfaceReadingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal CriticalitySafetyIndex {
            get {
                return this.criticalitySafetyIndexField;
            }
            set {
                this.criticalitySafetyIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CriticalitySafetyIndexSpecified {
            get {
                return this.criticalitySafetyIndexFieldSpecified;
            }
            set {
                this.criticalitySafetyIndexFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Dimensions Dimensions {
            get {
                return this.dimensionsField;
            }
            set {
                this.dimensionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Dimensions {
        
        private string lengthField;
        
        private string widthField;
        
        private string heightField;
        
        private LinearUnits unitsField;
        
        private bool unitsFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string Length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string Width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string Height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
        
        /// <remarks/>
        public LinearUnits Units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitsSpecified {
            get {
                return this.unitsFieldSpecified;
            }
            set {
                this.unitsFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum LinearUnits {
        
        /// <remarks/>
        CM,
        
        /// <remarks/>
        IN,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CustomerReference {
        
        private CustomerReferenceType customerReferenceTypeField;
        
        private bool customerReferenceTypeFieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        public CustomerReferenceType CustomerReferenceType {
            get {
                return this.customerReferenceTypeField;
            }
            set {
                this.customerReferenceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CustomerReferenceTypeSpecified {
            get {
                return this.customerReferenceTypeFieldSpecified;
            }
            set {
                this.customerReferenceTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum CustomerReferenceType {
        
        /// <remarks/>
        BILL_OF_LADING,
        
        /// <remarks/>
        CUSTOMER_REFERENCE,
        
        /// <remarks/>
        DEPARTMENT_NUMBER,
        
        /// <remarks/>
        ELECTRONIC_PRODUCT_CODE,
        
        /// <remarks/>
        INTRACOUNTRY_REGULATORY_REFERENCE,
        
        /// <remarks/>
        INVOICE_NUMBER,
        
        /// <remarks/>
        PACKING_SLIP_NUMBER,
        
        /// <remarks/>
        P_O_NUMBER,
        
        /// <remarks/>
        RMA_ASSOCIATION,
        
        /// <remarks/>
        SHIPMENT_INTEGRITY,
        
        /// <remarks/>
        STORE_NUMBER,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class RequestedPackageLineItem {
        
        private string sequenceNumberField;
        
        private string groupNumberField;
        
        private string groupPackageCountField;
        
        private VariableHandlingChargeDetail variableHandlingChargeDetailField;
        
        private Money insuredValueField;
        
        private Weight weightField;
        
        private Dimensions dimensionsField;
        
        private PhysicalPackagingType physicalPackagingField;
        
        private bool physicalPackagingFieldSpecified;
        
        private string itemDescriptionField;
        
        private string itemDescriptionForClearanceField;
        
        private CustomerReference[] customerReferencesField;
        
        private PackageSpecialServicesRequested specialServicesRequestedField;
        
        private ContentRecord[] contentRecordsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string SequenceNumber {
            get {
                return this.sequenceNumberField;
            }
            set {
                this.sequenceNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string GroupNumber {
            get {
                return this.groupNumberField;
            }
            set {
                this.groupNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string GroupPackageCount {
            get {
                return this.groupPackageCountField;
            }
            set {
                this.groupPackageCountField = value;
            }
        }
        
        /// <remarks/>
        public VariableHandlingChargeDetail VariableHandlingChargeDetail {
            get {
                return this.variableHandlingChargeDetailField;
            }
            set {
                this.variableHandlingChargeDetailField = value;
            }
        }
        
        /// <remarks/>
        public Money InsuredValue {
            get {
                return this.insuredValueField;
            }
            set {
                this.insuredValueField = value;
            }
        }
        
        /// <remarks/>
        public Weight Weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }
        
        /// <remarks/>
        public Dimensions Dimensions {
            get {
                return this.dimensionsField;
            }
            set {
                this.dimensionsField = value;
            }
        }
        
        /// <remarks/>
        public PhysicalPackagingType PhysicalPackaging {
            get {
                return this.physicalPackagingField;
            }
            set {
                this.physicalPackagingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PhysicalPackagingSpecified {
            get {
                return this.physicalPackagingFieldSpecified;
            }
            set {
                this.physicalPackagingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ItemDescription {
            get {
                return this.itemDescriptionField;
            }
            set {
                this.itemDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string ItemDescriptionForClearance {
            get {
                return this.itemDescriptionForClearanceField;
            }
            set {
                this.itemDescriptionForClearanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomerReferences")]
        public CustomerReference[] CustomerReferences {
            get {
                return this.customerReferencesField;
            }
            set {
                this.customerReferencesField = value;
            }
        }
        
        /// <remarks/>
        public PackageSpecialServicesRequested SpecialServicesRequested {
            get {
                return this.specialServicesRequestedField;
            }
            set {
                this.specialServicesRequestedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContentRecords")]
        public ContentRecord[] ContentRecords {
            get {
                return this.contentRecordsField;
            }
            set {
                this.contentRecordsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class VariableHandlingChargeDetail {
        
        private Money fixedValueField;
        
        private decimal percentValueField;
        
        private bool percentValueFieldSpecified;
        
        private RateElementBasisType rateElementBasisField;
        
        private bool rateElementBasisFieldSpecified;
        
        private RateTypeBasisType rateTypeBasisField;
        
        private bool rateTypeBasisFieldSpecified;
        
        /// <remarks/>
        public Money FixedValue {
            get {
                return this.fixedValueField;
            }
            set {
                this.fixedValueField = value;
            }
        }
        
        /// <remarks/>
        public decimal PercentValue {
            get {
                return this.percentValueField;
            }
            set {
                this.percentValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentValueSpecified {
            get {
                return this.percentValueFieldSpecified;
            }
            set {
                this.percentValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public RateElementBasisType RateElementBasis {
            get {
                return this.rateElementBasisField;
            }
            set {
                this.rateElementBasisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateElementBasisSpecified {
            get {
                return this.rateElementBasisFieldSpecified;
            }
            set {
                this.rateElementBasisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public RateTypeBasisType RateTypeBasis {
            get {
                return this.rateTypeBasisField;
            }
            set {
                this.rateTypeBasisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateTypeBasisSpecified {
            get {
                return this.rateTypeBasisFieldSpecified;
            }
            set {
                this.rateTypeBasisFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RateElementBasisType {
        
        /// <remarks/>
        BASE_CHARGE,
        
        /// <remarks/>
        NET_CHARGE,
        
        /// <remarks/>
        NET_CHARGE_EXCLUDING_TAXES,
        
        /// <remarks/>
        NET_FREIGHT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum PhysicalPackagingType {
        
        /// <remarks/>
        BAG,
        
        /// <remarks/>
        BARREL,
        
        /// <remarks/>
        BASKET,
        
        /// <remarks/>
        BOX,
        
        /// <remarks/>
        BUCKET,
        
        /// <remarks/>
        BUNDLE,
        
        /// <remarks/>
        CARTON,
        
        /// <remarks/>
        CASE,
        
        /// <remarks/>
        CONTAINER,
        
        /// <remarks/>
        CRATE,
        
        /// <remarks/>
        CYLINDER,
        
        /// <remarks/>
        DRUM,
        
        /// <remarks/>
        ENVELOPE,
        
        /// <remarks/>
        HAMPER,
        
        /// <remarks/>
        OTHER,
        
        /// <remarks/>
        PAIL,
        
        /// <remarks/>
        PALLET,
        
        /// <remarks/>
        PIECE,
        
        /// <remarks/>
        REEL,
        
        /// <remarks/>
        ROLL,
        
        /// <remarks/>
        SKID,
        
        /// <remarks/>
        TANK,
        
        /// <remarks/>
        TUBE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ReturnInstructionsDetail {
        
        private ShippingDocumentFormat formatField;
        
        private string customTextField;
        
        /// <remarks/>
        public ShippingDocumentFormat Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        public string CustomText {
            get {
                return this.customTextField;
            }
            set {
                this.customTextField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShippingDocumentFormat {
        
        private ShippingDocumentDispositionDetail[] dispositionsField;
        
        private LinearMeasure topOfPageOffsetField;
        
        private ShippingDocumentImageType imageTypeField;
        
        private bool imageTypeFieldSpecified;
        
        private ShippingDocumentStockType stockTypeField;
        
        private bool stockTypeFieldSpecified;
        
        private bool provideInstructionsField;
        
        private bool provideInstructionsFieldSpecified;
        
        private DocumentFormatOptionType[] optionsRequestedField;
        
        private Localization localizationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dispositions")]
        public ShippingDocumentDispositionDetail[] Dispositions {
            get {
                return this.dispositionsField;
            }
            set {
                this.dispositionsField = value;
            }
        }
        
        /// <remarks/>
        public LinearMeasure TopOfPageOffset {
            get {
                return this.topOfPageOffsetField;
            }
            set {
                this.topOfPageOffsetField = value;
            }
        }
        
        /// <remarks/>
        public ShippingDocumentImageType ImageType {
            get {
                return this.imageTypeField;
            }
            set {
                this.imageTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImageTypeSpecified {
            get {
                return this.imageTypeFieldSpecified;
            }
            set {
                this.imageTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ShippingDocumentStockType StockType {
            get {
                return this.stockTypeField;
            }
            set {
                this.stockTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StockTypeSpecified {
            get {
                return this.stockTypeFieldSpecified;
            }
            set {
                this.stockTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool ProvideInstructions {
            get {
                return this.provideInstructionsField;
            }
            set {
                this.provideInstructionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProvideInstructionsSpecified {
            get {
                return this.provideInstructionsFieldSpecified;
            }
            set {
                this.provideInstructionsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Options", IsNullable=false)]
        public DocumentFormatOptionType[] OptionsRequested {
            get {
                return this.optionsRequestedField;
            }
            set {
                this.optionsRequestedField = value;
            }
        }
        
        /// <remarks/>
        public Localization Localization {
            get {
                return this.localizationField;
            }
            set {
                this.localizationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShippingDocumentDispositionDetail {
        
        private ShippingDocumentDispositionType dispositionTypeField;
        
        private bool dispositionTypeFieldSpecified;
        
        private ShippingDocumentGroupingType groupingField;
        
        private bool groupingFieldSpecified;
        
        private ShippingDocumentEMailDetail eMailDetailField;
        
        private ShippingDocumentPrintDetail printDetailField;
        
        /// <remarks/>
        public ShippingDocumentDispositionType DispositionType {
            get {
                return this.dispositionTypeField;
            }
            set {
                this.dispositionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DispositionTypeSpecified {
            get {
                return this.dispositionTypeFieldSpecified;
            }
            set {
                this.dispositionTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ShippingDocumentGroupingType Grouping {
            get {
                return this.groupingField;
            }
            set {
                this.groupingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GroupingSpecified {
            get {
                return this.groupingFieldSpecified;
            }
            set {
                this.groupingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ShippingDocumentEMailDetail EMailDetail {
            get {
                return this.eMailDetailField;
            }
            set {
                this.eMailDetailField = value;
            }
        }
        
        /// <remarks/>
        public ShippingDocumentPrintDetail PrintDetail {
            get {
                return this.printDetailField;
            }
            set {
                this.printDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ShippingDocumentDispositionType {
        
        /// <remarks/>
        CONFIRMED,
        
        /// <remarks/>
        DEFERRED_QUEUED,
        
        /// <remarks/>
        DEFERRED_RETURNED,
        
        /// <remarks/>
        DEFERRED_STORED,
        
        /// <remarks/>
        EMAILED,
        
        /// <remarks/>
        QUEUED,
        
        /// <remarks/>
        RETURNED,
        
        /// <remarks/>
        STORED,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ShippingDocumentGroupingType {
        
        /// <remarks/>
        CONSOLIDATED_BY_DOCUMENT_TYPE,
        
        /// <remarks/>
        INDIVIDUAL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShippingDocumentEMailDetail {
        
        private ShippingDocumentEMailRecipient[] eMailRecipientsField;
        
        private ShippingDocumentEMailGroupingType groupingField;
        
        private bool groupingFieldSpecified;
        
        private Localization localizationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EMailRecipients")]
        public ShippingDocumentEMailRecipient[] EMailRecipients {
            get {
                return this.eMailRecipientsField;
            }
            set {
                this.eMailRecipientsField = value;
            }
        }
        
        /// <remarks/>
        public ShippingDocumentEMailGroupingType Grouping {
            get {
                return this.groupingField;
            }
            set {
                this.groupingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GroupingSpecified {
            get {
                return this.groupingFieldSpecified;
            }
            set {
                this.groupingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Localization Localization {
            get {
                return this.localizationField;
            }
            set {
                this.localizationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShippingDocumentEMailRecipient {
        
        private EMailNotificationRecipientType recipientTypeField;
        
        private bool recipientTypeFieldSpecified;
        
        private string addressField;
        
        /// <remarks/>
        public EMailNotificationRecipientType RecipientType {
            get {
                return this.recipientTypeField;
            }
            set {
                this.recipientTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecipientTypeSpecified {
            get {
                return this.recipientTypeFieldSpecified;
            }
            set {
                this.recipientTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum EMailNotificationRecipientType {
        
        /// <remarks/>
        BROKER,
        
        /// <remarks/>
        OTHER,
        
        /// <remarks/>
        RECIPIENT,
        
        /// <remarks/>
        SHIPPER,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ShippingDocumentEMailGroupingType {
        
        /// <remarks/>
        BY_RECIPIENT,
        
        /// <remarks/>
        NONE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShippingDocumentPrintDetail {
        
        private string printerIdField;
        
        /// <remarks/>
        public string PrinterId {
            get {
                return this.printerIdField;
            }
            set {
                this.printerIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class LinearMeasure {
        
        private decimal valueField;
        
        private bool valueFieldSpecified;
        
        private LinearUnits unitsField;
        
        private bool unitsFieldSpecified;
        
        /// <remarks/>
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueSpecified {
            get {
                return this.valueFieldSpecified;
            }
            set {
                this.valueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public LinearUnits Units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitsSpecified {
            get {
                return this.unitsFieldSpecified;
            }
            set {
                this.unitsFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ShippingDocumentImageType {
        
        /// <remarks/>
        EPL2,
        
        /// <remarks/>
        PDF,
        
        /// <remarks/>
        PNG,
        
        /// <remarks/>
        ZPLII,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ShippingDocumentStockType {
        
        /// <remarks/>
        OP_900_LG_B,
        
        /// <remarks/>
        OP_900_LL_B,
        
        /// <remarks/>
        PAPER_4X6,
        
        /// <remarks/>
        PAPER_LETTER,
        
        /// <remarks/>
        STOCK_4X6,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("STOCK_4X6.75_LEADING_DOC_TAB")]
        STOCK_4X675_LEADING_DOC_TAB,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("STOCK_4X6.75_TRAILING_DOC_TAB")]
        STOCK_4X675_TRAILING_DOC_TAB,
        
        /// <remarks/>
        STOCK_4X8,
        
        /// <remarks/>
        STOCK_4X9_LEADING_DOC_TAB,
        
        /// <remarks/>
        STOCK_4X9_TRAILING_DOC_TAB,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum DocumentFormatOptionType {
        
        /// <remarks/>
        SUPPRESS_ADDITIONAL_LANGUAGES,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class FreightAddressLabelDetail {
        
        private ShippingDocumentFormat formatField;
        
        private string copiesField;
        
        private PageQuadrantType startingPositionField;
        
        private bool startingPositionFieldSpecified;
        
        private DocTabContent docTabContentField;
        
        private RelativeVerticalPositionType customContentPositionField;
        
        private bool customContentPositionFieldSpecified;
        
        private CustomLabelDetail customContentField;
        
        /// <remarks/>
        public ShippingDocumentFormat Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string Copies {
            get {
                return this.copiesField;
            }
            set {
                this.copiesField = value;
            }
        }
        
        /// <remarks/>
        public PageQuadrantType StartingPosition {
            get {
                return this.startingPositionField;
            }
            set {
                this.startingPositionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartingPositionSpecified {
            get {
                return this.startingPositionFieldSpecified;
            }
            set {
                this.startingPositionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DocTabContent DocTabContent {
            get {
                return this.docTabContentField;
            }
            set {
                this.docTabContentField = value;
            }
        }
        
        /// <remarks/>
        public RelativeVerticalPositionType CustomContentPosition {
            get {
                return this.customContentPositionField;
            }
            set {
                this.customContentPositionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CustomContentPositionSpecified {
            get {
                return this.customContentPositionFieldSpecified;
            }
            set {
                this.customContentPositionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CustomLabelDetail CustomContent {
            get {
                return this.customContentField;
            }
            set {
                this.customContentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum PageQuadrantType {
        
        /// <remarks/>
        BOTTOM_LEFT,
        
        /// <remarks/>
        BOTTOM_RIGHT,
        
        /// <remarks/>
        TOP_LEFT,
        
        /// <remarks/>
        TOP_RIGHT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class DocTabContent {
        
        private DocTabContentType docTabContentTypeField;
        
        private bool docTabContentTypeFieldSpecified;
        
        private DocTabZoneSpecification[] zone001Field;
        
        private DocTabContentBarcoded barcodedField;
        
        /// <remarks/>
        public DocTabContentType DocTabContentType {
            get {
                return this.docTabContentTypeField;
            }
            set {
                this.docTabContentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocTabContentTypeSpecified {
            get {
                return this.docTabContentTypeFieldSpecified;
            }
            set {
                this.docTabContentTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DocTabZoneSpecifications", IsNullable=false)]
        public DocTabZoneSpecification[] Zone001 {
            get {
                return this.zone001Field;
            }
            set {
                this.zone001Field = value;
            }
        }
        
        /// <remarks/>
        public DocTabContentBarcoded Barcoded {
            get {
                return this.barcodedField;
            }
            set {
                this.barcodedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum DocTabContentType {
        
        /// <remarks/>
        BARCODED,
        
        /// <remarks/>
        CUSTOM,
        
        /// <remarks/>
        MINIMUM,
        
        /// <remarks/>
        STANDARD,
        
        /// <remarks/>
        ZONE001,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class DocTabZoneSpecification {
        
        private string zoneNumberField;
        
        private string headerField;
        
        private string dataFieldField;
        
        private string literalValueField;
        
        private DocTabZoneJustificationType justificationField;
        
        private bool justificationFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string ZoneNumber {
            get {
                return this.zoneNumberField;
            }
            set {
                this.zoneNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Header {
            get {
                return this.headerField;
            }
            set {
                this.headerField = value;
            }
        }
        
        /// <remarks/>
        public string DataField {
            get {
                return this.dataFieldField;
            }
            set {
                this.dataFieldField = value;
            }
        }
        
        /// <remarks/>
        public string LiteralValue {
            get {
                return this.literalValueField;
            }
            set {
                this.literalValueField = value;
            }
        }
        
        /// <remarks/>
        public DocTabZoneJustificationType Justification {
            get {
                return this.justificationField;
            }
            set {
                this.justificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool JustificationSpecified {
            get {
                return this.justificationFieldSpecified;
            }
            set {
                this.justificationFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum DocTabZoneJustificationType {
        
        /// <remarks/>
        LEFT,
        
        /// <remarks/>
        RIGHT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class DocTabContentBarcoded {
        
        private BarcodeSymbologyType symbologyField;
        
        private bool symbologyFieldSpecified;
        
        private DocTabZoneSpecification specificationField;
        
        /// <remarks/>
        public BarcodeSymbologyType Symbology {
            get {
                return this.symbologyField;
            }
            set {
                this.symbologyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SymbologySpecified {
            get {
                return this.symbologyFieldSpecified;
            }
            set {
                this.symbologyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DocTabZoneSpecification Specification {
            get {
                return this.specificationField;
            }
            set {
                this.specificationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum BarcodeSymbologyType {
        
        /// <remarks/>
        CODABAR,
        
        /// <remarks/>
        CODE128,
        
        /// <remarks/>
        CODE128B,
        
        /// <remarks/>
        CODE128C,
        
        /// <remarks/>
        CODE128_WIDEBAR,
        
        /// <remarks/>
        CODE39,
        
        /// <remarks/>
        CODE93,
        
        /// <remarks/>
        I2OF5,
        
        /// <remarks/>
        MANUAL,
        
        /// <remarks/>
        PDF417,
        
        /// <remarks/>
        POSTNET,
        
        /// <remarks/>
        QR_CODE,
        
        /// <remarks/>
        UCC128,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RelativeVerticalPositionType {
        
        /// <remarks/>
        ABOVE,
        
        /// <remarks/>
        BELOW,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CustomLabelDetail {
        
        private CustomLabelCoordinateUnits coordinateUnitsField;
        
        private bool coordinateUnitsFieldSpecified;
        
        private CustomLabelTextEntry[] textEntriesField;
        
        private CustomLabelGraphicEntry[] graphicEntriesField;
        
        private CustomLabelBoxEntry[] boxEntriesField;
        
        private CustomLabelTextBoxEntry[] textBoxEntriesField;
        
        private CustomLabelBarcodeEntry[] barcodeEntriesField;
        
        /// <remarks/>
        public CustomLabelCoordinateUnits CoordinateUnits {
            get {
                return this.coordinateUnitsField;
            }
            set {
                this.coordinateUnitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CoordinateUnitsSpecified {
            get {
                return this.coordinateUnitsFieldSpecified;
            }
            set {
                this.coordinateUnitsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TextEntries")]
        public CustomLabelTextEntry[] TextEntries {
            get {
                return this.textEntriesField;
            }
            set {
                this.textEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GraphicEntries")]
        public CustomLabelGraphicEntry[] GraphicEntries {
            get {
                return this.graphicEntriesField;
            }
            set {
                this.graphicEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BoxEntries")]
        public CustomLabelBoxEntry[] BoxEntries {
            get {
                return this.boxEntriesField;
            }
            set {
                this.boxEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TextBoxEntries")]
        public CustomLabelTextBoxEntry[] TextBoxEntries {
            get {
                return this.textBoxEntriesField;
            }
            set {
                this.textBoxEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BarcodeEntries")]
        public CustomLabelBarcodeEntry[] BarcodeEntries {
            get {
                return this.barcodeEntriesField;
            }
            set {
                this.barcodeEntriesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum CustomLabelCoordinateUnits {
        
        /// <remarks/>
        MILS,
        
        /// <remarks/>
        PIXELS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CustomLabelTextEntry {
        
        private CustomLabelPosition positionField;
        
        private string formatField;
        
        private string[] dataFieldsField;
        
        private string thermalFontIdField;
        
        private string fontNameField;
        
        private string fontSizeField;
        
        private RotationType rotationField;
        
        private bool rotationFieldSpecified;
        
        /// <remarks/>
        public CustomLabelPosition Position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
            }
        }
        
        /// <remarks/>
        public string Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataFields")]
        public string[] DataFields {
            get {
                return this.dataFieldsField;
            }
            set {
                this.dataFieldsField = value;
            }
        }
        
        /// <remarks/>
        public string ThermalFontId {
            get {
                return this.thermalFontIdField;
            }
            set {
                this.thermalFontIdField = value;
            }
        }
        
        /// <remarks/>
        public string FontName {
            get {
                return this.fontNameField;
            }
            set {
                this.fontNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string FontSize {
            get {
                return this.fontSizeField;
            }
            set {
                this.fontSizeField = value;
            }
        }
        
        /// <remarks/>
        public RotationType Rotation {
            get {
                return this.rotationField;
            }
            set {
                this.rotationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RotationSpecified {
            get {
                return this.rotationFieldSpecified;
            }
            set {
                this.rotationFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CustomLabelPosition {
        
        private string xField;
        
        private int yField;
        
        private bool yFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string X {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        public int Y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YSpecified {
            get {
                return this.yFieldSpecified;
            }
            set {
                this.yFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RotationType {
        
        /// <remarks/>
        LEFT,
        
        /// <remarks/>
        NONE,
        
        /// <remarks/>
        RIGHT,
        
        /// <remarks/>
        UPSIDE_DOWN,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CustomLabelGraphicEntry {
        
        private CustomLabelPosition positionField;
        
        private string printerGraphicIdField;
        
        private string fileGraphicFullNameField;
        
        /// <remarks/>
        public CustomLabelPosition Position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
            }
        }
        
        /// <remarks/>
        public string PrinterGraphicId {
            get {
                return this.printerGraphicIdField;
            }
            set {
                this.printerGraphicIdField = value;
            }
        }
        
        /// <remarks/>
        public string FileGraphicFullName {
            get {
                return this.fileGraphicFullNameField;
            }
            set {
                this.fileGraphicFullNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CustomLabelBoxEntry {
        
        private CustomLabelPosition topLeftCornerField;
        
        private CustomLabelPosition bottomRightCornerField;
        
        /// <remarks/>
        public CustomLabelPosition TopLeftCorner {
            get {
                return this.topLeftCornerField;
            }
            set {
                this.topLeftCornerField = value;
            }
        }
        
        /// <remarks/>
        public CustomLabelPosition BottomRightCorner {
            get {
                return this.bottomRightCornerField;
            }
            set {
                this.bottomRightCornerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CustomLabelTextBoxEntry {
        
        private CustomLabelPosition topLeftCornerField;
        
        private CustomLabelPosition bottomRightCornerField;
        
        private CustomLabelPosition positionField;
        
        private string formatField;
        
        private string[] dataFieldsField;
        
        private string thermalFontIdField;
        
        private string fontNameField;
        
        private string fontSizeField;
        
        private RotationType rotationField;
        
        private bool rotationFieldSpecified;
        
        /// <remarks/>
        public CustomLabelPosition TopLeftCorner {
            get {
                return this.topLeftCornerField;
            }
            set {
                this.topLeftCornerField = value;
            }
        }
        
        /// <remarks/>
        public CustomLabelPosition BottomRightCorner {
            get {
                return this.bottomRightCornerField;
            }
            set {
                this.bottomRightCornerField = value;
            }
        }
        
        /// <remarks/>
        public CustomLabelPosition Position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
            }
        }
        
        /// <remarks/>
        public string Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataFields")]
        public string[] DataFields {
            get {
                return this.dataFieldsField;
            }
            set {
                this.dataFieldsField = value;
            }
        }
        
        /// <remarks/>
        public string ThermalFontId {
            get {
                return this.thermalFontIdField;
            }
            set {
                this.thermalFontIdField = value;
            }
        }
        
        /// <remarks/>
        public string FontName {
            get {
                return this.fontNameField;
            }
            set {
                this.fontNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string FontSize {
            get {
                return this.fontSizeField;
            }
            set {
                this.fontSizeField = value;
            }
        }
        
        /// <remarks/>
        public RotationType Rotation {
            get {
                return this.rotationField;
            }
            set {
                this.rotationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RotationSpecified {
            get {
                return this.rotationFieldSpecified;
            }
            set {
                this.rotationFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CustomLabelBarcodeEntry {
        
        private CustomLabelPosition positionField;
        
        private string formatField;
        
        private string[] dataFieldsField;
        
        private int barHeightField;
        
        private bool barHeightFieldSpecified;
        
        private int thinBarWidthField;
        
        private bool thinBarWidthFieldSpecified;
        
        private BarcodeSymbologyType barcodeSymbologyField;
        
        private bool barcodeSymbologyFieldSpecified;
        
        /// <remarks/>
        public CustomLabelPosition Position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
            }
        }
        
        /// <remarks/>
        public string Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataFields")]
        public string[] DataFields {
            get {
                return this.dataFieldsField;
            }
            set {
                this.dataFieldsField = value;
            }
        }
        
        /// <remarks/>
        public int BarHeight {
            get {
                return this.barHeightField;
            }
            set {
                this.barHeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BarHeightSpecified {
            get {
                return this.barHeightFieldSpecified;
            }
            set {
                this.barHeightFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int ThinBarWidth {
            get {
                return this.thinBarWidthField;
            }
            set {
                this.thinBarWidthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThinBarWidthSpecified {
            get {
                return this.thinBarWidthFieldSpecified;
            }
            set {
                this.thinBarWidthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public BarcodeSymbologyType BarcodeSymbology {
            get {
                return this.barcodeSymbologyField;
            }
            set {
                this.barcodeSymbologyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BarcodeSymbologySpecified {
            get {
                return this.barcodeSymbologyFieldSpecified;
            }
            set {
                this.barcodeSymbologyFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class DangerousGoodsShippersDeclarationDetail {
        
        private ShippingDocumentFormat formatField;
        
        private CustomerImageUsage[] customerImageUsagesField;
        
        /// <remarks/>
        public ShippingDocumentFormat Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomerImageUsages")]
        public CustomerImageUsage[] CustomerImageUsages {
            get {
                return this.customerImageUsagesField;
            }
            set {
                this.customerImageUsagesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CustomerImageUsage {
        
        private CustomerImageUsageType typeField;
        
        private bool typeFieldSpecified;
        
        private ImageId idField;
        
        private bool idFieldSpecified;
        
        /// <remarks/>
        public CustomerImageUsageType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ImageId Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum CustomerImageUsageType {
        
        /// <remarks/>
        LETTER_HEAD,
        
        /// <remarks/>
        SIGNATURE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ImageId {
        
        /// <remarks/>
        IMAGE_1,
        
        /// <remarks/>
        IMAGE_2,
        
        /// <remarks/>
        IMAGE_3,
        
        /// <remarks/>
        IMAGE_4,
        
        /// <remarks/>
        IMAGE_5,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Op900Detail {
        
        private ShippingDocumentFormat formatField;
        
        private CustomerReferenceType referenceField;
        
        private bool referenceFieldSpecified;
        
        private CustomerImageUsage[] customerImageUsagesField;
        
        private string signatureNameField;
        
        /// <remarks/>
        public ShippingDocumentFormat Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        public CustomerReferenceType Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReferenceSpecified {
            get {
                return this.referenceFieldSpecified;
            }
            set {
                this.referenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomerImageUsages")]
        public CustomerImageUsage[] CustomerImageUsages {
            get {
                return this.customerImageUsagesField;
            }
            set {
                this.customerImageUsagesField = value;
            }
        }
        
        /// <remarks/>
        public string SignatureName {
            get {
                return this.signatureNameField;
            }
            set {
                this.signatureNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class NaftaProducer {
        
        private string idField;
        
        private Party producerField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public Party Producer {
            get {
                return this.producerField;
            }
            set {
                this.producerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class NaftaCertificateOfOriginDetail {
        
        private ShippingDocumentFormat formatField;
        
        private DateRange blanketPeriodField;
        
        private NaftaImporterSpecificationType importerSpecificationField;
        
        private bool importerSpecificationFieldSpecified;
        
        private Contact signatureContactField;
        
        private NaftaProducerSpecificationType producerSpecificationField;
        
        private bool producerSpecificationFieldSpecified;
        
        private NaftaProducer[] producersField;
        
        private CustomerImageUsage[] customerImageUsagesField;
        
        /// <remarks/>
        public ShippingDocumentFormat Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        public DateRange BlanketPeriod {
            get {
                return this.blanketPeriodField;
            }
            set {
                this.blanketPeriodField = value;
            }
        }
        
        /// <remarks/>
        public NaftaImporterSpecificationType ImporterSpecification {
            get {
                return this.importerSpecificationField;
            }
            set {
                this.importerSpecificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImporterSpecificationSpecified {
            get {
                return this.importerSpecificationFieldSpecified;
            }
            set {
                this.importerSpecificationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Contact SignatureContact {
            get {
                return this.signatureContactField;
            }
            set {
                this.signatureContactField = value;
            }
        }
        
        /// <remarks/>
        public NaftaProducerSpecificationType ProducerSpecification {
            get {
                return this.producerSpecificationField;
            }
            set {
                this.producerSpecificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProducerSpecificationSpecified {
            get {
                return this.producerSpecificationFieldSpecified;
            }
            set {
                this.producerSpecificationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Producers")]
        public NaftaProducer[] Producers {
            get {
                return this.producersField;
            }
            set {
                this.producersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomerImageUsages")]
        public CustomerImageUsage[] CustomerImageUsages {
            get {
                return this.customerImageUsagesField;
            }
            set {
                this.customerImageUsagesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class DateRange {
        
        private System.DateTime beginsField;
        
        private bool beginsFieldSpecified;
        
        private System.DateTime endsField;
        
        private bool endsFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Begins {
            get {
                return this.beginsField;
            }
            set {
                this.beginsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeginsSpecified {
            get {
                return this.beginsFieldSpecified;
            }
            set {
                this.beginsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Ends {
            get {
                return this.endsField;
            }
            set {
                this.endsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndsSpecified {
            get {
                return this.endsFieldSpecified;
            }
            set {
                this.endsFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum NaftaImporterSpecificationType {
        
        /// <remarks/>
        IMPORTER_OF_RECORD,
        
        /// <remarks/>
        RECIPIENT,
        
        /// <remarks/>
        UNKNOWN,
        
        /// <remarks/>
        VARIOUS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum NaftaProducerSpecificationType {
        
        /// <remarks/>
        AVAILABLE_UPON_REQUEST,
        
        /// <remarks/>
        MULTIPLE_SPECIFIED,
        
        /// <remarks/>
        SAME,
        
        /// <remarks/>
        SINGLE_SPECIFIED,
        
        /// <remarks/>
        UNKNOWN,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class GeneralAgencyAgreementDetail {
        
        private ShippingDocumentFormat formatField;
        
        /// <remarks/>
        public ShippingDocumentFormat Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ExportDeclarationDetail {
        
        private ShippingDocumentFormat documentFormatField;
        
        private CustomerImageUsage[] customerImageUsagesField;
        
        /// <remarks/>
        public ShippingDocumentFormat DocumentFormat {
            get {
                return this.documentFormatField;
            }
            set {
                this.documentFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomerImageUsages")]
        public CustomerImageUsage[] CustomerImageUsages {
            get {
                return this.customerImageUsagesField;
            }
            set {
                this.customerImageUsagesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CustomDocumentDetail {
        
        private ShippingDocumentFormat formatField;
        
        private LabelPrintingOrientationType labelPrintingOrientationField;
        
        private bool labelPrintingOrientationFieldSpecified;
        
        private LabelRotationType labelRotationField;
        
        private bool labelRotationFieldSpecified;
        
        private string specificationIdField;
        
        private CustomLabelDetail customContentField;
        
        /// <remarks/>
        public ShippingDocumentFormat Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        public LabelPrintingOrientationType LabelPrintingOrientation {
            get {
                return this.labelPrintingOrientationField;
            }
            set {
                this.labelPrintingOrientationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LabelPrintingOrientationSpecified {
            get {
                return this.labelPrintingOrientationFieldSpecified;
            }
            set {
                this.labelPrintingOrientationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public LabelRotationType LabelRotation {
            get {
                return this.labelRotationField;
            }
            set {
                this.labelRotationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LabelRotationSpecified {
            get {
                return this.labelRotationFieldSpecified;
            }
            set {
                this.labelRotationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string SpecificationId {
            get {
                return this.specificationIdField;
            }
            set {
                this.specificationIdField = value;
            }
        }
        
        /// <remarks/>
        public CustomLabelDetail CustomContent {
            get {
                return this.customContentField;
            }
            set {
                this.customContentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum LabelPrintingOrientationType {
        
        /// <remarks/>
        BOTTOM_EDGE_OF_TEXT_FIRST,
        
        /// <remarks/>
        TOP_EDGE_OF_TEXT_FIRST,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum LabelRotationType {
        
        /// <remarks/>
        LEFT,
        
        /// <remarks/>
        NONE,
        
        /// <remarks/>
        RIGHT,
        
        /// <remarks/>
        UPSIDE_DOWN,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CommercialInvoiceDetail {
        
        private ShippingDocumentFormat formatField;
        
        private CustomerImageUsage[] customerImageUsagesField;
        
        /// <remarks/>
        public ShippingDocumentFormat Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomerImageUsages")]
        public CustomerImageUsage[] CustomerImageUsages {
            get {
                return this.customerImageUsagesField;
            }
            set {
                this.customerImageUsagesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CertificateOfOriginDetail {
        
        private ShippingDocumentFormat documentFormatField;
        
        private CustomerImageUsage[] customerImageUsagesField;
        
        /// <remarks/>
        public ShippingDocumentFormat DocumentFormat {
            get {
                return this.documentFormatField;
            }
            set {
                this.documentFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomerImageUsages")]
        public CustomerImageUsage[] CustomerImageUsages {
            get {
                return this.customerImageUsagesField;
            }
            set {
                this.customerImageUsagesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShippingDocumentSpecification {
        
        private RequestedShippingDocumentType[] shippingDocumentTypesField;
        
        private CertificateOfOriginDetail certificateOfOriginField;
        
        private CommercialInvoiceDetail commercialInvoiceDetailField;
        
        private CustomDocumentDetail[] customPackageDocumentDetailField;
        
        private CustomDocumentDetail[] customShipmentDocumentDetailField;
        
        private ExportDeclarationDetail exportDeclarationDetailField;
        
        private GeneralAgencyAgreementDetail generalAgencyAgreementDetailField;
        
        private NaftaCertificateOfOriginDetail naftaCertificateOfOriginDetailField;
        
        private Op900Detail op900DetailField;
        
        private DangerousGoodsShippersDeclarationDetail dangerousGoodsShippersDeclarationDetailField;
        
        private FreightAddressLabelDetail freightAddressLabelDetailField;
        
        private ReturnInstructionsDetail returnInstructionsDetailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingDocumentTypes")]
        public RequestedShippingDocumentType[] ShippingDocumentTypes {
            get {
                return this.shippingDocumentTypesField;
            }
            set {
                this.shippingDocumentTypesField = value;
            }
        }
        
        /// <remarks/>
        public CertificateOfOriginDetail CertificateOfOrigin {
            get {
                return this.certificateOfOriginField;
            }
            set {
                this.certificateOfOriginField = value;
            }
        }
        
        /// <remarks/>
        public CommercialInvoiceDetail CommercialInvoiceDetail {
            get {
                return this.commercialInvoiceDetailField;
            }
            set {
                this.commercialInvoiceDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomPackageDocumentDetail")]
        public CustomDocumentDetail[] CustomPackageDocumentDetail {
            get {
                return this.customPackageDocumentDetailField;
            }
            set {
                this.customPackageDocumentDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomShipmentDocumentDetail")]
        public CustomDocumentDetail[] CustomShipmentDocumentDetail {
            get {
                return this.customShipmentDocumentDetailField;
            }
            set {
                this.customShipmentDocumentDetailField = value;
            }
        }
        
        /// <remarks/>
        public ExportDeclarationDetail ExportDeclarationDetail {
            get {
                return this.exportDeclarationDetailField;
            }
            set {
                this.exportDeclarationDetailField = value;
            }
        }
        
        /// <remarks/>
        public GeneralAgencyAgreementDetail GeneralAgencyAgreementDetail {
            get {
                return this.generalAgencyAgreementDetailField;
            }
            set {
                this.generalAgencyAgreementDetailField = value;
            }
        }
        
        /// <remarks/>
        public NaftaCertificateOfOriginDetail NaftaCertificateOfOriginDetail {
            get {
                return this.naftaCertificateOfOriginDetailField;
            }
            set {
                this.naftaCertificateOfOriginDetailField = value;
            }
        }
        
        /// <remarks/>
        public Op900Detail Op900Detail {
            get {
                return this.op900DetailField;
            }
            set {
                this.op900DetailField = value;
            }
        }
        
        /// <remarks/>
        public DangerousGoodsShippersDeclarationDetail DangerousGoodsShippersDeclarationDetail {
            get {
                return this.dangerousGoodsShippersDeclarationDetailField;
            }
            set {
                this.dangerousGoodsShippersDeclarationDetailField = value;
            }
        }
        
        /// <remarks/>
        public FreightAddressLabelDetail FreightAddressLabelDetail {
            get {
                return this.freightAddressLabelDetailField;
            }
            set {
                this.freightAddressLabelDetailField = value;
            }
        }
        
        /// <remarks/>
        public ReturnInstructionsDetail ReturnInstructionsDetail {
            get {
                return this.returnInstructionsDetailField;
            }
            set {
                this.returnInstructionsDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RequestedShippingDocumentType {
        
        /// <remarks/>
        CERTIFICATE_OF_ORIGIN,
        
        /// <remarks/>
        COMMERCIAL_INVOICE,
        
        /// <remarks/>
        CUSTOMER_SPECIFIED_LABELS,
        
        /// <remarks/>
        DANGEROUS_GOODS_SHIPPERS_DECLARATION,
        
        /// <remarks/>
        EXPORT_DECLARATION,
        
        /// <remarks/>
        GENERAL_AGENCY_AGREEMENT,
        
        /// <remarks/>
        LABEL,
        
        /// <remarks/>
        NAFTA_CERTIFICATE_OF_ORIGIN,
        
        /// <remarks/>
        PRO_FORMA_INVOICE,
        
        /// <remarks/>
        RETURN_INSTRUCTIONS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class AdditionalLabelsDetail {
        
        private AdditionalLabelsType typeField;
        
        private bool typeFieldSpecified;
        
        private string countField;
        
        /// <remarks/>
        public AdditionalLabelsType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum AdditionalLabelsType {
        
        /// <remarks/>
        BROKER,
        
        /// <remarks/>
        CONSIGNEE,
        
        /// <remarks/>
        CUSTOMS,
        
        /// <remarks/>
        DESTINATION,
        
        /// <remarks/>
        MANIFEST,
        
        /// <remarks/>
        ORIGIN,
        
        /// <remarks/>
        RECIPIENT,
        
        /// <remarks/>
        SHIPPER,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class RegulatoryLabelContentDetail {
        
        private RegulatoryLabelType typeField;
        
        private bool typeFieldSpecified;
        
        private CustomerSpecifiedLabelGenerationOptionType[] generationOptionsField;
        
        /// <remarks/>
        public RegulatoryLabelType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GenerationOptions")]
        public CustomerSpecifiedLabelGenerationOptionType[] GenerationOptions {
            get {
                return this.generationOptionsField;
            }
            set {
                this.generationOptionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RegulatoryLabelType {
        
        /// <remarks/>
        ALCOHOL_SHIPMENT_LABEL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum CustomerSpecifiedLabelGenerationOptionType {
        
        /// <remarks/>
        CONTENT_ON_SHIPPING_LABEL_ONLY,
        
        /// <remarks/>
        CONTENT_ON_SHIPPING_LABEL_PREFERRED,
        
        /// <remarks/>
        CONTENT_ON_SUPPLEMENTAL_LABEL_ONLY,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ConfigurableLabelReferenceEntry {
        
        private string zoneNumberField;
        
        private string headerField;
        
        private string dataFieldField;
        
        private string literalValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string ZoneNumber {
            get {
                return this.zoneNumberField;
            }
            set {
                this.zoneNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Header {
            get {
                return this.headerField;
            }
            set {
                this.headerField = value;
            }
        }
        
        /// <remarks/>
        public string DataField {
            get {
                return this.dataFieldField;
            }
            set {
                this.dataFieldField = value;
            }
        }
        
        /// <remarks/>
        public string LiteralValue {
            get {
                return this.literalValueField;
            }
            set {
                this.literalValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CustomerSpecifiedLabelDetail {
        
        private DocTabContent docTabContentField;
        
        private RelativeVerticalPositionType customContentPositionField;
        
        private bool customContentPositionFieldSpecified;
        
        private CustomLabelDetail customContentField;
        
        private ConfigurableLabelReferenceEntry[] configurableReferenceEntriesField;
        
        private LabelMaskableDataType[] maskedDataField;
        
        private SecondaryBarcodeType secondaryBarcodeField;
        
        private bool secondaryBarcodeFieldSpecified;
        
        private Localization termsAndConditionsLocalizationField;
        
        private RegulatoryLabelContentDetail[] regulatoryLabelsField;
        
        private AdditionalLabelsDetail[] additionalLabelsField;
        
        private string airWaybillSuppressionCountField;
        
        /// <remarks/>
        public DocTabContent DocTabContent {
            get {
                return this.docTabContentField;
            }
            set {
                this.docTabContentField = value;
            }
        }
        
        /// <remarks/>
        public RelativeVerticalPositionType CustomContentPosition {
            get {
                return this.customContentPositionField;
            }
            set {
                this.customContentPositionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CustomContentPositionSpecified {
            get {
                return this.customContentPositionFieldSpecified;
            }
            set {
                this.customContentPositionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CustomLabelDetail CustomContent {
            get {
                return this.customContentField;
            }
            set {
                this.customContentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConfigurableReferenceEntries")]
        public ConfigurableLabelReferenceEntry[] ConfigurableReferenceEntries {
            get {
                return this.configurableReferenceEntriesField;
            }
            set {
                this.configurableReferenceEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaskedData")]
        public LabelMaskableDataType[] MaskedData {
            get {
                return this.maskedDataField;
            }
            set {
                this.maskedDataField = value;
            }
        }
        
        /// <remarks/>
        public SecondaryBarcodeType SecondaryBarcode {
            get {
                return this.secondaryBarcodeField;
            }
            set {
                this.secondaryBarcodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SecondaryBarcodeSpecified {
            get {
                return this.secondaryBarcodeFieldSpecified;
            }
            set {
                this.secondaryBarcodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Localization TermsAndConditionsLocalization {
            get {
                return this.termsAndConditionsLocalizationField;
            }
            set {
                this.termsAndConditionsLocalizationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RegulatoryLabels")]
        public RegulatoryLabelContentDetail[] RegulatoryLabels {
            get {
                return this.regulatoryLabelsField;
            }
            set {
                this.regulatoryLabelsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalLabels")]
        public AdditionalLabelsDetail[] AdditionalLabels {
            get {
                return this.additionalLabelsField;
            }
            set {
                this.additionalLabelsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string AirWaybillSuppressionCount {
            get {
                return this.airWaybillSuppressionCountField;
            }
            set {
                this.airWaybillSuppressionCountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum LabelMaskableDataType {
        
        /// <remarks/>
        CUSTOMS_VALUE,
        
        /// <remarks/>
        DIMENSIONS,
        
        /// <remarks/>
        DUTIES_AND_TAXES_PAYOR_ACCOUNT_NUMBER,
        
        /// <remarks/>
        FREIGHT_PAYOR_ACCOUNT_NUMBER,
        
        /// <remarks/>
        PACKAGE_SEQUENCE_AND_COUNT,
        
        /// <remarks/>
        SECONDARY_BARCODE,
        
        /// <remarks/>
        SHIPPER_ACCOUNT_NUMBER,
        
        /// <remarks/>
        SUPPLEMENTAL_LABEL_DOC_TAB,
        
        /// <remarks/>
        TERMS_AND_CONDITIONS,
        
        /// <remarks/>
        TOTAL_WEIGHT,
        
        /// <remarks/>
        TRANSPORTATION_CHARGES_PAYOR_ACCOUNT_NUMBER,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum SecondaryBarcodeType {
        
        /// <remarks/>
        COMMON_2D,
        
        /// <remarks/>
        NONE,
        
        /// <remarks/>
        SSCC_18,
        
        /// <remarks/>
        USPS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class LabelSpecification {
        
        private LabelFormatType labelFormatTypeField;
        
        private bool labelFormatTypeFieldSpecified;
        
        private ShippingDocumentImageType imageTypeField;
        
        private bool imageTypeFieldSpecified;
        
        private LabelStockType labelStockTypeField;
        
        private bool labelStockTypeFieldSpecified;
        
        private LabelPrintingOrientationType labelPrintingOrientationField;
        
        private bool labelPrintingOrientationFieldSpecified;
        
        private LabelRotationType labelRotationField;
        
        private bool labelRotationFieldSpecified;
        
        private LabelOrderType labelOrderField;
        
        private bool labelOrderFieldSpecified;
        
        private ContactAndAddress printedLabelOriginField;
        
        private CustomerSpecifiedLabelDetail customerSpecifiedDetailField;
        
        /// <remarks/>
        public LabelFormatType LabelFormatType {
            get {
                return this.labelFormatTypeField;
            }
            set {
                this.labelFormatTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LabelFormatTypeSpecified {
            get {
                return this.labelFormatTypeFieldSpecified;
            }
            set {
                this.labelFormatTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ShippingDocumentImageType ImageType {
            get {
                return this.imageTypeField;
            }
            set {
                this.imageTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImageTypeSpecified {
            get {
                return this.imageTypeFieldSpecified;
            }
            set {
                this.imageTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public LabelStockType LabelStockType {
            get {
                return this.labelStockTypeField;
            }
            set {
                this.labelStockTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LabelStockTypeSpecified {
            get {
                return this.labelStockTypeFieldSpecified;
            }
            set {
                this.labelStockTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public LabelPrintingOrientationType LabelPrintingOrientation {
            get {
                return this.labelPrintingOrientationField;
            }
            set {
                this.labelPrintingOrientationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LabelPrintingOrientationSpecified {
            get {
                return this.labelPrintingOrientationFieldSpecified;
            }
            set {
                this.labelPrintingOrientationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public LabelRotationType LabelRotation {
            get {
                return this.labelRotationField;
            }
            set {
                this.labelRotationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LabelRotationSpecified {
            get {
                return this.labelRotationFieldSpecified;
            }
            set {
                this.labelRotationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public LabelOrderType LabelOrder {
            get {
                return this.labelOrderField;
            }
            set {
                this.labelOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LabelOrderSpecified {
            get {
                return this.labelOrderFieldSpecified;
            }
            set {
                this.labelOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ContactAndAddress PrintedLabelOrigin {
            get {
                return this.printedLabelOriginField;
            }
            set {
                this.printedLabelOriginField = value;
            }
        }
        
        /// <remarks/>
        public CustomerSpecifiedLabelDetail CustomerSpecifiedDetail {
            get {
                return this.customerSpecifiedDetailField;
            }
            set {
                this.customerSpecifiedDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum LabelFormatType {
        
        /// <remarks/>
        COMMON2D,
        
        /// <remarks/>
        LABEL_DATA_ONLY,
        
        /// <remarks/>
        MAILROOM,
        
        /// <remarks/>
        NO_LABEL,
        
        /// <remarks/>
        OPERATIONAL_LABEL,
        
        /// <remarks/>
        PRE_COMMON2D,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum LabelStockType {
        
        /// <remarks/>
        PAPER_4X6,
        
        /// <remarks/>
        PAPER_4X8,
        
        /// <remarks/>
        PAPER_4X9,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("PAPER_7X4.75")]
        PAPER_7X475,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("PAPER_8.5X11_BOTTOM_HALF_LABEL")]
        PAPER_85X11_BOTTOM_HALF_LABEL,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("PAPER_8.5X11_TOP_HALF_LABEL")]
        PAPER_85X11_TOP_HALF_LABEL,
        
        /// <remarks/>
        STOCK_4X6,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("STOCK_4X6.75_LEADING_DOC_TAB")]
        STOCK_4X675_LEADING_DOC_TAB,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("STOCK_4X6.75_TRAILING_DOC_TAB")]
        STOCK_4X675_TRAILING_DOC_TAB,
        
        /// <remarks/>
        STOCK_4X8,
        
        /// <remarks/>
        STOCK_4X9_LEADING_DOC_TAB,
        
        /// <remarks/>
        STOCK_4X9_TRAILING_DOC_TAB,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum LabelOrderType {
        
        /// <remarks/>
        SHIPPING_LABEL_FIRST,
        
        /// <remarks/>
        SHIPPING_LABEL_LAST,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class SmartPostShipmentDetail {
        
        private SmartPostShipmentProcessingOptionType[] processingOptionsRequestedField;
        
        private SmartPostIndiciaType indiciaField;
        
        private bool indiciaFieldSpecified;
        
        private SmartPostAncillaryEndorsementType ancillaryEndorsementField;
        
        private bool ancillaryEndorsementFieldSpecified;
        
        private string hubIdField;
        
        private string customerManifestIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Options", IsNullable=false)]
        public SmartPostShipmentProcessingOptionType[] ProcessingOptionsRequested {
            get {
                return this.processingOptionsRequestedField;
            }
            set {
                this.processingOptionsRequestedField = value;
            }
        }
        
        /// <remarks/>
        public SmartPostIndiciaType Indicia {
            get {
                return this.indiciaField;
            }
            set {
                this.indiciaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndiciaSpecified {
            get {
                return this.indiciaFieldSpecified;
            }
            set {
                this.indiciaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public SmartPostAncillaryEndorsementType AncillaryEndorsement {
            get {
                return this.ancillaryEndorsementField;
            }
            set {
                this.ancillaryEndorsementField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AncillaryEndorsementSpecified {
            get {
                return this.ancillaryEndorsementFieldSpecified;
            }
            set {
                this.ancillaryEndorsementFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string HubId {
            get {
                return this.hubIdField;
            }
            set {
                this.hubIdField = value;
            }
        }
        
        /// <remarks/>
        public string CustomerManifestId {
            get {
                return this.customerManifestIdField;
            }
            set {
                this.customerManifestIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum SmartPostShipmentProcessingOptionType {
        
        /// <remarks/>
        GROUND_TRACKING_NUMBER_REQUESTED,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum SmartPostAncillaryEndorsementType {
        
        /// <remarks/>
        ADDRESS_CORRECTION,
        
        /// <remarks/>
        CARRIER_LEAVE_IF_NO_RESPONSE,
        
        /// <remarks/>
        CHANGE_SERVICE,
        
        /// <remarks/>
        FORWARDING_SERVICE,
        
        /// <remarks/>
        RETURN_SERVICE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class PickupDetail {
        
        private System.DateTime readyDateTimeField;
        
        private bool readyDateTimeFieldSpecified;
        
        private System.DateTime latestPickupDateTimeField;
        
        private bool latestPickupDateTimeFieldSpecified;
        
        private string courierInstructionsField;
        
        private PickupRequestType requestTypeField;
        
        private bool requestTypeFieldSpecified;
        
        private PickupRequestSourceType requestSourceField;
        
        private bool requestSourceFieldSpecified;
        
        /// <remarks/>
        public System.DateTime ReadyDateTime {
            get {
                return this.readyDateTimeField;
            }
            set {
                this.readyDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReadyDateTimeSpecified {
            get {
                return this.readyDateTimeFieldSpecified;
            }
            set {
                this.readyDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime LatestPickupDateTime {
            get {
                return this.latestPickupDateTimeField;
            }
            set {
                this.latestPickupDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LatestPickupDateTimeSpecified {
            get {
                return this.latestPickupDateTimeFieldSpecified;
            }
            set {
                this.latestPickupDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string CourierInstructions {
            get {
                return this.courierInstructionsField;
            }
            set {
                this.courierInstructionsField = value;
            }
        }
        
        /// <remarks/>
        public PickupRequestType RequestType {
            get {
                return this.requestTypeField;
            }
            set {
                this.requestTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequestTypeSpecified {
            get {
                return this.requestTypeFieldSpecified;
            }
            set {
                this.requestTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PickupRequestSourceType RequestSource {
            get {
                return this.requestSourceField;
            }
            set {
                this.requestSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequestSourceSpecified {
            get {
                return this.requestSourceFieldSpecified;
            }
            set {
                this.requestSourceFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum PickupRequestType {
        
        /// <remarks/>
        FUTURE_DAY,
        
        /// <remarks/>
        SAME_DAY,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum PickupRequestSourceType {
        
        /// <remarks/>
        AUTOMATION,
        
        /// <remarks/>
        CUSTOMER_SERVICE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class DestinationControlDetail {
        
        private DestinationControlStatementType[] statementTypesField;
        
        private string destinationCountriesField;
        
        private string endUserField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StatementTypes")]
        public DestinationControlStatementType[] StatementTypes {
            get {
                return this.statementTypesField;
            }
            set {
                this.statementTypesField = value;
            }
        }
        
        /// <remarks/>
        public string DestinationCountries {
            get {
                return this.destinationCountriesField;
            }
            set {
                this.destinationCountriesField = value;
            }
        }
        
        /// <remarks/>
        public string EndUser {
            get {
                return this.endUserField;
            }
            set {
                this.endUserField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum DestinationControlStatementType {
        
        /// <remarks/>
        DEPARTMENT_OF_COMMERCE,
        
        /// <remarks/>
        DEPARTMENT_OF_STATE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ExportDetail {
        
        private B13AFilingOptionType b13AFilingOptionField;
        
        private bool b13AFilingOptionFieldSpecified;
        
        private string exportComplianceStatementField;
        
        private string permitNumberField;
        
        private DestinationControlDetail destinationControlDetailField;
        
        /// <remarks/>
        public B13AFilingOptionType B13AFilingOption {
            get {
                return this.b13AFilingOptionField;
            }
            set {
                this.b13AFilingOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool B13AFilingOptionSpecified {
            get {
                return this.b13AFilingOptionFieldSpecified;
            }
            set {
                this.b13AFilingOptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ExportComplianceStatement {
            get {
                return this.exportComplianceStatementField;
            }
            set {
                this.exportComplianceStatementField = value;
            }
        }
        
        /// <remarks/>
        public string PermitNumber {
            get {
                return this.permitNumberField;
            }
            set {
                this.permitNumberField = value;
            }
        }
        
        /// <remarks/>
        public DestinationControlDetail DestinationControlDetail {
            get {
                return this.destinationControlDetailField;
            }
            set {
                this.destinationControlDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum B13AFilingOptionType {
        
        /// <remarks/>
        FEDEX_TO_STAMP,
        
        /// <remarks/>
        FILED_ELECTRONICALLY,
        
        /// <remarks/>
        MANUALLY_ATTACHED,
        
        /// <remarks/>
        NOT_REQUIRED,
        
        /// <remarks/>
        SUMMARY_REPORTING,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class NaftaCommodityDetail {
        
        private NaftaPreferenceCriterionCode preferenceCriterionField;
        
        private bool preferenceCriterionFieldSpecified;
        
        private NaftaProducerDeterminationCode producerDeterminationField;
        
        private bool producerDeterminationFieldSpecified;
        
        private string producerIdField;
        
        private NaftaNetCostMethodCode netCostMethodField;
        
        private bool netCostMethodFieldSpecified;
        
        private DateRange netCostDateRangeField;
        
        /// <remarks/>
        public NaftaPreferenceCriterionCode PreferenceCriterion {
            get {
                return this.preferenceCriterionField;
            }
            set {
                this.preferenceCriterionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PreferenceCriterionSpecified {
            get {
                return this.preferenceCriterionFieldSpecified;
            }
            set {
                this.preferenceCriterionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public NaftaProducerDeterminationCode ProducerDetermination {
            get {
                return this.producerDeterminationField;
            }
            set {
                this.producerDeterminationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProducerDeterminationSpecified {
            get {
                return this.producerDeterminationFieldSpecified;
            }
            set {
                this.producerDeterminationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ProducerId {
            get {
                return this.producerIdField;
            }
            set {
                this.producerIdField = value;
            }
        }
        
        /// <remarks/>
        public NaftaNetCostMethodCode NetCostMethod {
            get {
                return this.netCostMethodField;
            }
            set {
                this.netCostMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NetCostMethodSpecified {
            get {
                return this.netCostMethodFieldSpecified;
            }
            set {
                this.netCostMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DateRange NetCostDateRange {
            get {
                return this.netCostDateRangeField;
            }
            set {
                this.netCostDateRangeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum NaftaPreferenceCriterionCode {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        F,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum NaftaProducerDeterminationCode {
        
        /// <remarks/>
        NO_1,
        
        /// <remarks/>
        NO_2,
        
        /// <remarks/>
        NO_3,
        
        /// <remarks/>
        YES,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum NaftaNetCostMethodCode {
        
        /// <remarks/>
        NC,
        
        /// <remarks/>
        NO,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class EdtExciseCondition {
        
        private string categoryField;
        
        private string valueField;
        
        /// <remarks/>
        public string Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Measure {
        
        private decimal quantityField;
        
        private bool quantityFieldSpecified;
        
        private string unitsField;
        
        /// <remarks/>
        public decimal Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySpecified {
            get {
                return this.quantityFieldSpecified;
            }
            set {
                this.quantityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Commodity {
        
        private string nameField;
        
        private string numberOfPiecesField;
        
        private string descriptionField;
        
        private CommodityPurposeType purposeField;
        
        private bool purposeFieldSpecified;
        
        private string countryOfManufactureField;
        
        private string harmonizedCodeField;
        
        private Weight weightField;
        
        private decimal quantityField;
        
        private bool quantityFieldSpecified;
        
        private string quantityUnitsField;
        
        private Measure[] additionalMeasuresField;
        
        private Money unitPriceField;
        
        private Money customsValueField;
        
        private EdtExciseCondition[] exciseConditionsField;
        
        private string exportLicenseNumberField;
        
        private System.DateTime exportLicenseExpirationDateField;
        
        private bool exportLicenseExpirationDateFieldSpecified;
        
        private string cIMarksAndNumbersField;
        
        private string partNumberField;
        
        private NaftaCommodityDetail naftaDetailField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string NumberOfPieces {
            get {
                return this.numberOfPiecesField;
            }
            set {
                this.numberOfPiecesField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public CommodityPurposeType Purpose {
            get {
                return this.purposeField;
            }
            set {
                this.purposeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PurposeSpecified {
            get {
                return this.purposeFieldSpecified;
            }
            set {
                this.purposeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string CountryOfManufacture {
            get {
                return this.countryOfManufactureField;
            }
            set {
                this.countryOfManufactureField = value;
            }
        }
        
        /// <remarks/>
        public string HarmonizedCode {
            get {
                return this.harmonizedCodeField;
            }
            set {
                this.harmonizedCodeField = value;
            }
        }
        
        /// <remarks/>
        public Weight Weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }
        
        /// <remarks/>
        public decimal Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySpecified {
            get {
                return this.quantityFieldSpecified;
            }
            set {
                this.quantityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string QuantityUnits {
            get {
                return this.quantityUnitsField;
            }
            set {
                this.quantityUnitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalMeasures")]
        public Measure[] AdditionalMeasures {
            get {
                return this.additionalMeasuresField;
            }
            set {
                this.additionalMeasuresField = value;
            }
        }
        
        /// <remarks/>
        public Money UnitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                this.unitPriceField = value;
            }
        }
        
        /// <remarks/>
        public Money CustomsValue {
            get {
                return this.customsValueField;
            }
            set {
                this.customsValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExciseConditions")]
        public EdtExciseCondition[] ExciseConditions {
            get {
                return this.exciseConditionsField;
            }
            set {
                this.exciseConditionsField = value;
            }
        }
        
        /// <remarks/>
        public string ExportLicenseNumber {
            get {
                return this.exportLicenseNumberField;
            }
            set {
                this.exportLicenseNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime ExportLicenseExpirationDate {
            get {
                return this.exportLicenseExpirationDateField;
            }
            set {
                this.exportLicenseExpirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExportLicenseExpirationDateSpecified {
            get {
                return this.exportLicenseExpirationDateFieldSpecified;
            }
            set {
                this.exportLicenseExpirationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string CIMarksAndNumbers {
            get {
                return this.cIMarksAndNumbersField;
            }
            set {
                this.cIMarksAndNumbersField = value;
            }
        }
        
        /// <remarks/>
        public string PartNumber {
            get {
                return this.partNumberField;
            }
            set {
                this.partNumberField = value;
            }
        }
        
        /// <remarks/>
        public NaftaCommodityDetail NaftaDetail {
            get {
                return this.naftaDetailField;
            }
            set {
                this.naftaDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum CommodityPurposeType {
        
        /// <remarks/>
        BUSINESS,
        
        /// <remarks/>
        CONSUMER,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CommercialInvoice {
        
        private string[] commentsField;
        
        private Money freightChargeField;
        
        private Money taxesOrMiscellaneousChargeField;
        
        private TaxesOrMiscellaneousChargeType taxesOrMiscellaneousChargeTypeField;
        
        private bool taxesOrMiscellaneousChargeTypeFieldSpecified;
        
        private Money packingCostsField;
        
        private Money handlingCostsField;
        
        private string specialInstructionsField;
        
        private string declarationStatementField;
        
        private string paymentTermsField;
        
        private PurposeOfShipmentType purposeField;
        
        private bool purposeFieldSpecified;
        
        private string originatorNameField;
        
        private string termsOfSaleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comments")]
        public string[] Comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
            }
        }
        
        /// <remarks/>
        public Money FreightCharge {
            get {
                return this.freightChargeField;
            }
            set {
                this.freightChargeField = value;
            }
        }
        
        /// <remarks/>
        public Money TaxesOrMiscellaneousCharge {
            get {
                return this.taxesOrMiscellaneousChargeField;
            }
            set {
                this.taxesOrMiscellaneousChargeField = value;
            }
        }
        
        /// <remarks/>
        public TaxesOrMiscellaneousChargeType TaxesOrMiscellaneousChargeType {
            get {
                return this.taxesOrMiscellaneousChargeTypeField;
            }
            set {
                this.taxesOrMiscellaneousChargeTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxesOrMiscellaneousChargeTypeSpecified {
            get {
                return this.taxesOrMiscellaneousChargeTypeFieldSpecified;
            }
            set {
                this.taxesOrMiscellaneousChargeTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money PackingCosts {
            get {
                return this.packingCostsField;
            }
            set {
                this.packingCostsField = value;
            }
        }
        
        /// <remarks/>
        public Money HandlingCosts {
            get {
                return this.handlingCostsField;
            }
            set {
                this.handlingCostsField = value;
            }
        }
        
        /// <remarks/>
        public string SpecialInstructions {
            get {
                return this.specialInstructionsField;
            }
            set {
                this.specialInstructionsField = value;
            }
        }
        
        /// <remarks/>
        public string DeclarationStatement {
            get {
                return this.declarationStatementField;
            }
            set {
                this.declarationStatementField = value;
            }
        }
        
        /// <remarks/>
        public string PaymentTerms {
            get {
                return this.paymentTermsField;
            }
            set {
                this.paymentTermsField = value;
            }
        }
        
        /// <remarks/>
        public PurposeOfShipmentType Purpose {
            get {
                return this.purposeField;
            }
            set {
                this.purposeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PurposeSpecified {
            get {
                return this.purposeFieldSpecified;
            }
            set {
                this.purposeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string OriginatorName {
            get {
                return this.originatorNameField;
            }
            set {
                this.originatorNameField = value;
            }
        }
        
        /// <remarks/>
        public string TermsOfSale {
            get {
                return this.termsOfSaleField;
            }
            set {
                this.termsOfSaleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum TaxesOrMiscellaneousChargeType {
        
        /// <remarks/>
        COMMISSIONS,
        
        /// <remarks/>
        DISCOUNTS,
        
        /// <remarks/>
        HANDLING_FEES,
        
        /// <remarks/>
        OTHER,
        
        /// <remarks/>
        ROYALTIES_AND_LICENSE_FEES,
        
        /// <remarks/>
        TAXES,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum PurposeOfShipmentType {
        
        /// <remarks/>
        GIFT,
        
        /// <remarks/>
        NOT_SOLD,
        
        /// <remarks/>
        PERSONAL_EFFECTS,
        
        /// <remarks/>
        REPAIR_AND_RETURN,
        
        /// <remarks/>
        SAMPLE,
        
        /// <remarks/>
        SOLD,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class RecipientCustomsId {
        
        private RecipientCustomsIdType typeField;
        
        private bool typeFieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        public RecipientCustomsIdType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RecipientCustomsIdType {
        
        /// <remarks/>
        COMPANY,
        
        /// <remarks/>
        INDIVIDUAL,
        
        /// <remarks/>
        PASSPORT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CustomsOptionDetail {
        
        private CustomsOptionType typeField;
        
        private bool typeFieldSpecified;
        
        private string descriptionField;
        
        /// <remarks/>
        public CustomsOptionType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum CustomsOptionType {
        
        /// <remarks/>
        COURTESY_RETURN_LABEL,
        
        /// <remarks/>
        EXHIBITION_TRADE_SHOW,
        
        /// <remarks/>
        FAULTY_ITEM,
        
        /// <remarks/>
        FOLLOWING_REPAIR,
        
        /// <remarks/>
        FOR_REPAIR,
        
        /// <remarks/>
        ITEM_FOR_LOAN,
        
        /// <remarks/>
        OTHER,
        
        /// <remarks/>
        REJECTED,
        
        /// <remarks/>
        REPLACEMENT,
        
        /// <remarks/>
        TRIAL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class BrokerDetail {
        
        private BrokerType typeField;
        
        private bool typeFieldSpecified;
        
        private Party brokerField;
        
        /// <remarks/>
        public BrokerType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Party Broker {
            get {
                return this.brokerField;
            }
            set {
                this.brokerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum BrokerType {
        
        /// <remarks/>
        EXPORT,
        
        /// <remarks/>
        IMPORT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CustomsClearanceDetail {
        
        private BrokerDetail[] brokersField;
        
        private ClearanceBrokerageType clearanceBrokerageField;
        
        private bool clearanceBrokerageFieldSpecified;
        
        private CustomsOptionDetail customsOptionsField;
        
        private Party importerOfRecordField;
        
        private RecipientCustomsId recipientCustomsIdField;
        
        private Payment dutiesPaymentField;
        
        private InternationalDocumentContentType documentContentField;
        
        private bool documentContentFieldSpecified;
        
        private Money customsValueField;
        
        private FreightOnValueType freightOnValueField;
        
        private bool freightOnValueFieldSpecified;
        
        private Money insuranceChargesField;
        
        private bool partiesToTransactionAreRelatedField;
        
        private bool partiesToTransactionAreRelatedFieldSpecified;
        
        private CommercialInvoice commercialInvoiceField;
        
        private Commodity[] commoditiesField;
        
        private ExportDetail exportDetailField;
        
        private RegulatoryControlType[] regulatoryControlsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Brokers")]
        public BrokerDetail[] Brokers {
            get {
                return this.brokersField;
            }
            set {
                this.brokersField = value;
            }
        }
        
        /// <remarks/>
        public ClearanceBrokerageType ClearanceBrokerage {
            get {
                return this.clearanceBrokerageField;
            }
            set {
                this.clearanceBrokerageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClearanceBrokerageSpecified {
            get {
                return this.clearanceBrokerageFieldSpecified;
            }
            set {
                this.clearanceBrokerageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CustomsOptionDetail CustomsOptions {
            get {
                return this.customsOptionsField;
            }
            set {
                this.customsOptionsField = value;
            }
        }
        
        /// <remarks/>
        public Party ImporterOfRecord {
            get {
                return this.importerOfRecordField;
            }
            set {
                this.importerOfRecordField = value;
            }
        }
        
        /// <remarks/>
        public RecipientCustomsId RecipientCustomsId {
            get {
                return this.recipientCustomsIdField;
            }
            set {
                this.recipientCustomsIdField = value;
            }
        }
        
        /// <remarks/>
        public Payment DutiesPayment {
            get {
                return this.dutiesPaymentField;
            }
            set {
                this.dutiesPaymentField = value;
            }
        }
        
        /// <remarks/>
        public InternationalDocumentContentType DocumentContent {
            get {
                return this.documentContentField;
            }
            set {
                this.documentContentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocumentContentSpecified {
            get {
                return this.documentContentFieldSpecified;
            }
            set {
                this.documentContentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money CustomsValue {
            get {
                return this.customsValueField;
            }
            set {
                this.customsValueField = value;
            }
        }
        
        /// <remarks/>
        public FreightOnValueType FreightOnValue {
            get {
                return this.freightOnValueField;
            }
            set {
                this.freightOnValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FreightOnValueSpecified {
            get {
                return this.freightOnValueFieldSpecified;
            }
            set {
                this.freightOnValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money InsuranceCharges {
            get {
                return this.insuranceChargesField;
            }
            set {
                this.insuranceChargesField = value;
            }
        }
        
        /// <remarks/>
        public bool PartiesToTransactionAreRelated {
            get {
                return this.partiesToTransactionAreRelatedField;
            }
            set {
                this.partiesToTransactionAreRelatedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PartiesToTransactionAreRelatedSpecified {
            get {
                return this.partiesToTransactionAreRelatedFieldSpecified;
            }
            set {
                this.partiesToTransactionAreRelatedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CommercialInvoice CommercialInvoice {
            get {
                return this.commercialInvoiceField;
            }
            set {
                this.commercialInvoiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Commodities")]
        public Commodity[] Commodities {
            get {
                return this.commoditiesField;
            }
            set {
                this.commoditiesField = value;
            }
        }
        
        /// <remarks/>
        public ExportDetail ExportDetail {
            get {
                return this.exportDetailField;
            }
            set {
                this.exportDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RegulatoryControls")]
        public RegulatoryControlType[] RegulatoryControls {
            get {
                return this.regulatoryControlsField;
            }
            set {
                this.regulatoryControlsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ClearanceBrokerageType {
        
        /// <remarks/>
        BROKER_INCLUSIVE,
        
        /// <remarks/>
        BROKER_INCLUSIVE_NON_RESIDENT_IMPORTER,
        
        /// <remarks/>
        BROKER_SELECT,
        
        /// <remarks/>
        BROKER_SELECT_NON_RESIDENT_IMPORTER,
        
        /// <remarks/>
        BROKER_UNASSIGNED,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Payment {
        
        private PaymentType paymentTypeField;
        
        private bool paymentTypeFieldSpecified;
        
        private Payor payorField;
        
        /// <remarks/>
        public PaymentType PaymentType {
            get {
                return this.paymentTypeField;
            }
            set {
                this.paymentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentTypeSpecified {
            get {
                return this.paymentTypeFieldSpecified;
            }
            set {
                this.paymentTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Payor Payor {
            get {
                return this.payorField;
            }
            set {
                this.payorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum PaymentType {
        
        /// <remarks/>
        SENDER,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Payor {
        
        private Party responsiblePartyField;
        
        /// <remarks/>
        public Party ResponsibleParty {
            get {
                return this.responsiblePartyField;
            }
            set {
                this.responsiblePartyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum FreightOnValueType {
        
        /// <remarks/>
        CARRIER_RISK,
        
        /// <remarks/>
        OWN_RISK,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RegulatoryControlType {
        
        /// <remarks/>
        EU_CIRCULATION,
        
        /// <remarks/>
        FOOD_OR_PERISHABLE,
        
        /// <remarks/>
        NAFTA,
        
        /// <remarks/>
        NOT_APPLICABLE_FOR_LOW_CUSTOMS_VALUE_EXCEPTION,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Volume {
        
        private VolumeUnits unitsField;
        
        private bool unitsFieldSpecified;
        
        private decimal valueField;
        
        private bool valueFieldSpecified;
        
        /// <remarks/>
        public VolumeUnits Units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitsSpecified {
            get {
                return this.unitsFieldSpecified;
            }
            set {
                this.unitsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueSpecified {
            get {
                return this.valueFieldSpecified;
            }
            set {
                this.valueFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum VolumeUnits {
        
        /// <remarks/>
        CUBIC_FT,
        
        /// <remarks/>
        CUBIC_M,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class FreightShipmentLineItem {
        
        private FreightClassType freightClassField;
        
        private bool freightClassFieldSpecified;
        
        private PhysicalPackagingType packagingField;
        
        private bool packagingFieldSpecified;
        
        private string piecesField;
        
        private string descriptionField;
        
        private Weight weightField;
        
        private Dimensions dimensionsField;
        
        private Volume volumeField;
        
        /// <remarks/>
        public FreightClassType FreightClass {
            get {
                return this.freightClassField;
            }
            set {
                this.freightClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FreightClassSpecified {
            get {
                return this.freightClassFieldSpecified;
            }
            set {
                this.freightClassFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PhysicalPackagingType Packaging {
            get {
                return this.packagingField;
            }
            set {
                this.packagingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackagingSpecified {
            get {
                return this.packagingFieldSpecified;
            }
            set {
                this.packagingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string Pieces {
            get {
                return this.piecesField;
            }
            set {
                this.piecesField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public Weight Weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }
        
        /// <remarks/>
        public Dimensions Dimensions {
            get {
                return this.dimensionsField;
            }
            set {
                this.dimensionsField = value;
            }
        }
        
        /// <remarks/>
        public Volume Volume {
            get {
                return this.volumeField;
            }
            set {
                this.volumeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class FreightSpecialServicePayment {
        
        private ShipmentSpecialServiceType specialServiceField;
        
        private bool specialServiceFieldSpecified;
        
        private FreightShipmentRoleType paymentTypeField;
        
        private bool paymentTypeFieldSpecified;
        
        /// <remarks/>
        public ShipmentSpecialServiceType SpecialService {
            get {
                return this.specialServiceField;
            }
            set {
                this.specialServiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SpecialServiceSpecified {
            get {
                return this.specialServiceFieldSpecified;
            }
            set {
                this.specialServiceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public FreightShipmentRoleType PaymentType {
            get {
                return this.paymentTypeField;
            }
            set {
                this.paymentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentTypeSpecified {
            get {
                return this.paymentTypeFieldSpecified;
            }
            set {
                this.paymentTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ShipmentSpecialServiceType {
        
        /// <remarks/>
        BROKER_SELECT_OPTION,
        
        /// <remarks/>
        CALL_BEFORE_DELIVERY,
        
        /// <remarks/>
        COD,
        
        /// <remarks/>
        CUSTOM_DELIVERY_WINDOW,
        
        /// <remarks/>
        CUT_FLOWERS,
        
        /// <remarks/>
        DANGEROUS_GOODS,
        
        /// <remarks/>
        DO_NOT_BREAK_DOWN_PALLETS,
        
        /// <remarks/>
        DO_NOT_STACK_PALLETS,
        
        /// <remarks/>
        DRY_ICE,
        
        /// <remarks/>
        EAST_COAST_SPECIAL,
        
        /// <remarks/>
        ELECTRONIC_TRADE_DOCUMENTS,
        
        /// <remarks/>
        EVENT_NOTIFICATION,
        
        /// <remarks/>
        EXTREME_LENGTH,
        
        /// <remarks/>
        FEDEX_ONE_RATE,
        
        /// <remarks/>
        FOOD,
        
        /// <remarks/>
        FREIGHT_GUARANTEE,
        
        /// <remarks/>
        FREIGHT_TO_COLLECT,
        
        /// <remarks/>
        FUTURE_DAY_SHIPMENT,
        
        /// <remarks/>
        HOLD_AT_LOCATION,
        
        /// <remarks/>
        HOME_DELIVERY_PREMIUM,
        
        /// <remarks/>
        INSIDE_DELIVERY,
        
        /// <remarks/>
        INSIDE_PICKUP,
        
        /// <remarks/>
        INTERNATIONAL_CONTROLLED_EXPORT_SERVICE,
        
        /// <remarks/>
        INTERNATIONAL_TRAFFIC_IN_ARMS_REGULATIONS,
        
        /// <remarks/>
        LIFTGATE_DELIVERY,
        
        /// <remarks/>
        LIFTGATE_PICKUP,
        
        /// <remarks/>
        LIMITED_ACCESS_DELIVERY,
        
        /// <remarks/>
        LIMITED_ACCESS_PICKUP,
        
        /// <remarks/>
        PENDING_SHIPMENT,
        
        /// <remarks/>
        PHARMACY_DELIVERY,
        
        /// <remarks/>
        POISON,
        
        /// <remarks/>
        PROTECTION_FROM_FREEZING,
        
        /// <remarks/>
        RETURNS_CLEARANCE,
        
        /// <remarks/>
        RETURN_SHIPMENT,
        
        /// <remarks/>
        SATURDAY_DELIVERY,
        
        /// <remarks/>
        SATURDAY_PICKUP,
        
        /// <remarks/>
        THIRD_PARTY_CONSIGNEE,
        
        /// <remarks/>
        TOP_LOAD,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum FreightShipmentRoleType {
        
        /// <remarks/>
        CONSIGNEE,
        
        /// <remarks/>
        SHIPPER,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class LiabilityCoverageDetail {
        
        private LiabilityCoverageType coverageTypeField;
        
        private bool coverageTypeFieldSpecified;
        
        private Money coverageAmountField;
        
        /// <remarks/>
        public LiabilityCoverageType CoverageType {
            get {
                return this.coverageTypeField;
            }
            set {
                this.coverageTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CoverageTypeSpecified {
            get {
                return this.coverageTypeFieldSpecified;
            }
            set {
                this.coverageTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money CoverageAmount {
            get {
                return this.coverageAmountField;
            }
            set {
                this.coverageAmountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum LiabilityCoverageType {
        
        /// <remarks/>
        NEW,
        
        /// <remarks/>
        USED_OR_RECONDITIONED,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class FreightShipmentDetail {
        
        private string fedExFreightAccountNumberField;
        
        private ContactAndAddress fedExFreightBillingContactAndAddressField;
        
        private Party alternateBillingField;
        
        private FreightShipmentRoleType roleField;
        
        private bool roleFieldSpecified;
        
        private FreightCollectTermsType collectTermsTypeField;
        
        private bool collectTermsTypeFieldSpecified;
        
        private Money declaredValuePerUnitField;
        
        private string declaredValueUnitsField;
        
        private LiabilityCoverageDetail liabilityCoverageDetailField;
        
        private string[] couponsField;
        
        private string totalHandlingUnitsField;
        
        private decimal clientDiscountPercentField;
        
        private bool clientDiscountPercentFieldSpecified;
        
        private Weight palletWeightField;
        
        private Dimensions shipmentDimensionsField;
        
        private string commentField;
        
        private FreightSpecialServicePayment[] specialServicePaymentsField;
        
        private string hazardousMaterialsOfferorField;
        
        private FreightShipmentLineItem[] lineItemsField;
        
        /// <remarks/>
        public string FedExFreightAccountNumber {
            get {
                return this.fedExFreightAccountNumberField;
            }
            set {
                this.fedExFreightAccountNumberField = value;
            }
        }
        
        /// <remarks/>
        public ContactAndAddress FedExFreightBillingContactAndAddress {
            get {
                return this.fedExFreightBillingContactAndAddressField;
            }
            set {
                this.fedExFreightBillingContactAndAddressField = value;
            }
        }
        
        /// <remarks/>
        public Party AlternateBilling {
            get {
                return this.alternateBillingField;
            }
            set {
                this.alternateBillingField = value;
            }
        }
        
        /// <remarks/>
        public FreightShipmentRoleType Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RoleSpecified {
            get {
                return this.roleFieldSpecified;
            }
            set {
                this.roleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public FreightCollectTermsType CollectTermsType {
            get {
                return this.collectTermsTypeField;
            }
            set {
                this.collectTermsTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CollectTermsTypeSpecified {
            get {
                return this.collectTermsTypeFieldSpecified;
            }
            set {
                this.collectTermsTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money DeclaredValuePerUnit {
            get {
                return this.declaredValuePerUnitField;
            }
            set {
                this.declaredValuePerUnitField = value;
            }
        }
        
        /// <remarks/>
        public string DeclaredValueUnits {
            get {
                return this.declaredValueUnitsField;
            }
            set {
                this.declaredValueUnitsField = value;
            }
        }
        
        /// <remarks/>
        public LiabilityCoverageDetail LiabilityCoverageDetail {
            get {
                return this.liabilityCoverageDetailField;
            }
            set {
                this.liabilityCoverageDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Coupons")]
        public string[] Coupons {
            get {
                return this.couponsField;
            }
            set {
                this.couponsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string TotalHandlingUnits {
            get {
                return this.totalHandlingUnitsField;
            }
            set {
                this.totalHandlingUnitsField = value;
            }
        }
        
        /// <remarks/>
        public decimal ClientDiscountPercent {
            get {
                return this.clientDiscountPercentField;
            }
            set {
                this.clientDiscountPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClientDiscountPercentSpecified {
            get {
                return this.clientDiscountPercentFieldSpecified;
            }
            set {
                this.clientDiscountPercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Weight PalletWeight {
            get {
                return this.palletWeightField;
            }
            set {
                this.palletWeightField = value;
            }
        }
        
        /// <remarks/>
        public Dimensions ShipmentDimensions {
            get {
                return this.shipmentDimensionsField;
            }
            set {
                this.shipmentDimensionsField = value;
            }
        }
        
        /// <remarks/>
        public string Comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialServicePayments")]
        public FreightSpecialServicePayment[] SpecialServicePayments {
            get {
                return this.specialServicePaymentsField;
            }
            set {
                this.specialServicePaymentsField = value;
            }
        }
        
        /// <remarks/>
        public string HazardousMaterialsOfferor {
            get {
                return this.hazardousMaterialsOfferorField;
            }
            set {
                this.hazardousMaterialsOfferorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LineItems")]
        public FreightShipmentLineItem[] LineItems {
            get {
                return this.lineItemsField;
            }
            set {
                this.lineItemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum FreightCollectTermsType {
        
        /// <remarks/>
        NON_RECOURSE_SHIPPER_SIGNED,
        
        /// <remarks/>
        STANDARD,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ExpressFreightDetailContact {
        
        private string nameField;
        
        private string phoneField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ExpressFreightDetail {
        
        private bool packingListEnclosedField;
        
        private bool packingListEnclosedFieldSpecified;
        
        private string shippersLoadAndCountField;
        
        private string bookingConfirmationNumberField;
        
        private bool referenceLabelRequestedField;
        
        private bool referenceLabelRequestedFieldSpecified;
        
        private ExpressFreightDetailContact beforeDeliveryContactField;
        
        private ExpressFreightDetailContact undeliverableContactField;
        
        /// <remarks/>
        public bool PackingListEnclosed {
            get {
                return this.packingListEnclosedField;
            }
            set {
                this.packingListEnclosedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackingListEnclosedSpecified {
            get {
                return this.packingListEnclosedFieldSpecified;
            }
            set {
                this.packingListEnclosedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string ShippersLoadAndCount {
            get {
                return this.shippersLoadAndCountField;
            }
            set {
                this.shippersLoadAndCountField = value;
            }
        }
        
        /// <remarks/>
        public string BookingConfirmationNumber {
            get {
                return this.bookingConfirmationNumberField;
            }
            set {
                this.bookingConfirmationNumberField = value;
            }
        }
        
        /// <remarks/>
        public bool ReferenceLabelRequested {
            get {
                return this.referenceLabelRequestedField;
            }
            set {
                this.referenceLabelRequestedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReferenceLabelRequestedSpecified {
            get {
                return this.referenceLabelRequestedFieldSpecified;
            }
            set {
                this.referenceLabelRequestedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ExpressFreightDetailContact BeforeDeliveryContact {
            get {
                return this.beforeDeliveryContactField;
            }
            set {
                this.beforeDeliveryContactField = value;
            }
        }
        
        /// <remarks/>
        public ExpressFreightDetailContact UndeliverableContact {
            get {
                return this.undeliverableContactField;
            }
            set {
                this.undeliverableContactField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class CustomDeliveryWindowDetail {
        
        private CustomDeliveryWindowType typeField;
        
        private bool typeFieldSpecified;
        
        private System.DateTime requestTimeField;
        
        private bool requestTimeFieldSpecified;
        
        private DateRange requestRangeField;
        
        private System.DateTime requestDateField;
        
        private bool requestDateFieldSpecified;
        
        /// <remarks/>
        public CustomDeliveryWindowType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public System.DateTime RequestTime {
            get {
                return this.requestTimeField;
            }
            set {
                this.requestTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequestTimeSpecified {
            get {
                return this.requestTimeFieldSpecified;
            }
            set {
                this.requestTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DateRange RequestRange {
            get {
                return this.requestRangeField;
            }
            set {
                this.requestRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime RequestDate {
            get {
                return this.requestDateField;
            }
            set {
                this.requestDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequestDateSpecified {
            get {
                return this.requestDateFieldSpecified;
            }
            set {
                this.requestDateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum CustomDeliveryWindowType {
        
        /// <remarks/>
        AFTER,
        
        /// <remarks/>
        BEFORE,
        
        /// <remarks/>
        BETWEEN,
        
        /// <remarks/>
        ON,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class UploadDocumentReferenceDetail {
        
        private string lineNumberField;
        
        private string customerReferenceField;
        
        private string descriptionField;
        
        private UploadDocumentProducerType documentProducerField;
        
        private bool documentProducerFieldSpecified;
        
        private UploadDocumentType documentTypeField;
        
        private bool documentTypeFieldSpecified;
        
        private string documentIdField;
        
        private UploadDocumentIdProducer documentIdProducerField;
        
        private bool documentIdProducerFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string LineNumber {
            get {
                return this.lineNumberField;
            }
            set {
                this.lineNumberField = value;
            }
        }
        
        /// <remarks/>
        public string CustomerReference {
            get {
                return this.customerReferenceField;
            }
            set {
                this.customerReferenceField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public UploadDocumentProducerType DocumentProducer {
            get {
                return this.documentProducerField;
            }
            set {
                this.documentProducerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocumentProducerSpecified {
            get {
                return this.documentProducerFieldSpecified;
            }
            set {
                this.documentProducerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public UploadDocumentType DocumentType {
            get {
                return this.documentTypeField;
            }
            set {
                this.documentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocumentTypeSpecified {
            get {
                return this.documentTypeFieldSpecified;
            }
            set {
                this.documentTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string DocumentId {
            get {
                return this.documentIdField;
            }
            set {
                this.documentIdField = value;
            }
        }
        
        /// <remarks/>
        public UploadDocumentIdProducer DocumentIdProducer {
            get {
                return this.documentIdProducerField;
            }
            set {
                this.documentIdProducerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocumentIdProducerSpecified {
            get {
                return this.documentIdProducerFieldSpecified;
            }
            set {
                this.documentIdProducerFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum UploadDocumentProducerType {
        
        /// <remarks/>
        CUSTOMER,
        
        /// <remarks/>
        FEDEX_CAFE,
        
        /// <remarks/>
        FEDEX_CLS,
        
        /// <remarks/>
        FEDEX_FIDT,
        
        /// <remarks/>
        FEDEX_FXRS,
        
        /// <remarks/>
        FEDEX_GSMW,
        
        /// <remarks/>
        FEDEX_GTM,
        
        /// <remarks/>
        OTHER,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum UploadDocumentType {
        
        /// <remarks/>
        CERTIFICATE_OF_ORIGIN,
        
        /// <remarks/>
        COMMERCIAL_INVOICE,
        
        /// <remarks/>
        ETD_LABEL,
        
        /// <remarks/>
        NAFTA_CERTIFICATE_OF_ORIGIN,
        
        /// <remarks/>
        OTHER,
        
        /// <remarks/>
        PRO_FORMA_INVOICE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum UploadDocumentIdProducer {
        
        /// <remarks/>
        CUSTOMER,
        
        /// <remarks/>
        FEDEX_CAFE,
        
        /// <remarks/>
        FEDEX_CSHP,
        
        /// <remarks/>
        FEDEX_FXRS,
        
        /// <remarks/>
        FEDEX_GSMW,
        
        /// <remarks/>
        FEDEX_GTM,
        
        /// <remarks/>
        FEDEX_INET,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class EtdDetail {
        
        private RequestedShippingDocumentType[] requestedDocumentCopiesField;
        
        private UploadDocumentReferenceDetail[] documentReferencesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestedDocumentCopies")]
        public RequestedShippingDocumentType[] RequestedDocumentCopies {
            get {
                return this.requestedDocumentCopiesField;
            }
            set {
                this.requestedDocumentCopiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReferences")]
        public UploadDocumentReferenceDetail[] DocumentReferences {
            get {
                return this.documentReferencesField;
            }
            set {
                this.documentReferencesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class FreightGuaranteeDetail {
        
        private FreightGuaranteeType typeField;
        
        private bool typeFieldSpecified;
        
        private System.DateTime dateField;
        
        private bool dateFieldSpecified;
        
        /// <remarks/>
        public FreightGuaranteeType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateSpecified {
            get {
                return this.dateFieldSpecified;
            }
            set {
                this.dateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class HomeDeliveryPremiumDetail {
        
        private HomeDeliveryPremiumType homeDeliveryPremiumTypeField;
        
        private bool homeDeliveryPremiumTypeFieldSpecified;
        
        private System.DateTime dateField;
        
        private bool dateFieldSpecified;
        
        private string phoneNumberField;
        
        /// <remarks/>
        public HomeDeliveryPremiumType HomeDeliveryPremiumType {
            get {
                return this.homeDeliveryPremiumTypeField;
            }
            set {
                this.homeDeliveryPremiumTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HomeDeliveryPremiumTypeSpecified {
            get {
                return this.homeDeliveryPremiumTypeFieldSpecified;
            }
            set {
                this.homeDeliveryPremiumTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateSpecified {
            get {
                return this.dateFieldSpecified;
            }
            set {
                this.dateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string PhoneNumber {
            get {
                return this.phoneNumberField;
            }
            set {
                this.phoneNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum HomeDeliveryPremiumType {
        
        /// <remarks/>
        APPOINTMENT,
        
        /// <remarks/>
        DATE_CERTAIN,
        
        /// <remarks/>
        EVENING,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShipmentDryIceDetail {
        
        private string packageCountField;
        
        private Weight totalWeightField;
        
        private ShipmentDryIceProcessingOptionType[] processingOptionsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string PackageCount {
            get {
                return this.packageCountField;
            }
            set {
                this.packageCountField = value;
            }
        }
        
        /// <remarks/>
        public Weight TotalWeight {
            get {
                return this.totalWeightField;
            }
            set {
                this.totalWeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Options", IsNullable=false)]
        public ShipmentDryIceProcessingOptionType[] ProcessingOptions {
            get {
                return this.processingOptionsField;
            }
            set {
                this.processingOptionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ShipmentDryIceProcessingOptionType {
        
        /// <remarks/>
        SHIPMENT_LEVEL_DRY_ICE_ONLY,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class InternationalTrafficInArmsRegulationsDetail {
        
        private string licenseOrExemptionNumberField;
        
        /// <remarks/>
        public string LicenseOrExemptionNumber {
            get {
                return this.licenseOrExemptionNumberField;
            }
            set {
                this.licenseOrExemptionNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class InternationalControlledExportDetail {
        
        private InternationalControlledExportType typeField;
        
        private bool typeFieldSpecified;
        
        private string foreignTradeZoneCodeField;
        
        private string entryNumberField;
        
        private string licenseOrPermitNumberField;
        
        private System.DateTime licenseOrPermitExpirationDateField;
        
        private bool licenseOrPermitExpirationDateFieldSpecified;
        
        /// <remarks/>
        public InternationalControlledExportType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ForeignTradeZoneCode {
            get {
                return this.foreignTradeZoneCodeField;
            }
            set {
                this.foreignTradeZoneCodeField = value;
            }
        }
        
        /// <remarks/>
        public string EntryNumber {
            get {
                return this.entryNumberField;
            }
            set {
                this.entryNumberField = value;
            }
        }
        
        /// <remarks/>
        public string LicenseOrPermitNumber {
            get {
                return this.licenseOrPermitNumberField;
            }
            set {
                this.licenseOrPermitNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime LicenseOrPermitExpirationDate {
            get {
                return this.licenseOrPermitExpirationDateField;
            }
            set {
                this.licenseOrPermitExpirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LicenseOrPermitExpirationDateSpecified {
            get {
                return this.licenseOrPermitExpirationDateFieldSpecified;
            }
            set {
                this.licenseOrPermitExpirationDateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum InternationalControlledExportType {
        
        /// <remarks/>
        DEA_036,
        
        /// <remarks/>
        DEA_236,
        
        /// <remarks/>
        DEA_486,
        
        /// <remarks/>
        DSP_05,
        
        /// <remarks/>
        DSP_61,
        
        /// <remarks/>
        DSP_73,
        
        /// <remarks/>
        DSP_85,
        
        /// <remarks/>
        DSP_94,
        
        /// <remarks/>
        DSP_LICENSE_AGREEMENT,
        
        /// <remarks/>
        FROM_FOREIGN_TRADE_ZONE,
        
        /// <remarks/>
        WAREHOUSE_WITHDRAWAL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class PendingShipmentDetail {
        
        private PendingShipmentType typeField;
        
        private bool typeFieldSpecified;
        
        private System.DateTime expirationDateField;
        
        private bool expirationDateFieldSpecified;
        
        private PendingShipmentProcessingOptionType[] processingOptionsField;
        
        private RecommendedDocumentType[] recommendedDocumentSpecificationField;
        
        /// <remarks/>
        public PendingShipmentType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime ExpirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpirationDateSpecified {
            get {
                return this.expirationDateFieldSpecified;
            }
            set {
                this.expirationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Options", IsNullable=false)]
        public PendingShipmentProcessingOptionType[] ProcessingOptions {
            get {
                return this.processingOptionsField;
            }
            set {
                this.processingOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Types", IsNullable=false)]
        public RecommendedDocumentType[] RecommendedDocumentSpecification {
            get {
                return this.recommendedDocumentSpecificationField;
            }
            set {
                this.recommendedDocumentSpecificationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum PendingShipmentType {
        
        /// <remarks/>
        EMAIL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum PendingShipmentProcessingOptionType {
        
        /// <remarks/>
        ALLOW_MODIFICATIONS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RecommendedDocumentType {
        
        /// <remarks/>
        ANTIQUE_STATEMENT_EUROPEAN_UNION,
        
        /// <remarks/>
        ANTIQUE_STATEMENT_UNITED_STATES,
        
        /// <remarks/>
        ASSEMBLER_DECLARATION,
        
        /// <remarks/>
        BEARING_WORKSHEET,
        
        /// <remarks/>
        CERTIFICATE_OF_SHIPMENTS_TO_SYRIA,
        
        /// <remarks/>
        COMMERCIAL_INVOICE_FOR_THE_CARIBBEAN_COMMON_MARKET,
        
        /// <remarks/>
        CONIFEROUS_SOLID_WOOD_PACKAGING_MATERIAL_TO_THE_PEOPLES_REPUBLIC_OF_CHINA,
        
        /// <remarks/>
        DECLARATION_FOR_FREE_ENTRY_OF_RETURNED_AMERICAN_PRODUCTS,
        
        /// <remarks/>
        DECLARATION_OF_BIOLOGICAL_STANDARDS,
        
        /// <remarks/>
        DECLARATION_OF_IMPORTED_ELECTRONIC_PRODUCTS_SUBJECT_TO_RADIATION_CONTROL_STANDARD,
        
        /// <remarks/>
        ELECTRONIC_INTEGRATED_CIRCUIT_WORKSHEET,
        
        /// <remarks/>
        FILM_AND_VIDEO_CERTIFICATE,
        
        /// <remarks/>
        INTERIM_FOOTWEAR_INVOICE,
        
        /// <remarks/>
        NAFTA_CERTIFICATE_OF_ORIGIN_CANADA_ENGLISH,
        
        /// <remarks/>
        NAFTA_CERTIFICATE_OF_ORIGIN_CANADA_FRENCH,
        
        /// <remarks/>
        NAFTA_CERTIFICATE_OF_ORIGIN_SPANISH,
        
        /// <remarks/>
        NAFTA_CERTIFICATE_OF_ORIGIN_UNITED_STATES,
        
        /// <remarks/>
        PACKING_LIST,
        
        /// <remarks/>
        PRINTED_CIRCUIT_BOARD_WORKSHEET,
        
        /// <remarks/>
        REPAIRED_WATCH_BREAKOUT_WORKSHEET,
        
        /// <remarks/>
        STATEMENT_REGARDING_THE_IMPORT_OF_RADIO_FREQUENCY_DEVICES,
        
        /// <remarks/>
        TOXIC_SUBSTANCES_CONTROL_ACT,
        
        /// <remarks/>
        UNITED_STATES_CARIBBEAN_BASIN_TRADE_PARTNERSHIP_ACT_CERTIFICATE_OF_ORIGIN_NON_TEXTILES,
        
        /// <remarks/>
        UNITED_STATES_CARIBBEAN_BASIN_TRADE_PARTNERSHIP_ACT_CERTIFICATE_OF_ORIGIN_TEXTILES,
        
        /// <remarks/>
        UNITED_STATES_NEW_WATCH_WORKSHEET,
        
        /// <remarks/>
        UNITED_STATES_WATCH_REPAIR_DECLARATION,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ReturnAssociationDetail {
        
        private string trackingNumberField;
        
        private System.DateTime shipDateField;
        
        private bool shipDateFieldSpecified;
        
        /// <remarks/>
        public string TrackingNumber {
            get {
                return this.trackingNumberField;
            }
            set {
                this.trackingNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime ShipDate {
            get {
                return this.shipDateField;
            }
            set {
                this.shipDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShipDateSpecified {
            get {
                return this.shipDateFieldSpecified;
            }
            set {
                this.shipDateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ReturnEMailDetail {
        
        private string merchantPhoneNumberField;
        
        private ReturnEMailAllowedSpecialServiceType[] allowedSpecialServicesField;
        
        /// <remarks/>
        public string MerchantPhoneNumber {
            get {
                return this.merchantPhoneNumberField;
            }
            set {
                this.merchantPhoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowedSpecialServices")]
        public ReturnEMailAllowedSpecialServiceType[] AllowedSpecialServices {
            get {
                return this.allowedSpecialServicesField;
            }
            set {
                this.allowedSpecialServicesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ReturnEMailAllowedSpecialServiceType {
        
        /// <remarks/>
        SATURDAY_DELIVERY,
        
        /// <remarks/>
        SATURDAY_PICKUP,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class Rma {
        
        private string reasonField;
        
        /// <remarks/>
        public string Reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ReturnShipmentDetail {
        
        private ReturnType returnTypeField;
        
        private bool returnTypeFieldSpecified;
        
        private Rma rmaField;
        
        private ReturnEMailDetail returnEMailDetailField;
        
        private ReturnAssociationDetail returnAssociationField;
        
        /// <remarks/>
        public ReturnType ReturnType {
            get {
                return this.returnTypeField;
            }
            set {
                this.returnTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnTypeSpecified {
            get {
                return this.returnTypeFieldSpecified;
            }
            set {
                this.returnTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Rma Rma {
            get {
                return this.rmaField;
            }
            set {
                this.rmaField = value;
            }
        }
        
        /// <remarks/>
        public ReturnEMailDetail ReturnEMailDetail {
            get {
                return this.returnEMailDetailField;
            }
            set {
                this.returnEMailDetailField = value;
            }
        }
        
        /// <remarks/>
        public ReturnAssociationDetail ReturnAssociation {
            get {
                return this.returnAssociationField;
            }
            set {
                this.returnAssociationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ReturnType {
        
        /// <remarks/>
        FEDEX_TAG,
        
        /// <remarks/>
        PENDING,
        
        /// <remarks/>
        PRINT_RETURN_LABEL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShipmentNotificationFormatSpecification {
        
        private NotificationFormatType typeField;
        
        private bool typeFieldSpecified;
        
        /// <remarks/>
        public NotificationFormatType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum NotificationFormatType {
        
        /// <remarks/>
        HTML,
        
        /// <remarks/>
        TEXT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class EMailDetail {
        
        private string emailAddressField;
        
        private string nameField;
        
        /// <remarks/>
        public string EmailAddress {
            get {
                return this.emailAddressField;
            }
            set {
                this.emailAddressField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class NotificationDetail {
        
        private NotificationType notificationTypeField;
        
        private bool notificationTypeFieldSpecified;
        
        private EMailDetail emailDetailField;
        
        private Localization localizationField;
        
        /// <remarks/>
        public NotificationType NotificationType {
            get {
                return this.notificationTypeField;
            }
            set {
                this.notificationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NotificationTypeSpecified {
            get {
                return this.notificationTypeFieldSpecified;
            }
            set {
                this.notificationTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public EMailDetail EmailDetail {
            get {
                return this.emailDetailField;
            }
            set {
                this.emailDetailField = value;
            }
        }
        
        /// <remarks/>
        public Localization Localization {
            get {
                return this.localizationField;
            }
            set {
                this.localizationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum NotificationType {
        
        /// <remarks/>
        EMAIL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShipmentEventNotificationSpecification {
        
        private ShipmentNotificationRoleType roleField;
        
        private bool roleFieldSpecified;
        
        private NotificationEventType[] eventsField;
        
        private NotificationDetail notificationDetailField;
        
        private ShipmentNotificationFormatSpecification formatSpecificationField;
        
        /// <remarks/>
        public ShipmentNotificationRoleType Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RoleSpecified {
            get {
                return this.roleFieldSpecified;
            }
            set {
                this.roleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Events")]
        public NotificationEventType[] Events {
            get {
                return this.eventsField;
            }
            set {
                this.eventsField = value;
            }
        }
        
        /// <remarks/>
        public NotificationDetail NotificationDetail {
            get {
                return this.notificationDetailField;
            }
            set {
                this.notificationDetailField = value;
            }
        }
        
        /// <remarks/>
        public ShipmentNotificationFormatSpecification FormatSpecification {
            get {
                return this.formatSpecificationField;
            }
            set {
                this.formatSpecificationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ShipmentNotificationRoleType {
        
        /// <remarks/>
        BROKER,
        
        /// <remarks/>
        OTHER,
        
        /// <remarks/>
        RECIPIENT,
        
        /// <remarks/>
        SHIPPER,
        
        /// <remarks/>
        THIRD_PARTY,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum NotificationEventType {
        
        /// <remarks/>
        ON_DELIVERY,
        
        /// <remarks/>
        ON_ESTIMATED_DELIVERY,
        
        /// <remarks/>
        ON_EXCEPTION,
        
        /// <remarks/>
        ON_SHIPMENT,
        
        /// <remarks/>
        ON_TENDER,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShipmentEventNotificationDetail {
        
        private ShipmentNotificationAggregationType aggregationTypeField;
        
        private bool aggregationTypeFieldSpecified;
        
        private string personalMessageField;
        
        private ShipmentEventNotificationSpecification[] eventNotificationsField;
        
        /// <remarks/>
        public ShipmentNotificationAggregationType AggregationType {
            get {
                return this.aggregationTypeField;
            }
            set {
                this.aggregationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AggregationTypeSpecified {
            get {
                return this.aggregationTypeFieldSpecified;
            }
            set {
                this.aggregationTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string PersonalMessage {
            get {
                return this.personalMessageField;
            }
            set {
                this.personalMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EventNotifications")]
        public ShipmentEventNotificationSpecification[] EventNotifications {
            get {
                return this.eventNotificationsField;
            }
            set {
                this.eventNotificationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ShipmentNotificationAggregationType {
        
        /// <remarks/>
        PER_PACKAGE,
        
        /// <remarks/>
        PER_SHIPMENT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class HoldAtLocationDetail {
        
        private string phoneNumberField;
        
        private ContactAndAddress locationContactAndAddressField;
        
        private FedExLocationType locationTypeField;
        
        private bool locationTypeFieldSpecified;
        
        private string locationIdField;
        
        private int locationNumberField;
        
        private bool locationNumberFieldSpecified;
        
        /// <remarks/>
        public string PhoneNumber {
            get {
                return this.phoneNumberField;
            }
            set {
                this.phoneNumberField = value;
            }
        }
        
        /// <remarks/>
        public ContactAndAddress LocationContactAndAddress {
            get {
                return this.locationContactAndAddressField;
            }
            set {
                this.locationContactAndAddressField = value;
            }
        }
        
        /// <remarks/>
        public FedExLocationType LocationType {
            get {
                return this.locationTypeField;
            }
            set {
                this.locationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LocationTypeSpecified {
            get {
                return this.locationTypeFieldSpecified;
            }
            set {
                this.locationTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string LocationId {
            get {
                return this.locationIdField;
            }
            set {
                this.locationIdField = value;
            }
        }
        
        /// <remarks/>
        public int LocationNumber {
            get {
                return this.locationNumberField;
            }
            set {
                this.locationNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LocationNumberSpecified {
            get {
                return this.locationNumberFieldSpecified;
            }
            set {
                this.locationNumberFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum FedExLocationType {
        
        /// <remarks/>
        FEDEX_EXPRESS_STATION,
        
        /// <remarks/>
        FEDEX_FACILITY,
        
        /// <remarks/>
        FEDEX_FREIGHT_SERVICE_CENTER,
        
        /// <remarks/>
        FEDEX_GROUND_TERMINAL,
        
        /// <remarks/>
        FEDEX_HOME_DELIVERY_STATION,
        
        /// <remarks/>
        FEDEX_OFFICE,
        
        /// <remarks/>
        FEDEX_SHIPSITE,
        
        /// <remarks/>
        FEDEX_SMART_POST_HUB,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class DeliveryOnInvoiceAcceptanceDetail {
        
        private Party recipientField;
        
        private TrackingId trackingIdField;
        
        /// <remarks/>
        public Party Recipient {
            get {
                return this.recipientField;
            }
            set {
                this.recipientField = value;
            }
        }
        
        /// <remarks/>
        public TrackingId TrackingId {
            get {
                return this.trackingIdField;
            }
            set {
                this.trackingIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShipmentSpecialServicesRequested {
        
        private ShipmentSpecialServiceType[] specialServiceTypesField;
        
        private CodDetail codDetailField;
        
        private DeliveryOnInvoiceAcceptanceDetail deliveryOnInvoiceAcceptanceDetailField;
        
        private HoldAtLocationDetail holdAtLocationDetailField;
        
        private ShipmentEventNotificationDetail eventNotificationDetailField;
        
        private ReturnShipmentDetail returnShipmentDetailField;
        
        private PendingShipmentDetail pendingShipmentDetailField;
        
        private InternationalControlledExportDetail internationalControlledExportDetailField;
        
        private InternationalTrafficInArmsRegulationsDetail internationalTrafficInArmsRegulationsDetailField;
        
        private ShipmentDryIceDetail shipmentDryIceDetailField;
        
        private HomeDeliveryPremiumDetail homeDeliveryPremiumDetailField;
        
        private FlatbedTrailerOption[] flatbedTrailerDetailField;
        
        private FreightGuaranteeDetail freightGuaranteeDetailField;
        
        private EtdDetail etdDetailField;
        
        private CustomDeliveryWindowDetail customDeliveryWindowDetailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialServiceTypes")]
        public ShipmentSpecialServiceType[] SpecialServiceTypes {
            get {
                return this.specialServiceTypesField;
            }
            set {
                this.specialServiceTypesField = value;
            }
        }
        
        /// <remarks/>
        public CodDetail CodDetail {
            get {
                return this.codDetailField;
            }
            set {
                this.codDetailField = value;
            }
        }
        
        /// <remarks/>
        public DeliveryOnInvoiceAcceptanceDetail DeliveryOnInvoiceAcceptanceDetail {
            get {
                return this.deliveryOnInvoiceAcceptanceDetailField;
            }
            set {
                this.deliveryOnInvoiceAcceptanceDetailField = value;
            }
        }
        
        /// <remarks/>
        public HoldAtLocationDetail HoldAtLocationDetail {
            get {
                return this.holdAtLocationDetailField;
            }
            set {
                this.holdAtLocationDetailField = value;
            }
        }
        
        /// <remarks/>
        public ShipmentEventNotificationDetail EventNotificationDetail {
            get {
                return this.eventNotificationDetailField;
            }
            set {
                this.eventNotificationDetailField = value;
            }
        }
        
        /// <remarks/>
        public ReturnShipmentDetail ReturnShipmentDetail {
            get {
                return this.returnShipmentDetailField;
            }
            set {
                this.returnShipmentDetailField = value;
            }
        }
        
        /// <remarks/>
        public PendingShipmentDetail PendingShipmentDetail {
            get {
                return this.pendingShipmentDetailField;
            }
            set {
                this.pendingShipmentDetailField = value;
            }
        }
        
        /// <remarks/>
        public InternationalControlledExportDetail InternationalControlledExportDetail {
            get {
                return this.internationalControlledExportDetailField;
            }
            set {
                this.internationalControlledExportDetailField = value;
            }
        }
        
        /// <remarks/>
        public InternationalTrafficInArmsRegulationsDetail InternationalTrafficInArmsRegulationsDetail {
            get {
                return this.internationalTrafficInArmsRegulationsDetailField;
            }
            set {
                this.internationalTrafficInArmsRegulationsDetailField = value;
            }
        }
        
        /// <remarks/>
        public ShipmentDryIceDetail ShipmentDryIceDetail {
            get {
                return this.shipmentDryIceDetailField;
            }
            set {
                this.shipmentDryIceDetailField = value;
            }
        }
        
        /// <remarks/>
        public HomeDeliveryPremiumDetail HomeDeliveryPremiumDetail {
            get {
                return this.homeDeliveryPremiumDetailField;
            }
            set {
                this.homeDeliveryPremiumDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Options", IsNullable=false)]
        public FlatbedTrailerOption[] FlatbedTrailerDetail {
            get {
                return this.flatbedTrailerDetailField;
            }
            set {
                this.flatbedTrailerDetailField = value;
            }
        }
        
        /// <remarks/>
        public FreightGuaranteeDetail FreightGuaranteeDetail {
            get {
                return this.freightGuaranteeDetailField;
            }
            set {
                this.freightGuaranteeDetailField = value;
            }
        }
        
        /// <remarks/>
        public EtdDetail EtdDetail {
            get {
                return this.etdDetailField;
            }
            set {
                this.etdDetailField = value;
            }
        }
        
        /// <remarks/>
        public CustomDeliveryWindowDetail CustomDeliveryWindowDetail {
            get {
                return this.customDeliveryWindowDetailField;
            }
            set {
                this.customDeliveryWindowDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum FlatbedTrailerOption {
        
        /// <remarks/>
        OVER_DIMENSION,
        
        /// <remarks/>
        TARP,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShipmentAuthorizationDetail {
        
        private string accountNumberField;
        
        /// <remarks/>
        public string AccountNumber {
            get {
                return this.accountNumberField;
            }
            set {
                this.accountNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ShipmentVariationOptionDetail {
        
        private string idField;
        
        private string[] valuesField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Values")]
        public string[] Values {
            get {
                return this.valuesField;
            }
            set {
                this.valuesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class RequestedShipment {
        
        private System.DateTime shipTimestampField;
        
        private bool shipTimestampFieldSpecified;
        
        private DropoffType dropoffTypeField;
        
        private bool dropoffTypeFieldSpecified;
        
        private ServiceType serviceTypeField;
        
        private bool serviceTypeFieldSpecified;
        
        private PackagingType packagingTypeField;
        
        private bool packagingTypeFieldSpecified;
        
        private ShipmentVariationOptionDetail[] variationOptionsField;
        
        private Weight totalWeightField;
        
        private Money totalInsuredValueField;
        
        private string preferredCurrencyField;
        
        private ShipmentAuthorizationDetail shipmentAuthorizationDetailField;
        
        private Party shipperField;
        
        private Party recipientField;
        
        private string recipientLocationNumberField;
        
        private ContactAndAddress originField;
        
        private Party soldToField;
        
        private Payment shippingChargesPaymentField;
        
        private ShipmentSpecialServicesRequested specialServicesRequestedField;
        
        private ExpressFreightDetail expressFreightDetailField;
        
        private FreightShipmentDetail freightShipmentDetailField;
        
        private string deliveryInstructionsField;
        
        private VariableHandlingChargeDetail variableHandlingChargeDetailField;
        
        private CustomsClearanceDetail customsClearanceDetailField;
        
        private PickupDetail pickupDetailField;
        
        private SmartPostShipmentDetail smartPostDetailField;
        
        private bool blockInsightVisibilityField;
        
        private bool blockInsightVisibilityFieldSpecified;
        
        private LabelSpecification labelSpecificationField;
        
        private ShippingDocumentSpecification shippingDocumentSpecificationField;
        
        private RateRequestType[] rateRequestTypesField;
        
        private EdtRequestType edtRequestTypeField;
        
        private bool edtRequestTypeFieldSpecified;
        
        private string packageCountField;
        
        private ShipmentOnlyFieldsType[] shipmentOnlyFieldsField;
        
        private DangerousGoodsDetail[] configurationDataField;
        
        private RequestedPackageLineItem[] requestedPackageLineItemsField;
        
        /// <remarks/>
        public System.DateTime ShipTimestamp {
            get {
                return this.shipTimestampField;
            }
            set {
                this.shipTimestampField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShipTimestampSpecified {
            get {
                return this.shipTimestampFieldSpecified;
            }
            set {
                this.shipTimestampFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DropoffType DropoffType {
            get {
                return this.dropoffTypeField;
            }
            set {
                this.dropoffTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DropoffTypeSpecified {
            get {
                return this.dropoffTypeFieldSpecified;
            }
            set {
                this.dropoffTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ServiceType ServiceType {
            get {
                return this.serviceTypeField;
            }
            set {
                this.serviceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServiceTypeSpecified {
            get {
                return this.serviceTypeFieldSpecified;
            }
            set {
                this.serviceTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PackagingType PackagingType {
            get {
                return this.packagingTypeField;
            }
            set {
                this.packagingTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackagingTypeSpecified {
            get {
                return this.packagingTypeFieldSpecified;
            }
            set {
                this.packagingTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VariationOptions")]
        public ShipmentVariationOptionDetail[] VariationOptions {
            get {
                return this.variationOptionsField;
            }
            set {
                this.variationOptionsField = value;
            }
        }
        
        /// <remarks/>
        public Weight TotalWeight {
            get {
                return this.totalWeightField;
            }
            set {
                this.totalWeightField = value;
            }
        }
        
        /// <remarks/>
        public Money TotalInsuredValue {
            get {
                return this.totalInsuredValueField;
            }
            set {
                this.totalInsuredValueField = value;
            }
        }
        
        /// <remarks/>
        public string PreferredCurrency {
            get {
                return this.preferredCurrencyField;
            }
            set {
                this.preferredCurrencyField = value;
            }
        }
        
        /// <remarks/>
        public ShipmentAuthorizationDetail ShipmentAuthorizationDetail {
            get {
                return this.shipmentAuthorizationDetailField;
            }
            set {
                this.shipmentAuthorizationDetailField = value;
            }
        }
        
        /// <remarks/>
        public Party Shipper {
            get {
                return this.shipperField;
            }
            set {
                this.shipperField = value;
            }
        }
        
        /// <remarks/>
        public Party Recipient {
            get {
                return this.recipientField;
            }
            set {
                this.recipientField = value;
            }
        }
        
        /// <remarks/>
        public string RecipientLocationNumber {
            get {
                return this.recipientLocationNumberField;
            }
            set {
                this.recipientLocationNumberField = value;
            }
        }
        
        /// <remarks/>
        public ContactAndAddress Origin {
            get {
                return this.originField;
            }
            set {
                this.originField = value;
            }
        }
        
        /// <remarks/>
        public Party SoldTo {
            get {
                return this.soldToField;
            }
            set {
                this.soldToField = value;
            }
        }
        
        /// <remarks/>
        public Payment ShippingChargesPayment {
            get {
                return this.shippingChargesPaymentField;
            }
            set {
                this.shippingChargesPaymentField = value;
            }
        }
        
        /// <remarks/>
        public ShipmentSpecialServicesRequested SpecialServicesRequested {
            get {
                return this.specialServicesRequestedField;
            }
            set {
                this.specialServicesRequestedField = value;
            }
        }
        
        /// <remarks/>
        public ExpressFreightDetail ExpressFreightDetail {
            get {
                return this.expressFreightDetailField;
            }
            set {
                this.expressFreightDetailField = value;
            }
        }
        
        /// <remarks/>
        public FreightShipmentDetail FreightShipmentDetail {
            get {
                return this.freightShipmentDetailField;
            }
            set {
                this.freightShipmentDetailField = value;
            }
        }
        
        /// <remarks/>
        public string DeliveryInstructions {
            get {
                return this.deliveryInstructionsField;
            }
            set {
                this.deliveryInstructionsField = value;
            }
        }
        
        /// <remarks/>
        public VariableHandlingChargeDetail VariableHandlingChargeDetail {
            get {
                return this.variableHandlingChargeDetailField;
            }
            set {
                this.variableHandlingChargeDetailField = value;
            }
        }
        
        /// <remarks/>
        public CustomsClearanceDetail CustomsClearanceDetail {
            get {
                return this.customsClearanceDetailField;
            }
            set {
                this.customsClearanceDetailField = value;
            }
        }
        
        /// <remarks/>
        public PickupDetail PickupDetail {
            get {
                return this.pickupDetailField;
            }
            set {
                this.pickupDetailField = value;
            }
        }
        
        /// <remarks/>
        public SmartPostShipmentDetail SmartPostDetail {
            get {
                return this.smartPostDetailField;
            }
            set {
                this.smartPostDetailField = value;
            }
        }
        
        /// <remarks/>
        public bool BlockInsightVisibility {
            get {
                return this.blockInsightVisibilityField;
            }
            set {
                this.blockInsightVisibilityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlockInsightVisibilitySpecified {
            get {
                return this.blockInsightVisibilityFieldSpecified;
            }
            set {
                this.blockInsightVisibilityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public LabelSpecification LabelSpecification {
            get {
                return this.labelSpecificationField;
            }
            set {
                this.labelSpecificationField = value;
            }
        }
        
        /// <remarks/>
        public ShippingDocumentSpecification ShippingDocumentSpecification {
            get {
                return this.shippingDocumentSpecificationField;
            }
            set {
                this.shippingDocumentSpecificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RateRequestTypes")]
        public RateRequestType[] RateRequestTypes {
            get {
                return this.rateRequestTypesField;
            }
            set {
                this.rateRequestTypesField = value;
            }
        }
        
        /// <remarks/>
        public EdtRequestType EdtRequestType {
            get {
                return this.edtRequestTypeField;
            }
            set {
                this.edtRequestTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EdtRequestTypeSpecified {
            get {
                return this.edtRequestTypeFieldSpecified;
            }
            set {
                this.edtRequestTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string PackageCount {
            get {
                return this.packageCountField;
            }
            set {
                this.packageCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentOnlyFields")]
        public ShipmentOnlyFieldsType[] ShipmentOnlyFields {
            get {
                return this.shipmentOnlyFieldsField;
            }
            set {
                this.shipmentOnlyFieldsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DangerousGoodsPackageConfigurations", IsNullable=false)]
        public DangerousGoodsDetail[] ConfigurationData {
            get {
                return this.configurationDataField;
            }
            set {
                this.configurationDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestedPackageLineItems")]
        public RequestedPackageLineItem[] RequestedPackageLineItems {
            get {
                return this.requestedPackageLineItemsField;
            }
            set {
                this.requestedPackageLineItemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum DropoffType {
        
        /// <remarks/>
        BUSINESS_SERVICE_CENTER,
        
        /// <remarks/>
        DROP_BOX,
        
        /// <remarks/>
        REGULAR_PICKUP,
        
        /// <remarks/>
        REQUEST_COURIER,
        
        /// <remarks/>
        STATION,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum RateRequestType {
        
        /// <remarks/>
        LIST,
        
        /// <remarks/>
        NONE,
        
        /// <remarks/>
        PREFERRED,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum EdtRequestType {
        
        /// <remarks/>
        ALL,
        
        /// <remarks/>
        NONE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ShipmentOnlyFieldsType {
        
        /// <remarks/>
        DIMENSIONS,
        
        /// <remarks/>
        INSURED_VALUE,
        
        /// <remarks/>
        WEIGHT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ConsolidationKey {
        
        private ConsolidationType typeField;
        
        private bool typeFieldSpecified;
        
        private string indexField;
        
        private System.DateTime dateField;
        
        private bool dateFieldSpecified;
        
        /// <remarks/>
        public ConsolidationType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateSpecified {
            get {
                return this.dateFieldSpecified;
            }
            set {
                this.dateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ConsolidationType {
        
        /// <remarks/>
        INTERNATIONAL_DISTRIBUTION_FREIGHT,
        
        /// <remarks/>
        INTERNATIONAL_ECONOMY_DISTRIBUTION,
        
        /// <remarks/>
        INTERNATIONAL_GROUND_DIRECT_DISTRIBUTION,
        
        /// <remarks/>
        INTERNATIONAL_GROUND_DISTRIBUTION,
        
        /// <remarks/>
        INTERNATIONAL_PRIORITY_DISTRIBUTION,
        
        /// <remarks/>
        TRANSBORDER_DISTRIBUTION,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public partial class ClientDetail {
        
        private string accountNumberField;
        
        private string meterNumberField;
        
        private string integratorIdField;
        
        private ExpressRegionCode regionField;
        
        private bool regionFieldSpecified;
        
        private Localization localizationField;
        
        /// <remarks/>
        public string AccountNumber {
            get {
                return this.accountNumberField;
            }
            set {
                this.accountNumberField = value;
            }
        }
        
        /// <remarks/>
        public string MeterNumber {
            get {
                return this.meterNumberField;
            }
            set {
                this.meterNumberField = value;
            }
        }
        
        /// <remarks/>
        public string IntegratorId {
            get {
                return this.integratorIdField;
            }
            set {
                this.integratorIdField = value;
            }
        }
        
        /// <remarks/>
        public ExpressRegionCode Region {
            get {
                return this.regionField;
            }
            set {
                this.regionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegionSpecified {
            get {
                return this.regionFieldSpecified;
            }
            set {
                this.regionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Localization Localization {
            get {
                return this.localizationField;
            }
            set {
                this.localizationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum ExpressRegionCode {
        
        /// <remarks/>
        APAC,
        
        /// <remarks/>
        CA,
        
        /// <remarks/>
        EMEA,
        
        /// <remarks/>
        LAC,
        
        /// <remarks/>
        US,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/rate/v20")]
    public enum CarrierCodeType {
        
        /// <remarks/>
        FDXC,
        
        /// <remarks/>
        FDXE,
        
        /// <remarks/>
        FDXG,
        
        /// <remarks/>
        FXCC,
        
        /// <remarks/>
        FXFR,
        
        /// <remarks/>
        FXSP,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void getRatesCompletedEventHandler(object sender, getRatesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getRatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getRatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RateReply Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RateReply)(this.results[0]));
            }
        }
    }
}