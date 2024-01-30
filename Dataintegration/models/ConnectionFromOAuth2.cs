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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The connection details for a OAuth connection.
    /// </summary>
    public class ConnectionFromOAuth2 : Connection
    {
        
        /// <value>
        /// Specifies the endpoint used to exchange authentication credentials for access tokens
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AccessTokenUrl is required.")]
        [JsonProperty(PropertyName = "accessTokenUrl")]
        public string AccessTokenUrl { get; set; }
        
        /// <value>
        /// Specifies the client ID key for specific application
        /// </value>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }
        
        [JsonProperty(PropertyName = "clientSecret")]
        public SensitiveAttribute ClientSecret { get; set; }
        
        /// <value>
        /// Specifies the OAuth scopes that limit the permissions granted by an access token.
        /// </value>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }
                ///
        /// <value>
        /// Specifies the OAuth2 grant mechanism. Example CLIENT_CREDENTIALS, Implicit Flow etc.
        /// </value>
        ///
        public enum GrantTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CLIENT_CREDENTIALS")]
            ClientCredentials
        };

        /// <value>
        /// Specifies the OAuth2 grant mechanism. Example CLIENT_CREDENTIALS, Implicit Flow etc.
        /// </value>
        [JsonProperty(PropertyName = "grantType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<GrantTypeEnum> GrantType { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "OAUTH2_CONNECTION";
    }
}
