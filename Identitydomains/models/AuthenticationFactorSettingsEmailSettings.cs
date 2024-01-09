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
    /// Settings related to Email Factor, such as enabled email magic link factor, custom url for Email Link
    /// <br/>
    /// **Added In:** 20.1.3
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - idcsSearchable: false
    ///  - multiValued: false
    ///  - mutability: readWrite
    ///  - required: false
    ///  - returned: default
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class AuthenticationFactorSettingsEmailSettings 
    {
        
        /// <value>
        /// Specifies whether Email link is enabled or not.
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EmailLinkEnabled is required.")]
        [JsonProperty(PropertyName = "emailLinkEnabled")]
        public System.Nullable<bool> EmailLinkEnabled { get; set; }
        
        /// <value>
        /// Custom redirect Url which will be used in email link
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "emailLinkCustomUrl")]
        public string EmailLinkCustomUrl { get; set; }
        
    }
}
