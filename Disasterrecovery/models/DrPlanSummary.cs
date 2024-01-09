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
    /// The summary of a DR plan.
    /// </summary>
    public class DrPlanSummary 
    {
        
        /// <value>
        /// The OCID of the DR plan.
        /// <br/>
        /// Example: ocid1.drplan.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the DR plan.
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
        /// The display name of the DR plan.
        /// <br/>
        /// Example: EBS Switchover PHX to IAD
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The type of the DR plan.
        /// <br/>
        /// Example: SWITCHOVER
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DrPlanType> Type { get; set; }
        
        /// <value>
        /// The OCID of the DR protection group to which this DR plan belongs.
        /// <br/>
        /// Example: ocid1.drprotectiongroup.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DrProtectionGroupId is required.")]
        [JsonProperty(PropertyName = "drProtectionGroupId")]
        public string DrProtectionGroupId { get; set; }
        
        /// <value>
        /// The OCID of the peer DR protection group associated with this plan's
        /// DR protection group.
        /// <br/>
        /// Example: ocid1.drprotectiongroup.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PeerDrProtectionGroupId is required.")]
        [JsonProperty(PropertyName = "peerDrProtectionGroupId")]
        public string PeerDrProtectionGroupId { get; set; }
        
        /// <value>
        /// The region of the peer DR protection group associated with this plan's
        /// DR protection group.
        /// <br/>
        /// Example: us-ashburn-1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PeerRegion is required.")]
        [JsonProperty(PropertyName = "peerRegion")]
        public string PeerRegion { get; set; }
        
        /// <value>
        /// The date and time the DR plan was created. An RFC3339 formatted datetime string.
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
        /// The date and time the DR plan was updated. An RFC3339 formatted datetime string.
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
        /// The current state of the DR plan.
        /// <br/>
        /// Example: ACTIVE
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DrPlanLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the DR plan's current state in more detail.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifeCycleDetails")]
        public string LifeCycleDetails { get; set; }
        
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
