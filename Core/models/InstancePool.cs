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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// An instance pool is a set of instances within the same region that are managed as a group.
    /// For more information about instance pools and instance configurations, see
    /// [Managing Compute Instances](https://docs.cloud.oracle.com/iaas/Content/Compute/Concepts/instancemanagement.htm).
    /// 
    /// </summary>
    public class InstancePool 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the instance pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the instance
        /// pool.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the instance configuration associated
        /// with the instance pool.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceConfigurationId is required.")]
        [JsonProperty(PropertyName = "instanceConfigurationId")]
        public string InstanceConfigurationId { get; set; }
                ///
        /// <value>
        /// The current state of the instance pool.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "SCALING")]
            Scaling,
            [EnumMember(Value = "STARTING")]
            Starting,
            [EnumMember(Value = "STOPPING")]
            Stopping,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "STOPPED")]
            Stopped,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "RUNNING")]
            Running
        };

        /// <value>
        /// The current state of the instance pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The placement configurations for the instance pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlacementConfigurations is required.")]
        [JsonProperty(PropertyName = "placementConfigurations")]
        public System.Collections.Generic.List<InstancePoolPlacementConfiguration> PlacementConfigurations { get; set; }
        
        /// <value>
        /// The number of instances that should be in the instance pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Size is required.")]
        [JsonProperty(PropertyName = "size")]
        public System.Nullable<int> Size { get; set; }
        
        /// <value>
        /// The date and time the instance pool was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The load balancers attached to the instance pool.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "loadBalancers")]
        public System.Collections.Generic.List<InstancePoolLoadBalancerAttachment> LoadBalancers { get; set; }
        
        /// <value>
        /// A user-friendly formatter for the instance pool's instances. Instance displaynames follow the format.
        /// The formatter does not retroactively change instance's displaynames, only instance displaynames in the future follow the format
        /// 
        /// </value>
        [JsonProperty(PropertyName = "instanceDisplayNameFormatter")]
        public string InstanceDisplayNameFormatter { get; set; }
        
        /// <value>
        /// A user-friendly formatter for the instance pool's instances. Instance hostnames follow the format.
        /// The formatter does not retroactively change instance's hostnames, only instance hostnames in the future follow the format
        /// 
        /// </value>
        [JsonProperty(PropertyName = "instanceHostnameFormatter")]
        public string InstanceHostnameFormatter { get; set; }
        
    }
}
