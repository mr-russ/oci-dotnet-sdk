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


namespace Oci.WafService.Models
{
    /// <summary>
    /// Settings for protection capabilities
    /// 
    /// </summary>
    public class ProtectionCapabilitySettings 
    {
        
        /// <value>
        /// Maximum number of arguments allowed. Used in protection capability 920380: Number of Arguments Limits.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxNumberOfArguments")]
        public System.Nullable<int> MaxNumberOfArguments { get; set; }
        
        /// <value>
        /// Maximum allowed length of a single argument. Used in protection capability 920370: Limit argument value length.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxSingleArgumentLength")]
        public System.Nullable<int> MaxSingleArgumentLength { get; set; }
        
        /// <value>
        /// Maximum allowed total length of all arguments. Used in protection capability 920390: Limit arguments total length.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxTotalArgumentLength")]
        public System.Nullable<int> MaxTotalArgumentLength { get; set; }
        
        /// <value>
        /// Maximum number of headers allowed in an HTTP request. Used in protection capability 9200014: Limit Number of Request Headers.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxHttpRequestHeaders")]
        public System.Nullable<int> MaxHttpRequestHeaders { get; set; }
        
        /// <value>
        /// Maximum allowed length of headers in an HTTP request. Used in protection capability: 9200024: Limit length of request header size.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxHttpRequestHeaderLength")]
        public System.Nullable<int> MaxHttpRequestHeaderLength { get; set; }
        
        /// <value>
        /// List of allowed HTTP methods. Each value as a RFC7230 formated token string.
        /// Used in protection capability 911100: Restrict HTTP Request Methods.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "allowedHttpMethods")]
        public System.Collections.Generic.List<string> AllowedHttpMethods { get; set; }
        
    }
}
