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


namespace Oci.OptimizerService.Models
{
    /// <summary>
    /// The metadata associated with the profile level summary.
    /// 
    /// </summary>
    public class ProfileLevelSummary 
    {
        
        /// <value>
        /// A unique name for the profile level.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The name of the recommendation this profile level applies to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecommendationName is required.")]
        [JsonProperty(PropertyName = "recommendationName")]
        public string RecommendationName { get; set; }
        
        /// <value>
        /// The metrics that will be evaluated by profiles using this profile level.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Metrics is required.")]
        [JsonProperty(PropertyName = "metrics")]
        public System.Collections.Generic.List<EvaluatedMetric> Metrics { get; set; }
        
        /// <value>
        /// The default aggregation interval (in days) for profiles using this profile level.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefaultInterval is required.")]
        [JsonProperty(PropertyName = "defaultInterval")]
        public System.Nullable<int> DefaultInterval { get; set; }
        
        /// <value>
        /// An array of aggregation intervals (in days) allowed for profiles using this profile level.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ValidIntervals is required.")]
        [JsonProperty(PropertyName = "validIntervals")]
        public System.Collections.Generic.List<int> ValidIntervals { get; set; }
        
        /// <value>
        /// The date and time the category details were created, in the format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the category details were last updated, in the format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
    }
}
