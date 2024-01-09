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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The Deterministic Encryption masking format encrypts column data using a cryptographic 
    /// key and Advanced Encryption Standard (AES 128). It can be used to encrypt character and 
    /// number columns. It can encrypt ASCII data without any input (except seed value), but it 
    /// needs a regular expression to encrypt non-ASCII data.
    /// <br/>
    /// Deterministic Encryption is a format-preserving, deterministic and reversible masking 
    /// format, which requires a seed value while submitting a masking work request. Passing 
    /// the same seed value when masking multiple times or masking different databases ensures 
    /// that the data is masked deterministically. To learn more, check Deterministic Encryption 
    /// in the Data Safe documentation. 
    /// 
    /// </summary>
    public class DeterministicEncryptionFormatEntry : FormatEntry
    {
        
        /// <value>
        /// The regular expression to be used for masking. For data with characters in the
        /// ASCII character set, providing a regular expression is optional. However, it 
        /// is required if the data contains multi-byte characters. If not provided, an 
        /// error is returned when a multi-byte character is found.
        /// <br/>
        /// In the case of ASCII characters, if a regular expression is not provided, 
        /// Deterministic Encryption can encrypt variable-length column values while 
        /// preserving their original format.
        /// <br/>
        /// If a regular expression is provided, the column values in all the rows must match 
        /// the regular expression. Deterministic Encryption supports a subset of the regular 
        /// expression language. It supports encryption of fixed-length strings, and does not 
        /// support * or + syntax of regular expressions. The encrypted values also match the 
        /// regular expression, which helps to ensure that the original format is preserved. 
        /// If an original value does not match the regular expression, Deterministic Encryption 
        /// might not produce a one-to-one mapping. All non-confirming values are mapped to a 
        /// single encrypted value, thereby producing a many-to-one mapping. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "regularExpression")]
        public string RegularExpression { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "DETERMINISTIC_ENCRYPTION";
    }
}
