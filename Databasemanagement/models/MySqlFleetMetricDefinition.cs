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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The list of aggregated metrics for the Managed MySQL Databases in the fleet.
    /// </summary>
    public class MySqlFleetMetricDefinition 
    {
        
        /// <value>
        /// The value of the metric.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetricValue is required.")]
        [JsonProperty(PropertyName = "metricValue")]
        public System.Nullable<int> MetricValue { get; set; }
        
        /// <value>
        /// The value of the metric.
        /// </value>
        [JsonProperty(PropertyName = "metricValueDouble")]
        public System.Double MetricValueDouble { get; set; }
        
        /// <value>
        /// The name of the metric.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetricName is required.")]
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }
        
        /// <value>
        /// The data point date and time in UTC in ISO-8601 format.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Timestamp is required.")]
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
        /// <value>
        /// The dimensions of the metric.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Dimensions is required.")]
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.List<MetricDimensionDefinition> Dimensions { get; set; }
        
        /// <value>
        /// The unit of the metric value.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Unit is required.")]
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
        
    }
}
