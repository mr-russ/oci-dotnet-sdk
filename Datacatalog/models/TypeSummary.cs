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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Summary data catalog type information. All types are statically defined in the system and are immutable.
    /// It isn't possible to create new types or update existing types via the API.
    /// 
    /// </summary>
    public class TypeSummary 
    {
        
        /// <value>
        /// Unique type key that is immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The immutable name of the type.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Detailed description of the type.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The data catalog's OCID.
        /// </value>
        [JsonProperty(PropertyName = "catalogId")]
        public string CatalogId { get; set; }
        
        /// <value>
        /// Indicates the category this type belongs to. For instance, data assets, connections.
        /// </value>
        [JsonProperty(PropertyName = "typeCategory")]
        public string TypeCategory { get; set; }
        
        /// <value>
        /// URI to the type instance in the API.
        /// </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
        /// <value>
        /// State of the folder.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Unique key of the parent type.
        /// </value>
        [JsonProperty(PropertyName = "parentTypeKey")]
        public string ParentTypeKey { get; set; }
        
        /// <value>
        /// Name of the parent type.
        /// </value>
        [JsonProperty(PropertyName = "parentTypeName")]
        public string ParentTypeName { get; set; }
        
    }
}
