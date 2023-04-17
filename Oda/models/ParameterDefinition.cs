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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// A parameter to a resource.
    /// </summary>
    public class ParameterDefinition 
    {
        
        /// <value>
        /// The name of the parameter
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// Enumerated parameter type.
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "STRING")]
            String,
            [EnumMember(Value = "URI")]
            Uri,
            [EnumMember(Value = "URL")]
            Url,
            [EnumMember(Value = "NUMBER")]
            Number,
            [EnumMember(Value = "BOOLEAN")]
            Boolean
        };

        /// <value>
        /// Enumerated parameter type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// Description of the parameter.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Is this parameter required. Ignored for parameters with direction = OUTPUT.
        /// </value>
        [JsonProperty(PropertyName = "isRequired")]
        public System.Nullable<bool> IsRequired { get; set; }
        
        /// <value>
        /// Is the data for this parameter sensitive (e.g. should the data be hidden in UI, encrypted if stored, etc.)
        /// </value>
        [JsonProperty(PropertyName = "isSensitive")]
        public System.Nullable<bool> IsSensitive { get; set; }
        
        /// <value>
        /// Default value for the parameter.
        /// </value>
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }
        
        /// <value>
        /// Used for character string types such as STRING to constrain the length of the value
        /// </value>
        [JsonProperty(PropertyName = "minLength")]
        public System.Nullable<int> MinLength { get; set; }
        
        /// <value>
        /// Used for character string types such as STRING to constrain the length of the value
        /// </value>
        [JsonProperty(PropertyName = "maxLength")]
        public System.Nullable<int> MaxLength { get; set; }
        
        /// <value>
        /// Regular expression used to validate the value of a string type such as STRING
        /// </value>
        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }
                ///
        /// <value>
        /// Is this parameter an input parameter, output parameter, or both?
        /// </value>
        ///
        public enum DirectionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "INPUT")]
            Input,
            [EnumMember(Value = "OUTPUT")]
            Output
        };

        /// <value>
        /// Is this parameter an input parameter, output parameter, or both?
        /// </value>
        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DirectionEnum> Direction { get; set; }
        
        /// <value>
        /// A forward-slash-delimited 'path' in an imaginary hierarchy, at which this parameter's UI widgets should be placed
        /// </value>
        [JsonProperty(PropertyName = "uiPlacementHint")]
        public string UiPlacementHint { get; set; }
        
        /// <value>
        /// Any configuration needed to help the resource type process this parameter (e.g. link to manifest, etc.).
        /// </value>
        [JsonProperty(PropertyName = "resourceTypeMetadata")]
        public System.Object ResourceTypeMetadata { get; set; }
        
    }
}
