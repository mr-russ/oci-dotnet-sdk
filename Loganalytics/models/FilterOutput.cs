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
    /// Query builder api response object containing updated querystring's
    /// 
    /// </summary>
    public class FilterOutput 
    {
        
        /// <value>
        /// Modified user visible query string.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayQueryString is required.")]
        [JsonProperty(PropertyName = "displayQueryString")]
        public string DisplayQueryString { get; set; }
        
        /// <value>
        /// Modified localization agnostic query string.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InternalQueryString is required.")]
        [JsonProperty(PropertyName = "internalQueryString")]
        public string InternalQueryString { get; set; }
        
        /// <value>
        /// Operation response time.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "responseTimeInMs")]
        public System.Nullable<long> ResponseTimeInMs { get; set; }
        
    }
}
