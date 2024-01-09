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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Client App Credentials to be provided again.
    /// 
    /// </summary>
    public class CustomClientAppDetails : ClientAppDetails
    {
        
        /// <value>
        /// Client ID for the OAuth2/OIDC app.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClientId is required.")]
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Oracle Vault Service secret resource.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClientSecretId is required.")]
        [JsonProperty(PropertyName = "clientSecretId")]
        public string ClientSecretId { get; set; }
        
        /// <value>
        /// The version number of the client secret to use.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClientSecretVersionNumber is required.")]
        [JsonProperty(PropertyName = "clientSecretVersionNumber")]
        public System.Nullable<long> ClientSecretVersionNumber { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "CUSTOM";
    }
}
