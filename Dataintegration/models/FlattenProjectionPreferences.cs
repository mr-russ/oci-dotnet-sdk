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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The preferences for the flatten operation.
    /// </summary>
    public class FlattenProjectionPreferences 
    {
                ///
        /// <value>
        /// Property defining whether to create array indexes in flattened result.
        /// </value>
        ///
        public enum CreateArrayIndexEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ALLOW")]
            Allow,
            [EnumMember(Value = "DO_NOT_ALLOW")]
            DoNotAllow
        };

        /// <value>
        /// Property defining whether to create array indexes in flattened result.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreateArrayIndex is required.")]
        [JsonProperty(PropertyName = "createArrayIndex")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CreateArrayIndexEnum> CreateArrayIndex { get; set; }
                ///
        /// <value>
        /// Property defining whether to retain all attributes in flattened result.
        /// </value>
        ///
        public enum RetainAllAttributesEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ALLOW")]
            Allow,
            [EnumMember(Value = "DO_NOT_ALLOW")]
            DoNotAllow
        };

        /// <value>
        /// Property defining whether to retain all attributes in flattened result.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RetainAllAttributes is required.")]
        [JsonProperty(PropertyName = "retainAllAttributes")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RetainAllAttributesEnum> RetainAllAttributes { get; set; }
                ///
        /// <value>
        /// Property defining whether to ignore null values in flattened result.
        /// </value>
        ///
        public enum IgnoreNullValuesEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ALLOW")]
            Allow,
            [EnumMember(Value = "DO_NOT_ALLOW")]
            DoNotAllow
        };

        /// <value>
        /// Property defining whether to ignore null values in flattened result.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IgnoreNullValues is required.")]
        [JsonProperty(PropertyName = "ignoreNullValues")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<IgnoreNullValuesEnum> IgnoreNullValues { get; set; }
                ///
        /// <value>
        /// Property defining whether to retain parent name lineage.
        /// </value>
        ///
        public enum RetainParentNameLineageEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ALLOW")]
            Allow,
            [EnumMember(Value = "DO_NOT_ALLOW")]
            DoNotAllow
        };

        /// <value>
        /// Property defining whether to retain parent name lineage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RetainParentNameLineage is required.")]
        [JsonProperty(PropertyName = "retainParentNameLineage")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RetainParentNameLineageEnum> RetainParentNameLineage { get; set; }
        
    }
}
