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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// Plain text credentials [indicated by the type property in CredentialStore].
    /// 
    /// </summary>
    public class PlainTextCredentials : MonitoredResourceCredential
    {
        
        /// <value>
        /// The credential properties list. Credential property values will be either 
        /// in plain text format or encrypted for encrypted credentials.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Properties is required.")]
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.List<CredentialProperty> Properties { get; set; }
        
        [JsonProperty(PropertyName = "credentialType")]
        private readonly string credentialType = "PLAINTEXT";
    }
}
