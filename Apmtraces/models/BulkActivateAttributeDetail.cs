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


namespace Oci.ApmtracesService.Models
{
    /// <summary>
    /// Object that contains the details about a single attribute in the bulk request to be activated.  The attributeNameSpace and
    /// unit are optional parameters, and the attributeNameSpace will default to TRACES if it is not passed in.
    /// 
    /// </summary>
    public class BulkActivateAttributeDetail 
    {
        
        /// <value>
        /// Name of the attribute to be activated.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttributeName is required.")]
        [JsonProperty(PropertyName = "attributeName")]
        public string AttributeName { get; set; }
                ///
        /// <value>
        /// Type of the attribute to be activated.
        /// 
        /// </value>
        ///
        public enum AttributeTypeEnum {
            [EnumMember(Value = "NUMERIC")]
            Numeric,
            [EnumMember(Value = "STRING")]
            String
        };

        /// <value>
        /// Type of the attribute to be activated.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttributeType is required.")]
        [JsonProperty(PropertyName = "attributeType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AttributeTypeEnum> AttributeType { get; set; }
                ///
        /// <value>
        /// Unit of the attribute to be updated.
        /// 
        /// </value>
        ///
        public enum UnitEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "EPOCH_TIME_MS")]
            EpochTimeMs,
            [EnumMember(Value = "BYTES")]
            Bytes,
            [EnumMember(Value = "COUNT")]
            Count,
            [EnumMember(Value = "DURATION_MS")]
            DurationMs,
            [EnumMember(Value = "TRACE_STATUS")]
            TraceStatus,
            [EnumMember(Value = "PERCENTAGE")]
            Percentage
        };

        /// <value>
        /// Unit of the attribute to be updated.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "unit")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UnitEnum> Unit { get; set; }
                ///
        /// <value>
        /// Namespace of the attribute to be activated.  The attributeNameSpace will default to TRACES if it is 
        /// not passed in.
        /// 
        /// </value>
        ///
        public enum AttributeNameSpaceEnum {
            [EnumMember(Value = "TRACES")]
            Traces,
            [EnumMember(Value = "SYNTHETIC")]
            Synthetic
        };

        /// <value>
        /// Namespace of the attribute to be activated.  The attributeNameSpace will default to TRACES if it is 
        /// not passed in.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "attributeNameSpace")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AttributeNameSpaceEnum> AttributeNameSpace { get; set; }
        
    }
}
