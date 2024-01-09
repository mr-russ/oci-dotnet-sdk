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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// The request of DiscoveryJob details.
    /// </summary>
    public class CreateDiscoveryJobDetails 
    {
                ///
        /// <value>
        /// Add option submits new discovery Job. Add with retry option to re-submit failed discovery job. Refresh option refreshes the existing discovered resources.
        /// 
        /// </value>
        ///
        public enum DiscoveryTypeEnum {
            [EnumMember(Value = "ADD")]
            Add,
            [EnumMember(Value = "ADD_WITH_RETRY")]
            AddWithRetry,
            [EnumMember(Value = "REFRESH")]
            Refresh
        };

        /// <value>
        /// Add option submits new discovery Job. Add with retry option to re-submit failed discovery job. Refresh option refreshes the existing discovered resources.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "discoveryType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DiscoveryTypeEnum> DiscoveryType { get; set; }
        
        /// <value>
        /// Client who submits discovery job.
        /// </value>
        [JsonProperty(PropertyName = "discoveryClient")]
        public string DiscoveryClient { get; set; }
        
        /// <value>
        /// The OCID of Compartment
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DiscoveryDetails is required.")]
        [JsonProperty(PropertyName = "discoveryDetails")]
        public DiscoveryDetails DiscoveryDetails { get; set; }
        
        /// <value>
        /// If this parameter set to true, the specified tags will be applied 
        /// to all resources discovered in the current request. 
        /// Default is true.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shouldPropagateTagsToDiscoveredResources")]
        public System.Nullable<bool> ShouldPropagateTagsToDiscoveredResources { get; set; }
        
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
        
    }
}
