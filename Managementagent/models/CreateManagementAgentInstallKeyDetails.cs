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


namespace Oci.ManagementagentService.Models
{
    /// <summary>
    /// The information about new Management Agent install Key.
    /// </summary>
    public class CreateManagementAgentInstallKeyDetails 
    {
        
        /// <value>
        /// Management Agent install Key Name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Total number of install for this keys
        /// </value>
        [JsonProperty(PropertyName = "allowedKeyInstallCount")]
        public System.Nullable<int> AllowedKeyInstallCount { get; set; }
        
        /// <value>
        /// date after which key would expire after creation
        /// </value>
        [JsonProperty(PropertyName = "timeExpires")]
        public System.Nullable<System.DateTime> TimeExpires { get; set; }
        
        /// <value>
        /// Compartment Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// If set to true, the install key has no expiration date or usage limit. Defaults to false
        /// </value>
        [JsonProperty(PropertyName = "isUnlimited")]
        public System.Nullable<bool> IsUnlimited { get; set; }
        
    }
}
