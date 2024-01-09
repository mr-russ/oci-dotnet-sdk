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


namespace Oci.LoggingService.Models
{
    /// <summary>
    /// Unified Agent logging service configuration object.
    /// </summary>
    public class UnifiedAgentLoggingConfiguration : UnifiedAgentServiceConfigurationDetails
    {
        
        /// <value>
        /// Logging source object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Sources is required.")]
        [JsonProperty(PropertyName = "sources")]
        public System.Collections.Generic.List<UnifiedAgentLoggingSource> Sources { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Destination is required.")]
        [JsonProperty(PropertyName = "destination")]
        public UnifiedAgentLoggingDestination Destination { get; set; }
        
        [JsonProperty(PropertyName = "configurationType")]
        private readonly string configurationType = "LOGGING";
    }
}
