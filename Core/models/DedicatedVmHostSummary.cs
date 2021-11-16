/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// A dedicated virtual machine (VM) host lets you host multiple instances on a dedicated server that is not shared with other tenancies.
    /// 
    /// </summary>
    public class DedicatedVmHostSummary 
    {
        
        /// <value>
        /// The availability domain the dedicated VM host is running in.
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
        /// The OCID of the compartment that contains the dedicated VM host.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The shape of the dedicated VM host. The shape determines the number of CPUs and
        /// other resources available for VMs.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DedicatedVmHostShape is required.")]
        [JsonProperty(PropertyName = "dedicatedVmHostShape")]
        public string DedicatedVmHostShape { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The fault domain for the dedicated VM host's assigned instances. For more information, see Fault Domains.
        /// <br/>
        /// If you do not specify the fault domain, the system selects one for you. To change the fault domain for a dedicated VM host,
        /// delete it and create a new dedicated VM host in the preferred fault domain.
        /// <br/>
        /// To get a list of fault domains, use the ListFaultDomains operation in the Identity and Access Management Service API.
        /// <br/>
        /// Example: FAULT-DOMAIN-1
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the dedicated VM host.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The current state of the dedicated VM host.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the dedicated VM host.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the dedicated VM host was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
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
        /// The current available OCPUs of the dedicated VM host.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RemainingOcpus is required.")]
        [JsonProperty(PropertyName = "remainingOcpus")]
        public System.Nullable<float> RemainingOcpus { get; set; }
        
        /// <value>
        /// The current total OCPUs of the dedicated VM host.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalOcpus is required.")]
        [JsonProperty(PropertyName = "totalOcpus")]
        public System.Nullable<float> TotalOcpus { get; set; }
        
        /// <value>
        /// The current total memory of the dedicated VM host, in GBs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "totalMemoryInGBs")]
        public System.Nullable<float> TotalMemoryInGBs { get; set; }
        
        /// <value>
        /// The current available memory of the dedicated VM host, in GBs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "remainingMemoryInGBs")]
        public System.Nullable<float> RemainingMemoryInGBs { get; set; }
        
    }
}
