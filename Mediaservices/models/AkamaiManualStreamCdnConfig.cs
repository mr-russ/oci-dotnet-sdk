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


namespace Oci.MediaservicesService.Models
{
    /// <summary>
    /// Configuration fields for manual Akamai configuration.
    /// </summary>
    public class AkamaiManualStreamCdnConfig : StreamCdnConfigSection
    {
                ///
        /// <value>
        /// The type of data used to compute the signature.
        /// </value>
        ///
        public enum OriginAuthSignTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ForwardURL")]
            ForwardUrl
        };

        /// <value>
        /// The type of data used to compute the signature.
        /// </value>
        [JsonProperty(PropertyName = "originAuthSignType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OriginAuthSignTypeEnum> OriginAuthSignType { get; set; }
                ///
        /// <value>
        /// The type of encryption used to compute the signature.
        /// </value>
        ///
        public enum OriginAuthSignEncryptionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SHA256-HMAC")]
            Sha256Hmac
        };

        /// <value>
        /// The type of encryption used to compute the signature.
        /// </value>
        [JsonProperty(PropertyName = "originAuthSignEncryption")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OriginAuthSignEncryptionEnum> OriginAuthSignEncryption { get; set; }
        
        /// <value>
        /// The shared secret key A, two for errorless key rotation.
        /// </value>
        [JsonProperty(PropertyName = "originAuthSecretKeyA")]
        public string OriginAuthSecretKeyA { get; set; }
        
        /// <value>
        /// Nonce identifier for originAuthSecretKeyA (used to determine key used to sign).
        /// </value>
        [JsonProperty(PropertyName = "originAuthSecretKeyNonceA")]
        public string OriginAuthSecretKeyNonceA { get; set; }
        
        /// <value>
        /// The shared secret key B, two for errorless key rotation.
        /// </value>
        [JsonProperty(PropertyName = "originAuthSecretKeyB")]
        public string OriginAuthSecretKeyB { get; set; }
        
        /// <value>
        /// Nonce identifier for originAuthSecretKeyB (used to determine key used to sign).
        /// </value>
        [JsonProperty(PropertyName = "originAuthSecretKeyNonceB")]
        public string OriginAuthSecretKeyNonceB { get; set; }
        
        /// <value>
        /// The hostname of the CDN edge server to use when building CDN URLs.
        /// </value>
        [JsonProperty(PropertyName = "edgeHostname")]
        public string EdgeHostname { get; set; }
        
        /// <value>
        /// The path to prepend when building CDN URLs.
        /// </value>
        [JsonProperty(PropertyName = "edgePathPrefix")]
        public string EdgePathPrefix { get; set; }
        
        /// <value>
        /// Whether token authentication should be used at the CDN edge.
        /// </value>
        [JsonProperty(PropertyName = "isEdgeTokenAuth")]
        public System.Nullable<bool> IsEdgeTokenAuth { get; set; }
        
        /// <value>
        /// The encryption key to use for edge token authentication.
        /// </value>
        [JsonProperty(PropertyName = "edgeTokenKey")]
        public string EdgeTokenKey { get; set; }
        
        /// <value>
        /// Salt to use when encrypting authentication token.
        /// </value>
        [JsonProperty(PropertyName = "edgeTokenSalt")]
        public string EdgeTokenSalt { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "AKAMAI_MANUAL";
    }
}
