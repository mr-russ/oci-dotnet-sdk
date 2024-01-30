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
    /// The summary of preferred credentials.
    /// </summary>
    public class PreferredCredentialSummary 
    {
        
        /// <value>
        /// The name of the preferred credential.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CredentialName is required.")]
        [JsonProperty(PropertyName = "credentialName")]
        public string CredentialName { get; set; }
        
        /// <value>
        /// The status of the preferred credential.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PreferredCredentialStatus> Status { get; set; }
        
        /// <value>
        /// Indicates whether the preferred credential is accessible.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsAccessible is required.")]
        [JsonProperty(PropertyName = "isAccessible")]
        public System.Nullable<bool> IsAccessible { get; set; }
        
        /// <value>
        /// The user name used to connect to the database.
        /// </value>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
        
        /// <value>
        /// The role of the database user.
        /// </value>
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Role> Role { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Vault service secret that contains the database user password.
        /// </value>
        [JsonProperty(PropertyName = "passwordSecretId")]
        public string PasswordSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Named Credential that contains the database user password metadata.
        /// </value>
        [JsonProperty(PropertyName = "namedCredentialId")]
        public string NamedCredentialId { get; set; }
        
    }
}
