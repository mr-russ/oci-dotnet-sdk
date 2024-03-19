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
    /// Response of an individual attribute item in the bulk update attribute operation.
    /// 
    /// </summary>
    public class AttributeUpdateResponse 
    {
        
        /// <value>
        /// Attribute for which properties were updated in this bulk operation.
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
        /// Type of the attribute.
        /// 
        /// </value>
        ///
        public enum AttributeTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NUMERIC")]
            Numeric,
            [EnumMember(Value = "STRING")]
            String
        };

        /// <value>
        /// Type of the attribute.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "attributeType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AttributeTypeEnum> AttributeType { get; set; }
                ///
        /// <value>
        /// Unit updated for this attribute.
        /// 
        /// </value>
        ///
        public enum UnitEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
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
        /// Unit updated for this attribute.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "unit")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UnitEnum> Unit { get; set; }
        
        /// <value>
        /// Notes for the attribute.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }
                ///
        /// <value>
        /// Type of operation - UPDATE_ATTRIBUTE_PROPERTIES.
        /// 
        /// </value>
        ///
        public enum OperationTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "UPDATE_ATTRIBUTE_PROPERTIES")]
            UpdateAttributeProperties
        };

        /// <value>
        /// Type of operation - UPDATE_ATTRIBUTE_PROPERTIES.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperationTypeEnum> OperationType { get; set; }
                ///
        /// <value>
        /// Status of the attribute after this operation.  The attribute can have one of the following statuses after the update operation.  The attribute
        /// can have either a success status or an error status.  The status of the attribute must be correlated with the operation status property in the bulk operation metadata
        /// object.  The bulk operation will be successful only when all attributes in the bulk request are processed successfully and they get a success status back.
        /// The following are successful status values of individual attribute items in a bulk update attribute operation.
        /// ATTRIBUTE_UPDATED - The attribute's properites have been updated with the given properties.
        /// DUPLICATE_ATTRIBUTE - The attribute is a duplicate of an attribute that was present in this bulk request.  Note that we deduplicate the attribute collection, process only unique attributes,
        /// and call out duplicates.  A duplicate attribute in a bulk request will not prevent the processing of further attributes in the bulk operation.
        /// The following values are error statuses and the bulk processing is stopped when the first error is encountered.
        /// INVALID_ATTRIBUTE - The attribute is invalid.
        /// ATTRIBUTE_NOT_PROCESSED - The attribute was not processed, as there was another attribute in this bulk request collection that resulted in a processing error.
        /// ATTRIBUTE_DOES_NOT_EXIST - Attribute was neither active nor pinned inactive.
        /// ATTRIBUTE_UPDATE_NOT_ALLOWED - Attribute update is not allowed as it is an in-built system attribute.
        /// 
        /// </value>
        ///
        public enum AttributeStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ATTRIBUTE_UPDATED")]
            AttributeUpdated,
            [EnumMember(Value = "DUPLICATE_ATTRIBUTE")]
            DuplicateAttribute,
            [EnumMember(Value = "INVALID_ATTRIBUTE")]
            InvalidAttribute,
            [EnumMember(Value = "ATTRIBUTE_NOT_PROCESSED")]
            AttributeNotProcessed,
            [EnumMember(Value = "ATTRIBUTE_DOES_NOT_EXIST")]
            AttributeDoesNotExist,
            [EnumMember(Value = "ATTRIBUTE_UPDATE_NOT_ALLOWED")]
            AttributeUpdateNotAllowed
        };

        /// <value>
        /// Status of the attribute after this operation.  The attribute can have one of the following statuses after the update operation.  The attribute
        /// can have either a success status or an error status.  The status of the attribute must be correlated with the operation status property in the bulk operation metadata
        /// object.  The bulk operation will be successful only when all attributes in the bulk request are processed successfully and they get a success status back.
        /// The following are successful status values of individual attribute items in a bulk update attribute operation.
        /// ATTRIBUTE_UPDATED - The attribute's properites have been updated with the given properties.
        /// DUPLICATE_ATTRIBUTE - The attribute is a duplicate of an attribute that was present in this bulk request.  Note that we deduplicate the attribute collection, process only unique attributes,
        /// and call out duplicates.  A duplicate attribute in a bulk request will not prevent the processing of further attributes in the bulk operation.
        /// The following values are error statuses and the bulk processing is stopped when the first error is encountered.
        /// INVALID_ATTRIBUTE - The attribute is invalid.
        /// ATTRIBUTE_NOT_PROCESSED - The attribute was not processed, as there was another attribute in this bulk request collection that resulted in a processing error.
        /// ATTRIBUTE_DOES_NOT_EXIST - Attribute was neither active nor pinned inactive.
        /// ATTRIBUTE_UPDATE_NOT_ALLOWED - Attribute update is not allowed as it is an in-built system attribute.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "attributeStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AttributeStatusEnum> AttributeStatus { get; set; }
                ///
        /// <value>
        /// Namespace of the attribute whose properties were updated.  The attributeNameSpace will default to TRACES if it is 
        /// not passed in.
        /// 
        /// </value>
        ///
        public enum AttributeNameSpaceEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "TRACES")]
            Traces,
            [EnumMember(Value = "SYNTHETIC")]
            Synthetic
        };

        /// <value>
        /// Namespace of the attribute whose properties were updated.  The attributeNameSpace will default to TRACES if it is 
        /// not passed in.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttributeNameSpace is required.")]
        [JsonProperty(PropertyName = "attributeNameSpace")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AttributeNameSpaceEnum> AttributeNameSpace { get; set; }
        
        /// <value>
        /// Time when the attribute's properties were updated.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
    }
}
