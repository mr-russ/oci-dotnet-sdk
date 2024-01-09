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
    /// Represents an attachment between a VNIC and an instance. For more information, see
    /// [Virtual Network Interface Cards (VNICs)](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/managingVNICs.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you
    /// supply string values using the API.
    /// 
    /// </summary>
    public class VnicAttachment 
    {
        
        /// <value>
        /// The availability domain of the instance.
        /// <br/>
        /// Example: Uocm:PHX-AD-1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The OCID of the compartment the VNIC attachment is in, which is the same
        /// compartment the instance is in.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the VNIC attachment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceId is required.")]
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }
                ///
        /// <value>
        /// The current state of the VNIC attachment.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ATTACHING")]
            Attaching,
            [EnumMember(Value = "ATTACHED")]
            Attached,
            [EnumMember(Value = "DETACHING")]
            Detaching,
            [EnumMember(Value = "DETACHED")]
            Detached
        };

        /// <value>
        /// The current state of the VNIC attachment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Which physical network interface card (NIC) the VNIC uses.
        /// Certain bare metal instance shapes have two active physical NICs (0 and 1). If
        /// you add a secondary VNIC to one of these instances, you can specify which NIC
        /// the VNIC will use. For more information, see
        /// [Virtual Network Interface Cards (VNICs)](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/managingVNICs.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nicIndex")]
        public System.Nullable<int> NicIndex { get; set; }
        
        /// <value>
        /// The OCID of the subnet to create the VNIC in.
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The OCID of the VLAN to create the VNIC in. Creating the VNIC in a VLAN (instead
        /// of a subnet) is possible only if you are an Oracle Cloud VMware Solution customer.
        /// See {@link Vlan}.
        /// <br/>
        /// An error is returned if the instance already has a VNIC attached to it from this VLAN.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vlanId")]
        public string VlanId { get; set; }
        
        /// <value>
        /// The date and time the VNIC attachment was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The Oracle-assigned VLAN tag of the attached VNIC. Available after the
        /// attachment process is complete.
        /// <br/>
        /// However, if the VNIC belongs to a VLAN as part of the Oracle Cloud VMware Solution,
        /// the `vlanTag` value is instead the value of the `vlanTag` attribute for the VLAN.
        /// See {@link Vlan}.
        /// <br/>
        /// Example: 0
        /// </value>
        [JsonProperty(PropertyName = "vlanTag")]
        public System.Nullable<int> VlanTag { get; set; }
        
        /// <value>
        /// The OCID of the VNIC. Available after the attachment process is complete.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vnicId")]
        public string VnicId { get; set; }
        
    }
}
