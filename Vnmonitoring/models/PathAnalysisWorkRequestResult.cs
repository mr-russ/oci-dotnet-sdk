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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Defines the configuration of the path analysis result.
    /// 
    /// </summary>
    public class PathAnalysisWorkRequestResult : WorkRequestResult
    {
        
        /// <value>
        /// List of various paths from source node to destination node
        /// for a given `PathAnalysisQuery`.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Paths is required.")]
        [JsonProperty(PropertyName = "paths")]
        public System.Collections.Generic.List<Path> Paths { get; set; }
        
        /// <value>
        /// Time the `PathAnalysisResult` was generated, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        [JsonProperty(PropertyName = "resultType")]
        private readonly string resultType = "PATH_ANALYSIS";
    }
}
