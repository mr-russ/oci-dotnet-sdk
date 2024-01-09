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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// A listener's SSL handling configuration.
    /// <br/>
    /// To use SSL, a listener must be associated with a {@link Certificate}.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class SSLConfiguration 
    {
        
        /// <value>
        /// The maximum depth for peer certificate chain verification.
        /// <br/>
        /// Example: 3
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VerifyDepth is required.")]
        [JsonProperty(PropertyName = "verifyDepth")]
        public System.Nullable<int> VerifyDepth { get; set; }
        
        /// <value>
        /// Whether the load balancer listener should verify peer certificates.
        /// <br/>
        /// Example: true
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VerifyPeerCertificate is required.")]
        [JsonProperty(PropertyName = "verifyPeerCertificate")]
        public System.Nullable<bool> VerifyPeerCertificate { get; set; }
        
        /// <value>
        /// Ids for OCI certificates service CA or CA bundles for the load balancer to trust.
        /// <br/>
        /// Example: [ocid1.cabundle.oc1.us-ashburn-1.amaaaaaaav3bgsaagl4zzyqdop5i2vuwoqewdvauuw34llqa74otq2jdsfyq]
        /// </value>
        [JsonProperty(PropertyName = "trustedCertificateAuthorityIds")]
        public System.Collections.Generic.List<string> TrustedCertificateAuthorityIds { get; set; }
        
        /// <value>
        /// Ids for OCI certificates service certificates. Currently only a single Id may be passed.
        /// <br/>
        /// Example: [ocid1.certificate.oc1.us-ashburn-1.amaaaaaaav3bgsaa5o2q7rh5nfmkkukfkogasqhk6af2opufhjlqg7m6jqzq]
        /// </value>
        [JsonProperty(PropertyName = "certificateIds")]
        public System.Collections.Generic.List<string> CertificateIds { get; set; }
        
        /// <value>
        /// A friendly name for the certificate bundle. It must be unique and it cannot be changed.
        /// Valid certificate bundle names include only alphanumeric characters, dashes, and underscores.
        /// Certificate bundle names cannot contain spaces. Avoid entering confidential information.
        /// <br/>
        /// Example: example_certificate_bundle
        /// </value>
        [JsonProperty(PropertyName = "certificateName")]
        public string CertificateName { get; set; }
                ///
        /// <value>
        /// When this attribute is set to ENABLED, the system gives preference to the server ciphers over the client
        /// ciphers.
        /// <br/>
        /// **Note:** This configuration is applicable only when the load balancer is acting as an SSL/HTTPS server. This
        ///           field is ignored when the `SSLConfiguration` object is associated with a backend set.
        /// 
        /// </value>
        ///
        public enum ServerOrderPreferenceEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLED")]
            Disabled
        };

        /// <value>
        /// When this attribute is set to ENABLED, the system gives preference to the server ciphers over the client
        /// ciphers.
        /// <br/>
        /// **Note:** This configuration is applicable only when the load balancer is acting as an SSL/HTTPS server. This
        ///           field is ignored when the `SSLConfiguration` object is associated with a backend set.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "serverOrderPreference")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ServerOrderPreferenceEnum> ServerOrderPreference { get; set; }
        
        /// <value>
        /// The name of the cipher suite to use for HTTPS or SSL connections.
        /// <br/>
        /// If this field is not specified, the default is `oci-default-ssl-cipher-suite-v1`.
        /// <br/>
        /// **Notes:**
        /// <br/>
        /// *  You must ensure compatibility between the specified SSL protocols and the ciphers configured in the cipher
        ///    suite. Clients cannot perform an SSL handshake if there is an incompatible configuration.
        /// *  You must ensure compatibility between the ciphers configured in the cipher suite and the configured
        ///    certificates. For example, RSA-based ciphers require RSA certificates and ECDSA-based ciphers require ECDSA
        ///    certificates.
        /// *  If the cipher configuration is not modified after load balancer creation, the `GET` operation returns
        ///    `oci-default-ssl-cipher-suite-v1` as the value of this field in the SSL configuration for existing listeners
        ///    that predate this feature.
        /// *  If the cipher configuration was modified using Oracle operations after load balancer creation, the `GET`
        ///    operation returns `oci-customized-ssl-cipher-suite` as the value of this field in the SSL configuration for
        ///    existing listeners that predate this feature.
        /// *  The `GET` operation returns `oci-wider-compatible-ssl-cipher-suite-v1` as the value of this field in the SSL
        ///    configuration for existing backend sets that predate this feature.
        /// *  If the `GET` operation on a listener returns `oci-customized-ssl-cipher-suite` as the value of this field,
        ///    you must specify an appropriate predefined or custom cipher suite name when updating the resource.
        /// *  The `oci-customized-ssl-cipher-suite` Oracle reserved cipher suite name is not accepted as valid input for
        ///    this field.
        /// <br/>
        /// Example: example_cipher_suite
        /// </value>
        [JsonProperty(PropertyName = "cipherSuiteName")]
        public string CipherSuiteName { get; set; }
        
        /// <value>
        /// A list of SSL protocols the load balancer must support for HTTPS or SSL connections.
        /// <br/>
        /// The load balancer uses SSL protocols to establish a secure connection between a client and a server. A secure
        /// connection ensures that all data passed between the client and the server is private.
        /// <br/>
        /// The Load Balancing service supports the following protocols:
        /// <br/>
        /// *  TLSv1
        /// *  TLSv1.1
        /// *  TLSv1.2
        /// <br/>
        /// If this field is not specified, TLSv1.2 is the default.
        /// <br/>
        /// **Warning:** All SSL listeners created on a given port must use the same set of SSL protocols.
        /// <br/>
        /// **Notes:**
        /// <br/>
        /// *  The handshake to establish an SSL connection fails if the client supports none of the specified protocols.
        /// *  You must ensure compatibility between the specified SSL protocols and the ciphers configured in the cipher
        ///    suite.
        /// *  For all existing load balancer listeners and backend sets that predate this feature, the `GET` operation
        ///    displays a list of SSL protocols currently used by those resources.
        /// <br/>
        /// Example: [&quot;TLSv1.1&quot;, &quot;TLSv1.2&quot;]
        /// </value>
        [JsonProperty(PropertyName = "protocols")]
        public System.Collections.Generic.List<string> Protocols { get; set; }
        
    }
}
