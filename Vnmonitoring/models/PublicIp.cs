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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// A *public IP* is a conceptual term that refers to a public IP address and related properties.
    /// The `publicIp` object is the API representation of a public IP.
    /// <br/>
    /// There are two types of public IPs:
    /// 1. Ephemeral
    /// 2. Reserved
    /// <br/>
    /// For more information and comparison of the two types,
    /// see [Public IP Addresses](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/managingpublicIPs.htm).
    /// 
    /// </summary>
    public class PublicIp 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the entity the public IP is assigned to, or in the process of
        /// being assigned to.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "assignedEntityId")]
        public string AssignedEntityId { get; set; }
                ///
        /// <value>
        /// The type of entity the public IP is assigned to, or in the process of being
        /// assigned to.
        /// 
        /// </value>
        ///
        public enum AssignedEntityTypeEnum {
            [EnumMember(Value = "PRIVATE_IP")]
            PrivateIp,
            [EnumMember(Value = "NAT_GATEWAY")]
            NatGateway
        };

        /// <value>
        /// The type of entity the public IP is assigned to, or in the process of being
        /// assigned to.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "assignedEntityType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AssignedEntityTypeEnum> AssignedEntityType { get; set; }
        
        /// <value>
        /// The public IP's availability domain. This property is set only for ephemeral public IPs
        /// that are assigned to a private IP (that is, when the `scope` of the public IP is set to
        /// AVAILABILITY_DOMAIN). The value is the availability domain of the assigned private IP.
        /// <br/>
        /// Example: Uocm:PHX-AD-1
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the public IP. For an ephemeral public IP, this is
        /// the compartment of its assigned entity (which can be a private IP or a regional entity such
        /// as a NAT gateway). For a reserved public IP that is currently assigned,
        /// its compartment can be different from the assigned private IP's.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
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
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The public IP's Oracle ID ([OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm)).
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The public IP address of the `publicIp` object.
        /// <br/>
        /// Example: 203.0.113.2
        /// </value>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
                ///
        /// <value>
        /// The public IP's current state.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "ASSIGNING")]
            Assigning,
            [EnumMember(Value = "ASSIGNED")]
            Assigned,
            [EnumMember(Value = "UNASSIGNING")]
            Unassigning,
            [EnumMember(Value = "UNASSIGNED")]
            Unassigned,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated
        };

        /// <value>
        /// The public IP's current state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
                ///
        /// <value>
        /// Defines when the public IP is deleted and released back to Oracle's public IP pool.
        /// <br/>
        /// * `EPHEMERAL`: The lifetime is tied to the lifetime of its assigned entity. An ephemeral
        /// public IP must always be assigned to an entity. If the assigned entity is a private IP,
        /// the ephemeral public IP is automatically deleted when the private IP is deleted, when
        /// the VNIC is terminated, or when the instance is terminated. If the assigned entity is a
        /// {@link NatGateway}, the ephemeral public IP is automatically
        /// deleted when the NAT gateway is terminated.
        /// <br/>
        /// * `RESERVED`: You control the public IP's lifetime. You can delete a reserved public IP
        /// whenever you like. It does not need to be assigned to a private IP at all times.
        /// <br/>
        /// For more information and comparison of the two types,
        /// see [Public IP Addresses](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/managingpublicIPs.htm).
        /// 
        /// </value>
        ///
        public enum LifetimeEnum {
            [EnumMember(Value = "EPHEMERAL")]
            Ephemeral,
            [EnumMember(Value = "RESERVED")]
            Reserved
        };

        /// <value>
        /// Defines when the public IP is deleted and released back to Oracle's public IP pool.
        /// <br/>
        /// * `EPHEMERAL`: The lifetime is tied to the lifetime of its assigned entity. An ephemeral
        /// public IP must always be assigned to an entity. If the assigned entity is a private IP,
        /// the ephemeral public IP is automatically deleted when the private IP is deleted, when
        /// the VNIC is terminated, or when the instance is terminated. If the assigned entity is a
        /// {@link NatGateway}, the ephemeral public IP is automatically
        /// deleted when the NAT gateway is terminated.
        /// <br/>
        /// * `RESERVED`: You control the public IP's lifetime. You can delete a reserved public IP
        /// whenever you like. It does not need to be assigned to a private IP at all times.
        /// <br/>
        /// For more information and comparison of the two types,
        /// see [Public IP Addresses](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/managingpublicIPs.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifetime")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifetimeEnum> Lifetime { get; set; }
        
        /// <value>
        /// Deprecated. Use `assignedEntityId` instead.
        /// <br/>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the private IP that the public IP is currently assigned to, or in the
        /// process of being assigned to.
        /// <br/>
        /// **Note:** This is `null` if the public IP is not assigned to a private IP, or is
        /// in the process of being assigned to one.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateIpId")]
        public string PrivateIpId { get; set; }
                ///
        /// <value>
        /// Whether the public IP is regional or specific to a particular availability domain.
        /// <br/>
        /// * `REGION`: The public IP exists within a region and is assigned to a regional entity
        /// (such as a {@link NatGateway}), or can be assigned to a private
        /// IP in any availability domain in the region. Reserved public IPs and ephemeral public IPs
        /// assigned to a regional entity have `scope` = `REGION`.
        /// <br/>
        /// * `AVAILABILITY_DOMAIN`: The public IP exists within the availability domain of the entity
        /// it's assigned to, which is specified by the `availabilityDomain` property of the public IP object.
        /// Ephemeral public IPs that are assigned to private IPs have `scope` = `AVAILABILITY_DOMAIN`.
        /// 
        /// </value>
        ///
        public enum ScopeEnum {
            [EnumMember(Value = "REGION")]
            Region,
            [EnumMember(Value = "AVAILABILITY_DOMAIN")]
            AvailabilityDomain
        };

        /// <value>
        /// Whether the public IP is regional or specific to a particular availability domain.
        /// <br/>
        /// * `REGION`: The public IP exists within a region and is assigned to a regional entity
        /// (such as a {@link NatGateway}), or can be assigned to a private
        /// IP in any availability domain in the region. Reserved public IPs and ephemeral public IPs
        /// assigned to a regional entity have `scope` = `REGION`.
        /// <br/>
        /// * `AVAILABILITY_DOMAIN`: The public IP exists within the availability domain of the entity
        /// it's assigned to, which is specified by the `availabilityDomain` property of the public IP object.
        /// Ephemeral public IPs that are assigned to private IPs have `scope` = `AVAILABILITY_DOMAIN`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scope")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ScopeEnum> Scope { get; set; }
        
        /// <value>
        /// The date and time the public IP was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the pool object created in the current tenancy.
        /// </value>
        [JsonProperty(PropertyName = "publicIpPoolId")]
        public string PublicIpPoolId { get; set; }
        
    }
}
