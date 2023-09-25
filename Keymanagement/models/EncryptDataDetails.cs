/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.KeymanagementService.Models
{
    /// <summary>
    /// The details of the plaintext data that you want to encrypt.
    /// </summary>
    public class EncryptDataDetails 
    {
        
        /// <value>
        /// Information that can be used to provide an encryption context for the
        /// encrypted data. The length of the string representation of the associated data
        /// must be fewer than 4096 characters.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "associatedData")]
        public System.Collections.Generic.Dictionary<string, string> AssociatedData { get; set; }
        
        /// <value>
        /// The OCID of the key to encrypt with.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyId is required.")]
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }
        
        /// <value>
        /// Information that provides context for audit logging. You can provide this additional
        /// data as key-value pairs to include in the audit logs when audit logging is enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "loggingContext")]
        public System.Collections.Generic.Dictionary<string, string> LoggingContext { get; set; }
        
        /// <value>
        /// The plaintext data to encrypt.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Plaintext is required.")]
        [JsonProperty(PropertyName = "plaintext")]
        public string Plaintext { get; set; }
        
        /// <value>
        /// The OCID of the key version used to encrypt the ciphertext.
        /// </value>
        [JsonProperty(PropertyName = "keyVersionId")]
        public string KeyVersionId { get; set; }
                ///
        /// <value>
        /// The encryption algorithm to use to encrypt and decrypt data with a customer-managed key.
        /// `AES_256_GCM` indicates that the key is a symmetric key that uses the Advanced Encryption Standard (AES) algorithm and
        /// that the mode of encryption is the Galois/Counter Mode (GCM). `RSA_OAEP_SHA_1` indicates that the
        /// key is an asymmetric key that uses the RSA encryption algorithm and uses Optimal Asymmetric Encryption Padding (OAEP).
        /// `RSA_OAEP_SHA_256` indicates that the key is an asymmetric key that uses the RSA encryption algorithm with a SHA-256 hash
        /// and uses OAEP.
        /// 
        /// </value>
        ///
        public enum EncryptionAlgorithmEnum {
            [EnumMember(Value = "AES_256_GCM")]
            Aes256Gcm,
            [EnumMember(Value = "RSA_OAEP_SHA_1")]
            RsaOaepSha1,
            [EnumMember(Value = "RSA_OAEP_SHA_256")]
            RsaOaepSha256
        };

        /// <value>
        /// The encryption algorithm to use to encrypt and decrypt data with a customer-managed key.
        /// `AES_256_GCM` indicates that the key is a symmetric key that uses the Advanced Encryption Standard (AES) algorithm and
        /// that the mode of encryption is the Galois/Counter Mode (GCM). `RSA_OAEP_SHA_1` indicates that the
        /// key is an asymmetric key that uses the RSA encryption algorithm and uses Optimal Asymmetric Encryption Padding (OAEP).
        /// `RSA_OAEP_SHA_256` indicates that the key is an asymmetric key that uses the RSA encryption algorithm with a SHA-256 hash
        /// and uses OAEP.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "encryptionAlgorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<EncryptionAlgorithmEnum> EncryptionAlgorithm { get; set; }
        
    }
}
