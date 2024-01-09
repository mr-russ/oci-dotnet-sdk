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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// A `ConfiguredType` represents a type that has built-in configuration to the type itself. An example is a `SSN` type whose basic type is `VARCHAR`, but the type itself also has a built-in configuration like length=10.
    /// </summary>
    public class ConfiguredType : BaseType
    {
        
        /// <value>
        /// A wrapped type, may be a string or a BaseType.
        /// </value>
        [JsonProperty(PropertyName = "wrappedType")]
        public System.Object WrappedType { get; set; }
        
        [JsonProperty(PropertyName = "configValues")]
        public ConfigValues ConfigValues { get; set; }
        
        [JsonProperty(PropertyName = "configDefinition")]
        public ConfigDefinition ConfigDefinition { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "CONFIGURED_TYPE";
    }
}
