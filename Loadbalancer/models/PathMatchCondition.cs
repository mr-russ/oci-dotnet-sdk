/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// The path string and match condition to apply when evaluating an incoming URI for redirection.
    /// 
    /// </summary>
    public class PathMatchCondition : RuleCondition
    {
        
        /// <value>
        /// The path string that the redirection rule applies to.
        /// <br/>
        /// Example: /example
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttributeValue is required.")]
        [JsonProperty(PropertyName = "attributeValue")]
        public string AttributeValue { get; set; }
                ///
        /// <value>
        /// A string that specifies how to compare the PathMatchCondition object's `attributeValue` string to the
        /// incoming URI.
        /// <br/>
        /// *  **EXACT_MATCH** - The incoming URI path must exactly and completely match the `attributeValue` string.
        /// <br/>
        /// *  **FORCE_LONGEST_PREFIX_MATCH** - The system looks for the `attributeValue` string with the best,
        ///    longest match of the beginning portion of the incoming URI path.
        /// <br/>
        /// *  **PREFIX_MATCH** - The beginning portion of the incoming URI path must exactly match the
        ///    `attributeValue` string.
        /// <br/>
        /// *  **SUFFIX_MATCH** - The ending portion of the incoming URI path must exactly match the `attributeValue`
        ///    string.
        /// 
        /// </value>
        ///
        public enum OperatorEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "EXACT_MATCH")]
            ExactMatch,
            [EnumMember(Value = "FORCE_LONGEST_PREFIX_MATCH")]
            ForceLongestPrefixMatch,
            [EnumMember(Value = "PREFIX_MATCH")]
            PrefixMatch,
            [EnumMember(Value = "SUFFIX_MATCH")]
            SuffixMatch
        };

        /// <value>
        /// A string that specifies how to compare the PathMatchCondition object's `attributeValue` string to the
        /// incoming URI.
        /// <br/>
        /// *  **EXACT_MATCH** - The incoming URI path must exactly and completely match the `attributeValue` string.
        /// <br/>
        /// *  **FORCE_LONGEST_PREFIX_MATCH** - The system looks for the `attributeValue` string with the best,
        ///    longest match of the beginning portion of the incoming URI path.
        /// <br/>
        /// *  **PREFIX_MATCH** - The beginning portion of the incoming URI path must exactly match the
        ///    `attributeValue` string.
        /// <br/>
        /// *  **SUFFIX_MATCH** - The ending portion of the incoming URI path must exactly match the `attributeValue`
        ///    string.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Operator is required.")]
        [JsonProperty(PropertyName = "operator")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperatorEnum> Operator { get; set; }
        
        [JsonProperty(PropertyName = "attributeName")]
        private readonly string attributeName = "PATH";
    }
}
