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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Provides the parameters and their corresponding count.
    /// </summary>
    public class ActivityProblemAggregation 
    {
        
        /// <value>
        /// The key-value pairs of dimensions and their names.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DimensionsMap is required.")]
        [JsonProperty(PropertyName = "dimensionsMap")]
        public System.Collections.Generic.Dictionary<string, string> DimensionsMap { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PoliticalLocation is required.")]
        [JsonProperty(PropertyName = "politicalLocation")]
        public PoliticalLocation PoliticalLocation { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GeographicalLocation is required.")]
        [JsonProperty(PropertyName = "geographicalLocation")]
        public GeographicalLocation GeographicalLocation { get; set; }
        
        /// <value>
        /// The number of occurences with given dimension/s
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Count is required.")]
        [JsonProperty(PropertyName = "count")]
        public System.Nullable<int> Count { get; set; }
        
    }
}
