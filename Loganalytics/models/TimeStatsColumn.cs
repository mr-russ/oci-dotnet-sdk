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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Column returned by querylanguage TIMESTATS command.
    /// 
    /// </summary>
    public class TimeStatsColumn : AbstractColumn
    {
        
        /// <value>
        /// Time span between each timestamp in the timeseries datapoints.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "intervalGap")]
        public string IntervalGap { get; set; }
        
        /// <value>
        /// List of timestamps making up the timeseries datapoints.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "intervals")]
        public System.Collections.Generic.List<long> Intervals { get; set; }
        
        /// <value>
        /// List of series data sets for each statistical function specified in the command.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "series")]
        public System.Collections.Generic.List<TimeStatsDataColumn> Series { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "TIME_STATS_COLUMN";
    }
}
