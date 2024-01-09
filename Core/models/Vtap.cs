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
    /// A virtual test access point (VTAP) provides a way to mirror all traffic from a designated source to a selected target in order to facilitate troubleshooting, security analysis, and data monitoring.
    /// A VTAP is functionally similar to a test access point (TAP) you might deploy in your on-premises network.
    /// <br/>
    /// A *{@link CaptureFilter}* contains a set of *{@link #captureFilterRuleDetails(CaptureFilterRuleDetailsRequest) captureFilterRuleDetails}* governing what traffic a VTAP mirrors.
    /// 
    /// </summary>
    public class Vtap 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the `Vtap` resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VCN containing the `Vtap` resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
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
        /// The VTAP's Oracle ID ([OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm)).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The VTAP's administrative lifecycle state.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated
        };

        /// <value>
        /// The VTAP's administrative lifecycle state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
                ///
        /// <value>
        /// The VTAP's current running state.
        /// </value>
        ///
        public enum LifecycleStateDetailsEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "RUNNING")]
            Running,
            [EnumMember(Value = "STOPPED")]
            Stopped
        };

        /// <value>
        /// The VTAP's current running state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleStateDetails")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateDetailsEnum> LifecycleStateDetails { get; set; }
        
        /// <value>
        /// The date and time the VTAP was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2020-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the source point where packets are captured.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceId is required.")]
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the destination resource where mirrored packets are sent.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The IP address of the destination resource where mirrored packets are sent.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetIp")]
        public string TargetIp { get; set; }
        
        /// <value>
        /// The capture filter's Oracle ID ([OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm)).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CaptureFilterId is required.")]
        [JsonProperty(PropertyName = "captureFilterId")]
        public string CaptureFilterId { get; set; }
                ///
        /// <value>
        /// Defines an encapsulation header type for the VTAP's mirrored traffic.
        /// 
        /// </value>
        ///
        public enum EncapsulationProtocolEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "VXLAN")]
            Vxlan
        };

        /// <value>
        /// Defines an encapsulation header type for the VTAP's mirrored traffic.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "encapsulationProtocol")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<EncapsulationProtocolEnum> EncapsulationProtocol { get; set; }
        
        /// <value>
        /// The virtual extensible LAN (VXLAN) network identifier (or VXLAN segment ID) that uniquely identifies the VXLAN.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vxlanNetworkIdentifier")]
        public System.Nullable<long> VxlanNetworkIdentifier { get; set; }
        
        /// <value>
        /// Used to start or stop a `Vtap` resource.
        /// <br/>
        /// * `TRUE` directs the VTAP to start mirroring traffic.
        /// * `FALSE` (Default) directs the VTAP to stop mirroring traffic.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isVtapEnabled")]
        public System.Nullable<bool> IsVtapEnabled { get; set; }
                ///
        /// <value>
        /// The source type for the VTAP.
        /// 
        /// </value>
        ///
        public enum SourceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "VNIC")]
            Vnic,
            [EnumMember(Value = "SUBNET")]
            Subnet,
            [EnumMember(Value = "LOAD_BALANCER")]
            LoadBalancer,
            [EnumMember(Value = "DB_SYSTEM")]
            DbSystem,
            [EnumMember(Value = "EXADATA_VM_CLUSTER")]
            ExadataVmCluster,
            [EnumMember(Value = "AUTONOMOUS_DATA_WAREHOUSE")]
            AutonomousDataWarehouse
        };

        /// <value>
        /// The source type for the VTAP.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SourceTypeEnum> SourceType { get; set; }
                ///
        /// <value>
        /// Used to control the priority of traffic. It is an optional field. If it not passed, the value is DEFAULT
        /// </value>
        ///
        public enum TrafficModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DEFAULT")]
            Default,
            [EnumMember(Value = "PRIORITY")]
            Priority
        };

        /// <value>
        /// Used to control the priority of traffic. It is an optional field. If it not passed, the value is DEFAULT
        /// </value>
        [JsonProperty(PropertyName = "trafficMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TrafficModeEnum> TrafficMode { get; set; }
        
        /// <value>
        /// The maximum size of the packets to be included in the filter.
        /// </value>
        [JsonProperty(PropertyName = "maxPacketSize")]
        public System.Nullable<int> MaxPacketSize { get; set; }
                ///
        /// <value>
        /// The target type for the VTAP.
        /// 
        /// </value>
        ///
        public enum TargetTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "VNIC")]
            Vnic,
            [EnumMember(Value = "NETWORK_LOAD_BALANCER")]
            NetworkLoadBalancer,
            [EnumMember(Value = "IP_ADDRESS")]
            IpAddress
        };

        /// <value>
        /// The target type for the VTAP.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TargetTypeEnum> TargetType { get; set; }
        
        /// <value>
        /// The IP Address of the source private endpoint.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourcePrivateEndpointIp")]
        public string SourcePrivateEndpointIp { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the subnet that source private endpoint belongs to.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourcePrivateEndpointSubnetId")]
        public string SourcePrivateEndpointSubnetId { get; set; }
        
    }
}
