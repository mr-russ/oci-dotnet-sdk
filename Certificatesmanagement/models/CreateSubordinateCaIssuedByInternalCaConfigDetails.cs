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


namespace Oci.CertificatesmanagementService.Models
{
    /// <summary>
    /// The details for creating a private subordinate certificate authority (CA) which is issued by a private CA.
    /// </summary>
    public class CreateSubordinateCaIssuedByInternalCaConfigDetails : CreateCertificateAuthorityConfigDetails
    {
        
        /// <value>
        /// The OCID of the private CA.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IssuerCertificateAuthorityId is required.")]
        [JsonProperty(PropertyName = "issuerCertificateAuthorityId")]
        public string IssuerCertificateAuthorityId { get; set; }
        
        [JsonProperty(PropertyName = "validity")]
        public Validity Validity { get; set; }
        
        /// <value>
        /// The algorithm used to sign public key certificates that the CA issues.
        /// </value>
        [JsonProperty(PropertyName = "signingAlgorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SignatureAlgorithm> SigningAlgorithm { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Subject is required.")]
        [JsonProperty(PropertyName = "subject")]
        public CertificateSubject Subject { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "SUBORDINATE_CA_ISSUED_BY_INTERNAL_CA";
    }
}
