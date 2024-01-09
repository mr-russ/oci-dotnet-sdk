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


namespace Oci.ApmtracesService.Models
{
    /// <summary>
    /// Definition of span log collection object.
    /// 
    /// </summary>
    public class SpanLogCollection 
    {
        
        /// <value>
        /// Timestamp at which the log is created.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// List of logs associated with the span at the given timestamp.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "spanLogs")]
        public System.Collections.Generic.List<SpanLog> SpanLogs { get; set; }
        
    }
}
