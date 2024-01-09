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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details of an ASM instance discovered in an external DB system discovery run.
    /// </summary>
    public class DiscoveredExternalAsmInstance : DiscoveredExternalDbSystemComponent
    {
        
        /// <value>
        /// The name of the host on which the ASM instance is running.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HostName is required.")]
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
        
        /// <value>
        /// The name of the ASM instance.
        /// </value>
        [JsonProperty(PropertyName = "instanceName")]
        public string InstanceName { get; set; }
        
        /// <value>
        /// The Automatic Diagnostic Repository (ADR) home directory for the ASM instance.
        /// </value>
        [JsonProperty(PropertyName = "adrHomeDirectory")]
        public string AdrHomeDirectory { get; set; }
        
        [JsonProperty(PropertyName = "componentType")]
        private readonly string componentType = "ASM_INSTANCE";
    }
}
