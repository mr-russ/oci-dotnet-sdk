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


namespace Oci.DnsService.Models
{
    /// <summary>
    /// The body for updating a steering policy attachment.
    /// <br/>
    /// 
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class UpdateSteeringPolicyAttachmentDetails 
    {
        
        /// <value>
        /// A user-friendly name for the steering policy attachment.
        /// Does not have to be unique and can be changed.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
    }
}
