/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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
    /// Represents an association of a folder to a term.
    /// </summary>
    public class FolderTag 
    {
        
        /// <value>
        /// The unique key of the folder associated with this tag.
        /// </value>
        [JsonProperty(PropertyName = "folderKey")]
        public string FolderKey { get; set; }
        
        /// <value>
        /// Unique tag key that is immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// Name of the tag which matches the term name.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Unique key of the related term.
        /// </value>
        [JsonProperty(PropertyName = "termKey")]
        public string TermKey { get; set; }
        
        /// <value>
        /// Path of the related term.
        /// </value>
        [JsonProperty(PropertyName = "termPath")]
        public string TermPath { get; set; }
        
        /// <value>
        /// Description of the related term.
        /// </value>
        [JsonProperty(PropertyName = "termDescription")]
        public string TermDescription { get; set; }
        
        /// <value>
        /// The current state of the tag.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the tag was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// OCID of the user who created the tag.
        /// </value>
        [JsonProperty(PropertyName = "createdById")]
        public string CreatedById { get; set; }
        
        /// <value>
        /// URI to the tag instance in the API.
        /// </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
    }
}
