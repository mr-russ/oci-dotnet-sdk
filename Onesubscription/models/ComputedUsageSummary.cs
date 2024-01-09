/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.OnesubscriptionService.Models
{
    /// <summary>
    /// Computed Usage Summary object
    /// 
    /// </summary>
    public class ComputedUsageSummary 
    {
        
        /// <value>
        /// Computed Usage created time, expressed in RFC 3339 timestamp format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Computed Usage updated time, expressed in RFC 3339 timestamp format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Subscribed service line parent id
        /// 
        /// </value>
        [JsonProperty(PropertyName = "parentSubscribedServiceId")]
        public string ParentSubscribedServiceId { get; set; }
        
        [JsonProperty(PropertyName = "parentProduct")]
        public ComputedUsageProduct ParentProduct { get; set; }
        
        /// <value>
        /// Subscription plan number
        /// 
        /// </value>
        [JsonProperty(PropertyName = "planNumber")]
        public string PlanNumber { get; set; }
        
        /// <value>
        /// Currency code
        /// 
        /// </value>
        [JsonProperty(PropertyName = "currencyCode")]
        public string CurrencyCode { get; set; }
        
        /// <value>
        /// References the tier in the ratecard for that usage (OCI will be using the same reference to cross-reference for correctness on the usage csv report), comes from Entity OBSCNTR_IPT_PRODUCTTIER.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rateCardTierdId")]
        public string RateCardTierdId { get; set; }
        
        /// <value>
        /// Ratecard Id at subscribed service level
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rateCardId")]
        public string RateCardId { get; set; }
        
        /// <value>
        /// SPM Internal compute records source .
        /// 
        /// </value>
        [JsonProperty(PropertyName = "computeSource")]
        public string ComputeSource { get; set; }
        
        /// <value>
        /// Data Center Attribute as sent by MQS to SPM.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataCenter")]
        public string DataCenter { get; set; }
        
        /// <value>
        /// MQS Identfier send to SPM , SPM does not transform this attribute and is received as is.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "mqsMessageId")]
        public string MqsMessageId { get; set; }
        
        /// <value>
        /// SPM Internal computed usage Id , 32 character string
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComputedUsageId is required.")]
        [JsonProperty(PropertyName = "computedUsageId")]
        public string ComputedUsageId { get; set; }
        
        /// <value>
        /// Total Quantity that was used for computation
        /// 
        /// </value>
        [JsonProperty(PropertyName = "quantity")]
        public string Quantity { get; set; }
        
        /// <value>
        /// SPM Internal usage Line number identifier in SPM coming from Metered Services entity.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "usageNumber")]
        public string UsageNumber { get; set; }
        
        /// <value>
        /// SPM Internal Original usage Line number identifier in SPM coming from Metered Services entity.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "originalUsageNumber")]
        public string OriginalUsageNumber { get; set; }
        
        /// <value>
        /// Subscribed service commitmentId.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "commitmentServiceId")]
        public string CommitmentServiceId { get; set; }
        
        /// <value>
        /// Invoicing status for the aggregated compute usage
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isInvoiced")]
        public System.Nullable<bool> IsInvoiced { get; set; }
                ///
        /// <value>
        /// Usage compute type in SPM.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROMOTION")]
            Promotion,
            [EnumMember(Value = "DO_NOT_BILL")]
            DoNotBill,
            [EnumMember(Value = "USAGE")]
            Usage,
            [EnumMember(Value = "COMMIT")]
            Commit,
            [EnumMember(Value = "OVERAGE")]
            Overage,
            [EnumMember(Value = "PAY_AS_YOU_GO")]
            PayAsYouGo,
            [EnumMember(Value = "MONTHLY_MINIMUM")]
            MonthlyMinimum,
            [EnumMember(Value = "DELAYED_USAGE_INVOICE_TIMING")]
            DelayedUsageInvoiceTiming,
            [EnumMember(Value = "DELAYED_USAGE_COMMITMENT_EXP")]
            DelayedUsageCommitmentExp,
            [EnumMember(Value = "ON_ACCOUNT_CREDIT")]
            OnAccountCredit,
            [EnumMember(Value = "SERVICE_CREDIT")]
            ServiceCredit,
            [EnumMember(Value = "COMMITMENT_EXPIRATION")]
            CommitmentExpiration,
            [EnumMember(Value = "FUNDED_ALLOCATION")]
            FundedAllocation,
            [EnumMember(Value = "DONOT_BILL_USAGE_POST_TERMINATION")]
            DonotBillUsagePostTermination,
            [EnumMember(Value = "DELAYED_USAGE_POST_TERMINATION")]
            DelayedUsagePostTermination
        };

        /// <value>
        /// Usage compute type in SPM.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// Usae computation date, expressed in RFC 3339 timestamp format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeOfArrival")]
        public System.Nullable<System.DateTime> TimeOfArrival { get; set; }
        
        /// <value>
        /// Metered Service date, expressed in RFC 3339 timestamp format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeMeteredOn")]
        public System.Nullable<System.DateTime> TimeMeteredOn { get; set; }
        
        /// <value>
        /// Net Unit Price for the product in consideration, price actual.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "netUnitPrice")]
        public string NetUnitPrice { get; set; }
        
        /// <value>
        /// Computed Line Amount rounded.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "costRounded")]
        public string CostRounded { get; set; }
        
        /// <value>
        /// Computed Line Amount not rounded
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cost")]
        public string Cost { get; set; }
        
        [JsonProperty(PropertyName = "product")]
        public ComputedUsageProduct Product { get; set; }
        
        /// <value>
        /// Unit of Messure
        /// 
        /// </value>
        [JsonProperty(PropertyName = "unitOfMeasure")]
        public string UnitOfMeasure { get; set; }
        
    }
}
