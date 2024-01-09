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


namespace Oci.IdentitydomainsService.Models
{
    /// <summary>
    /// Trusted 2FA Factors
    /// </summary>
    public class MyTrustedUserAgentTrustedFactors 
    {
        
        /// <value>
        /// Trusted Factor
        /// <br/>
        /// **Added In:** 19.2.1
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
                ///
        /// <value>
        /// Trusted Factor Type. Local, X509, SAML SOCIAL
        /// <br/>
        /// **Added In:** 2111190457
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum CategoryEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SAML")]
            Saml,
            [EnumMember(Value = "LOCAL")]
            Local,
            [EnumMember(Value = "SOCIAL")]
            Social,
            [EnumMember(Value = "X509")]
            X509,
            [EnumMember(Value = "THIRDPARTY")]
            Thirdparty
        };

        /// <value>
        /// Trusted Factor Type. Local, X509, SAML SOCIAL
        /// <br/>
        /// **Added In:** 2111190457
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "category")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CategoryEnum> Category { get; set; }
        
        /// <value>
        /// trust factor creation time
        /// <br/>
        /// **Added In:** 19.2.1
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - required: true
        ///  - returned: default
        ///  - type: dateTime
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreationTime is required.")]
        [JsonProperty(PropertyName = "creationTime")]
        public string CreationTime { get; set; }
        
    }
}
