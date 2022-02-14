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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Summary of masking analytics data.
    /// </summary>
    public class MaskingAnalyticsSummary 
    {
                ///
        /// <value>
        /// The name of the aggregation metric.
        /// </value>
        ///
        public enum MetricNameEnum {
            [EnumMember(Value = "MASKING_POLICY")]
            MaskingPolicy,
            [EnumMember(Value = "MASKING_DATABASE")]
            MaskingDatabase,
            [EnumMember(Value = "MASKING_WORK_REQUEST")]
            MaskingWorkRequest,
            [EnumMember(Value = "MASKED_SENSITIVE_TYPE")]
            MaskedSensitiveType,
            [EnumMember(Value = "MASKED_SCHEMA")]
            MaskedSchema,
            [EnumMember(Value = "MASKED_TABLE")]
            MaskedTable,
            [EnumMember(Value = "MASKED_COLUMN")]
            MaskedColumn,
            [EnumMember(Value = "MASKED_DATA_VALUE")]
            MaskedDataValue
        };

        /// <value>
        /// The name of the aggregation metric.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetricName is required.")]
        [JsonProperty(PropertyName = "metricName")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MetricNameEnum> MetricName { get; set; }
        
        [JsonProperty(PropertyName = "dimensions")]
        public MaskingAnalyticsDimensions Dimensions { get; set; }
        
        /// <value>
        /// The total count for the aggregation metric.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Count is required.")]
        [JsonProperty(PropertyName = "count")]
        public System.Nullable<long> Count { get; set; }
        
    }
}
