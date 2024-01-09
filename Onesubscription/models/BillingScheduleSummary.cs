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
    /// Billing schedule details related to Subscription Id
    /// 
    /// </summary>
    public class BillingScheduleSummary 
    {
        
        /// <value>
        /// SPM internal Subscribed Service ID
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subscribedServiceId")]
        public string SubscribedServiceId { get; set; }
        
        /// <value>
        /// Billing schedule start date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// Billing schedule end date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// Billing schedule invoicing date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeInvoicing")]
        public System.Nullable<System.DateTime> TimeInvoicing { get; set; }
                ///
        /// <value>
        /// Billing schedule invoice status
        /// 
        /// </value>
        ///
        public enum InvoiceStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "INVOICED")]
            Invoiced,
            [EnumMember(Value = "NOT_INVOICED")]
            NotInvoiced
        };

        /// <value>
        /// Billing schedule invoice status
        /// 
        /// </value>
        [JsonProperty(PropertyName = "invoiceStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<InvoiceStatusEnum> InvoiceStatus { get; set; }
        
        /// <value>
        /// Billing schedule quantity
        /// 
        /// </value>
        [JsonProperty(PropertyName = "quantity")]
        public string Quantity { get; set; }
        
        /// <value>
        /// Billing schedule net unit price
        /// 
        /// </value>
        [JsonProperty(PropertyName = "netUnitPrice")]
        public string NetUnitPrice { get; set; }
        
        /// <value>
        /// Billing schedule line net amount
        /// 
        /// </value>
        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }
        
        /// <value>
        /// Billing frequency
        /// 
        /// </value>
        [JsonProperty(PropertyName = "billingFrequency")]
        public string BillingFrequency { get; set; }
        
        /// <value>
        /// Indicates the associated AR Invoice Number
        /// 
        /// </value>
        [JsonProperty(PropertyName = "arInvoiceNumber")]
        public string ArInvoiceNumber { get; set; }
        
        /// <value>
        /// Indicates the associated AR Customer transaction id a unique identifier existing on AR.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "arCustomerTransactionId")]
        public string ArCustomerTransactionId { get; set; }
        
        /// <value>
        /// Order number associated with the Subscribed Service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "orderNumber")]
        public string OrderNumber { get; set; }
        
        [JsonProperty(PropertyName = "product")]
        public BillingScheduleProduct Product { get; set; }
        
    }
}
