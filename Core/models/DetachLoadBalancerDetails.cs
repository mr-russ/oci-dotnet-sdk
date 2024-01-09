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
    /// Represents a load balancer that is to be detached from an instance pool.
    /// </summary>
    public class DetachLoadBalancerDetails 
    {
        
        /// <value>
        /// The OCID of the load balancer to detach from the instance pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LoadBalancerId is required.")]
        [JsonProperty(PropertyName = "loadBalancerId")]
        public string LoadBalancerId { get; set; }
        
        /// <value>
        /// The name of the backend set on the load balancer to detach from the instance pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackendSetName is required.")]
        [JsonProperty(PropertyName = "backendSetName")]
        public string BackendSetName { get; set; }
        
    }
}
