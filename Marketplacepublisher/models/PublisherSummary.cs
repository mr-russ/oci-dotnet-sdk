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


namespace Oci.MarketplacepublisherService.Models
{
    /// <summary>
    /// The model for a publisher.
    /// </summary>
    public class PublisherSummary 
    {
        
        /// <value>
        /// Unique OCID identifier for the publisher.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The root compartment of the Publisher.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The namespace for the publisher registry to persist artifacts.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RegistryNamespace is required.")]
        [JsonProperty(PropertyName = "registryNamespace")]
        public string RegistryNamespace { get; set; }
        
        /// <value>
        /// Unique legacy service identifier for the publisher.
        /// </value>
        [JsonProperty(PropertyName = "legacyId")]
        public string LegacyId { get; set; }
        
        /// <value>
        /// The name of the publisher.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A description of the publisher.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The year the publisher's company or organization was founded.
        /// </value>
        [JsonProperty(PropertyName = "yearFounded")]
        public System.Nullable<long> YearFounded { get; set; }
        
        /// <value>
        /// The publisher's website.
        /// </value>
        [JsonProperty(PropertyName = "websiteUrl")]
        public string WebsiteUrl { get; set; }
        
        /// <value>
        /// The public email address of the publisher for customers.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ContactEmail is required.")]
        [JsonProperty(PropertyName = "contactEmail")]
        public string ContactEmail { get; set; }
        
        /// <value>
        /// The phone number of the publisher in E.164 format.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ContactPhone is required.")]
        [JsonProperty(PropertyName = "contactPhone")]
        public string ContactPhone { get; set; }
        
        /// <value>
        /// The address of the publisher's headquarters.
        /// </value>
        [JsonProperty(PropertyName = "hqAddress")]
        public string HqAddress { get; set; }
        
        [JsonProperty(PropertyName = "logo")]
        public UploadData Logo { get; set; }
        
        /// <value>
        /// Publisher's Facebook URL
        /// </value>
        [JsonProperty(PropertyName = "facebookUrl")]
        public string FacebookUrl { get; set; }
        
        /// <value>
        /// Publisher's Twitter URL
        /// </value>
        [JsonProperty(PropertyName = "twitterUrl")]
        public string TwitterUrl { get; set; }
        
        /// <value>
        /// Publisher's LinkedIn URL
        /// </value>
        [JsonProperty(PropertyName = "linkedinUrl")]
        public string LinkedinUrl { get; set; }
                ///
        /// <value>
        /// publisher type.
        /// </value>
        ///
        public enum PublisherTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "INTERNAL")]
            Internal,
            [EnumMember(Value = "EXTERNAL")]
            External
        };

        /// <value>
        /// publisher type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PublisherType is required.")]
        [JsonProperty(PropertyName = "publisherType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PublisherTypeEnum> PublisherType { get; set; }
        
        /// <value>
        /// The time the publisher was created. An RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the publisher was updated. An RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
