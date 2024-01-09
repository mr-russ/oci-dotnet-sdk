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


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// Information about the data collected as a ZIP file when the event occurred.
    /// </summary>
    public class EventContent 
    {
        
        /// <value>
        /// Status of the event content
        /// </value>
        [JsonProperty(PropertyName = "contentAvailability")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ContentAvailability> ContentAvailability { get; set; }
        
        /// <value>
        /// Path to the event content on the instance
        /// </value>
        [JsonProperty(PropertyName = "instancePath")]
        public string InstancePath { get; set; }
        
        /// <value>
        /// size in bytes of the event content (size of the zip file uploaded)
        /// </value>
        [JsonProperty(PropertyName = "size")]
        public System.Nullable<int> Size { get; set; }
        
    }
}
