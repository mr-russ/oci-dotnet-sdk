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


namespace Oci.NosqlService.Models
{
    /// <summary>
    /// The result of an UpdateRow operation.
    /// </summary>
    public class UpdateRowResult 
    {
        
        /// <value>
        /// An opaque version string associated with the row.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// The version string associated with the existing row.
        /// Returned if the put fails due to options setting in the
        /// request.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "existingVersion")]
        public string ExistingVersion { get; set; }
        
        /// <value>
        /// The map of values from a row.
        /// </value>
        [JsonProperty(PropertyName = "existingValue")]
        public System.Collections.Generic.Dictionary<string, System.Object> ExistingValue { get; set; }
        
        /// <value>
        /// The value generated if the operation created a new value for
        /// an identity column. If the table has no identity column, this value
        /// is null. If it has an identity column, and a value was generated for
        /// that column, it is non-null.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "generatedValue")]
        public string GeneratedValue { get; set; }
        
        [JsonProperty(PropertyName = "usage")]
        public RequestUsage Usage { get; set; }
        
    }
}
