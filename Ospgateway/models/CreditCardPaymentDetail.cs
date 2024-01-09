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


namespace Oci.OspgatewayService.Models
{
    /// <summary>
    /// Credit card Payment related details
    /// </summary>
    public class CreditCardPaymentDetail : PaymentDetail
    {
        
        /// <value>
        /// Name on the credit card
        /// </value>
        [JsonProperty(PropertyName = "nameOnCard")]
        public string NameOnCard { get; set; }
                ///
        /// <value>
        /// Credit card type
        /// </value>
        ///
        public enum CreditCardTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "VISA")]
            Visa,
            [EnumMember(Value = "AMEX")]
            Amex,
            [EnumMember(Value = "MASTERCARD")]
            Mastercard,
            [EnumMember(Value = "DISCOVER")]
            Discover,
            [EnumMember(Value = "JCB")]
            Jcb,
            [EnumMember(Value = "DINER")]
            Diner,
            [EnumMember(Value = "ELO")]
            Elo
        };

        /// <value>
        /// Credit card type
        /// </value>
        [JsonProperty(PropertyName = "creditCardType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CreditCardTypeEnum> CreditCardType { get; set; }
        
        /// <value>
        /// Last four digits of the card
        /// </value>
        [JsonProperty(PropertyName = "lastDigits")]
        public string LastDigits { get; set; }
        
        /// <value>
        /// Expired date of the credit card
        /// </value>
        [JsonProperty(PropertyName = "timeExpiration")]
        public System.Nullable<System.DateTime> TimeExpiration { get; set; }
        
        [JsonProperty(PropertyName = "paymentMethod")]
        private readonly string paymentMethod = "CREDIT_CARD";
    }
}
