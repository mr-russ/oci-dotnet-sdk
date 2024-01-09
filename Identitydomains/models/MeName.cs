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
    /// A complex attribute that contains attributes representing the name
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:Formatted Name, mapsTo:name.formatted], [columnHeaderName:Honorific Prefix, mapsTo:name.honorificPrefix], [columnHeaderName:First Name, mapsTo:name.givenName], [columnHeaderName:Middle Name, mapsTo:name.middleName], [columnHeaderName:Last Name, mapsTo:name.familyName], [columnHeaderName:Honorific Suffix, mapsTo:name.honorificSuffix]]
    ///  - idcsPii: true
    ///  - multiValued: false
    ///  - mutability: readWrite
    ///  - required: false
    ///  - returned: default
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class MeName 
    {
        
        /// <value>
        /// Full name
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "formatted")]
        public string Formatted { get; set; }
        
        /// <value>
        /// Last name
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCsvAttributeName: Last Name
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "familyName")]
        public string FamilyName { get; set; }
        
        /// <value>
        /// First name
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCsvAttributeName: First Name
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }
        
        /// <value>
        /// Middle name
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCsvAttributeName: Middle Name
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "middleName")]
        public string MiddleName { get; set; }
        
        /// <value>
        /// Prefix
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCsvAttributeName: Honorific Prefix
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "honorificPrefix")]
        public string HonorificPrefix { get; set; }
        
        /// <value>
        /// Suffix
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCsvAttributeName: Honorific Suffix
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "honorificSuffix")]
        public string HonorificSuffix { get; set; }
        
    }
}
