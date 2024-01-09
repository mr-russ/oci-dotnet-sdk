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


namespace Oci.CloudbridgeService.Models
{
    /// <summary>
    /// The information to be updated.
    /// </summary>
    public class UpdatePluginDetails 
    {
        
        /// <value>
        /// State to which the customer wants the plugin to move to.
        /// </value>
        [JsonProperty(PropertyName = "desiredState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Plugin.DesiredStateEnum> DesiredState { get; set; }
        
    }
}
