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


namespace Oci.UsageapiService.Models
{
    /// <summary>
    /// The filter object for query usage.
    /// </summary>
    public class Filter 
    {
                ///
        /// <value>
        /// The filter operator. Example: 'AND', 'OR', 'NOT'.
        /// </value>
        ///
        public enum OperatorEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AND")]
            And,
            [EnumMember(Value = "NOT")]
            Not,
            [EnumMember(Value = "OR")]
            Or
        };

        /// <value>
        /// The filter operator. Example: 'AND', 'OR', 'NOT'.
        /// </value>
        [JsonProperty(PropertyName = "operator")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperatorEnum> Operator { get; set; }
        
        /// <value>
        /// The dimensions to filter on.
        /// </value>
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.List<Dimension> Dimensions { get; set; }
        
        /// <value>
        /// The tags to filter on.
        /// </value>
        [JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.List<Tag> Tags { get; set; }
        
        /// <value>
        /// The nested filter object.
        /// </value>
        [JsonProperty(PropertyName = "filters")]
        public System.Collections.Generic.List<Filter> Filters { get; set; }
        
    }
}
