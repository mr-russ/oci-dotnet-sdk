/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// SQL Insights response.
    /// 
    /// </summary>
    public class SqlInsightAggregationCollection 
    {
        
        /// <value>
        /// The start timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalStart is required.")]
        [JsonProperty(PropertyName = "timeIntervalStart")]
        public System.Nullable<System.DateTime> TimeIntervalStart { get; set; }

        /// <value>
        /// The end timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalEnd is required.")]
        [JsonProperty(PropertyName = "timeIntervalEnd")]
        public System.Nullable<System.DateTime> TimeIntervalEnd { get; set; }

        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Inventory is required.")]
        [JsonProperty(PropertyName = "inventory")]
        public SqlInventory Inventory { get; set; }

        /// <value>
        /// List of insights.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Items is required.")]
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<SqlInsightAggregation> Items { get; set; }

        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Thresholds is required.")]
        [JsonProperty(PropertyName = "thresholds")]
        public SqlInsightThresholds Thresholds { get; set; }
    }
}
