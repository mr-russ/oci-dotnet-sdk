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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Represents a load balancer that is attached to an instance pool.
    /// </summary>
    public class InstancePoolLoadBalancerAttachment 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the load balancer attachment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the instance pool of the load balancer attachment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstancePoolId is required.")]
        [JsonProperty(PropertyName = "instancePoolId")]
        public string InstancePoolId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the load balancer attached to the instance pool.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LoadBalancerId is required.")]
        [JsonProperty(PropertyName = "loadBalancerId")]
        public string LoadBalancerId { get; set; }
        
        /// <value>
        /// The name of the backend set on the load balancer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackendSetName is required.")]
        [JsonProperty(PropertyName = "backendSetName")]
        public string BackendSetName { get; set; }
        
        /// <value>
        /// The port value used for the backends.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// Indicates which VNIC on each instance in the instance pool should be used to associate with the load balancer.
        /// Possible values are \"PrimaryVnic\" or the displayName of one of the secondary VNICs on the instance configuration
        /// that is associated with the instance pool.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VnicSelection is required.")]
        [JsonProperty(PropertyName = "vnicSelection")]
        public string VnicSelection { get; set; }
                ///
        /// <value>
        /// The status of the interaction between the instance pool and the load balancer.
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
        /// The status of the interaction between the instance pool and the load balancer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
    }
}
