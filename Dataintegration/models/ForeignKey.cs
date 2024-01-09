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
    /// The foreign key object.
    /// </summary>
    public class ForeignKey : Key
    {
        
        /// <value>
        /// The object key.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The object's model version.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value is editable and is restricted to 1000 characters.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// An array of attribute references.
        /// </value>
        [JsonProperty(PropertyName = "attributeRefs")]
        public System.Collections.Generic.List<KeyAttribute> AttributeRefs { get; set; }
        
        /// <value>
        /// The update rule.
        /// </value>
        [JsonProperty(PropertyName = "updateRule")]
        public System.Nullable<int> UpdateRule { get; set; }
        
        /// <value>
        /// The delete rule.
        /// </value>
        [JsonProperty(PropertyName = "deleteRule")]
        public System.Nullable<int> DeleteRule { get; set; }
        
        [JsonProperty(PropertyName = "referenceUniqueKey")]
        public UniqueKey ReferenceUniqueKey { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "FOREIGN_KEY";
    }
}
