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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// Details of `Package` object.
    /// </summary>
    public class Package 
    {
        
        /// <value>
        /// Unique immutable identifier that was assigned when the Package was registered.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// ID of the publisher providing the package.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PublisherId is required.")]
        [JsonProperty(PropertyName = "publisherId")]
        public string PublisherId { get; set; }
        
        /// <value>
        /// Name of package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Display name for the package (displayed in UI and user-facing applications).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Version of the package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// When the package was uploaded. A date-time string as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUploaded is required.")]
        [JsonProperty(PropertyName = "timeUploaded")]
        public System.Nullable<System.DateTime> TimeUploaded { get; set; }
        
        /// <value>
        /// When the package was last published. A date-time string as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimePublished is required.")]
        [JsonProperty(PropertyName = "timePublished")]
        public System.Nullable<System.DateTime> TimePublished { get; set; }
        
        /// <value>
        /// Description of the package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// A list of resource types describing the content of the package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceTypes is required.")]
        [JsonProperty(PropertyName = "resourceTypes")]
        public System.Collections.Generic.List<string> ResourceTypes { get; set; }
        
        /// <value>
        /// A map of resource type to metadata key/value map that further describes the content for the resource types in this package.. Keys are resource type names, values are a map of name/value pairs per resource type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceTypesMetadata is required.")]
        [JsonProperty(PropertyName = "resourceTypesMetadata")]
        public System.Collections.Generic.List<ResourceTypeMetadata> ResourceTypesMetadata { get; set; }
        
        /// <value>
        /// A map of metadata key/value pairs that further describes the publisher and the platform in which the package might be used.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PublisherMetadata is required.")]
        [JsonProperty(PropertyName = "publisherMetadata")]
        public System.Collections.Generic.List<MetadataProperty> PublisherMetadata { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type, or scope.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImportContract is required.")]
        [JsonProperty(PropertyName = "importContract")]
        public ImportContract ImportContract { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefaultParameterValues is required.")]
        [JsonProperty(PropertyName = "defaultParameterValues")]
        public DefaultParameterValues DefaultParameterValues { get; set; }
        
    }
}
