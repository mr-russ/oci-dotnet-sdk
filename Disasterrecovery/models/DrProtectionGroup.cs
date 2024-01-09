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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// The details of a DR protection group.
    /// </summary>
    public class DrProtectionGroup 
    {
        
        /// <value>
        /// The OCID of the DR protection group.
        /// <br/>
        /// Example: ocid1.drprotectiongroup.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the DR protection group.
        /// <br/>
        /// Example: ocid1.compartment.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The display name of the DR protection group.
        /// <br/>
        /// Example: EBS PHX Group
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The role of the DR protection group.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Role is required.")]
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DrProtectionGroupRole> Role { get; set; }
        
        /// <value>
        /// The OCID of the peer DR protection group.
        /// <br/>
        /// Example: ocid1.drprotectiongroup.oc1..uniqueID
        /// </value>
        [JsonProperty(PropertyName = "peerId")]
        public string PeerId { get; set; }
        
        /// <value>
        /// The region of the peer DR protection group.
        /// <br/>
        /// Example: us-ashburn-1
        /// </value>
        [JsonProperty(PropertyName = "peerRegion")]
        public string PeerRegion { get; set; }
        
        [JsonProperty(PropertyName = "logLocation")]
        public ObjectStorageLogLocation LogLocation { get; set; }
        
        /// <value>
        /// A list of DR protection group members.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "members")]
        public System.Collections.Generic.List<DrProtectionGroupMember> Members { get; set; }
        
        /// <value>
        /// The date and time the DR protection group was created. An RFC3339 formatted datetime string.
        /// <br/>
        /// Example: 2019-03-29T09:36:42Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the DR protection group was updated. An RFC3339 formatted datetime string.
        /// <br/>
        /// Example: 2019-03-29T09:36:42Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the DR protection group.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DrProtectionGroupLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the DR protection group's current state in more detail.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifeCycleDetails")]
        public string LifeCycleDetails { get; set; }
        
        /// <value>
        /// The current sub-state of the DR protection group.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleSubState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DrProtectionGroupLifecycleSubState> LifecycleSubState { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// <br/>
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
