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
    /// The configuration details of Stack Monitoring for an external DB system.
    /// </summary>
    public class ExternalDbSystemStackMonitoringConfigDetails 
    {
        
        /// <value>
        /// The status of the associated service.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsEnabled is required.")]
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// The associated service-specific inputs in JSON string format, which Database Management can identify.
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public string Metadata { get; set; }
        
    }
}
