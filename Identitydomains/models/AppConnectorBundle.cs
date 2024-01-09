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
    /// ConnectorBundle
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - idcsSearchable: true
    ///  - multiValued: false
    ///  - mutability: readOnly
    ///  - required: false
    ///  - returned: default
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class AppConnectorBundle 
    {
        
        /// <value>
        /// ConnectorBundle identifier
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
                ///
        /// <value>
        /// Connector Bundle type. Allowed values are ConnectorBundle, LocalConnectorBundle.
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsDefaultValue: ConnectorBundle
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ConnectorBundle")]
            ConnectorBundle,
            [EnumMember(Value = "LocalConnectorBundle")]
            LocalConnectorBundle
        };

        /// <value>
        /// Connector Bundle type. Allowed values are ConnectorBundle, LocalConnectorBundle.
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsDefaultValue: ConnectorBundle
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: immutable
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
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// ConnectorBundle URI
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: reference
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "$ref")]
        public string Ref { get; set; }
        
        /// <value>
        /// ConnectorBundle display name
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "display")]
        public string Display { get; set; }
        
        /// <value>
        /// Unique Well-known identifier used to reference connector bundle.
        /// <br/>
        /// **Added In:** 18.2.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "wellKnownId")]
        public string WellKnownId { get; set; }
        
    }
}
