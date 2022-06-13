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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// Properties for creating a network source object.
    /// 
    /// </summary>
    public class CreateNetworkSourceDetails 
    {
        
        /// <value>
        /// The OCID of the tenancy (root compartment) containing the network source object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The name you assign to the network source during creation. The name must be unique across all groups
        /// in the tenancy and cannot be changed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A list of allowed public IP addresses and CIDR ranges.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "publicSourceList")]
        public System.Collections.Generic.List<string> PublicSourceList { get; set; }
        
        /// <value>
        /// A list of allowed VCN OCID and IP range pairs.
        /// Example: &quot;vcnId&quot;: &quot;ocid1.vcn.oc1.iad.aaaaaaaaexampleuniqueID&quot;, &quot;ipRanges&quot;: [ &quot;129.213.39.0/24&quot; ]
        /// </value>
        [JsonProperty(PropertyName = "virtualSourceList")]
        public System.Collections.Generic.List<NetworkSources_virtualSourceList> VirtualSourceList { get; set; }
        
        /// <value>
        /// -- The services attribute has no effect and is reserved for use by Oracle. --
        /// 
        /// </value>
        [JsonProperty(PropertyName = "services")]
        public System.Collections.Generic.List<string> Services { get; set; }
        
        /// <value>
        /// The description you assign to the network source during creation. Does not have to be unique, and it's changeable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
