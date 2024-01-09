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


namespace Oci.MonitoringService.Models
{
    /// <summary>
    /// The response object returned from a PostMetricData operation.
    /// 
    /// </summary>
    public class PostMetricDataResponseDetails 
    {
        
        /// <value>
        /// The number of metric objects that failed input validation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FailedMetricsCount is required.")]
        [JsonProperty(PropertyName = "failedMetricsCount")]
        public System.Nullable<int> FailedMetricsCount { get; set; }
        
        /// <value>
        /// A list of records identifying metric objects that failed input validation
        /// and the reasons for the failures.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "failedMetrics")]
        public System.Collections.Generic.List<FailedMetricRecord> FailedMetrics { get; set; }
        
    }
}
