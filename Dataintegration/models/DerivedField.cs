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
    /// The type representing the derived field concept. Derived fields have an expression to define how to derive the field.
    /// </summary>
    public class DerivedField : TypedObject
    {
        
        [JsonProperty(PropertyName = "expr")]
        public Expression Expr { get; set; }
        
        /// <value>
        /// The type of the field.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// Specifies whether to use inferred expression output type as output type of the derived field. Default value of this flag is false.
        /// </value>
        [JsonProperty(PropertyName = "isUseInferredType")]
        public System.Nullable<bool> IsUseInferredType { get; set; }
        
        /// <value>
        /// Labels are keywords or labels that you can add to data assets, dataflows and so on. You can define your own labels and use them to categorize content.
        /// </value>
        [JsonProperty(PropertyName = "labels")]
        public System.Collections.Generic.List<string> Labels { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "DERIVED_FIELD";
    }
}
