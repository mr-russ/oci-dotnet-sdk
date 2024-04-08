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


namespace Oci.NetworkloadbalancerService.Models
{
    /// <summary>
    /// The configuration of a network load balancer backend set.
    /// For more information about backend set configuration, see
    /// [Managing Backend Sets](https://docs.cloud.oracle.com/Content/NetworkLoadBalancer/BackendSets/backend-set-management.htm).
    /// <br/>
    /// **Caution:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class BackendSetSummary 
    {
        
        /// <value>
        /// A user-friendly name for the backend set that must be unique and cannot be changed.
        /// <br/>
        /// Valid backend set names include only alphanumeric characters, dashes, and underscores. Backend set names cannot
        /// contain spaces. Avoid entering confidential information.
        /// <br/>
        /// Example: example_backend_set
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The network load balancer policy for the backend set.
        /// <br/>
        /// Example: FIVE_TUPLE
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Policy is required.")]
        [JsonProperty(PropertyName = "policy")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NetworkLoadBalancingPolicy> Policy { get; set; }
        
        /// <value>
        /// If this parameter is enabled, the network load balancer preserves the source IP of the packet forwarded to the backend servers.
        /// Backend servers see the original source IP. If the `isPreserveSourceDestination` parameter is enabled for the network load balancer resource, this parameter cannot be disabled.
        /// The value is true by default.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isPreserveSource")]
        public System.Nullable<bool> IsPreserveSource { get; set; }
        
        /// <value>
        /// If enabled, the network load balancer will continue to distribute traffic in the configured distribution in the event all backends are unhealthy.
        /// The value is false by default.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isFailOpen")]
        public System.Nullable<bool> IsFailOpen { get; set; }
        
        /// <value>
        /// If enabled existing connections will be forwarded to an alternative healthy backend as soon as current backend becomes unhealthy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isInstantFailoverEnabled")]
        public System.Nullable<bool> IsInstantFailoverEnabled { get; set; }
        
        /// <value>
        /// IP version associated with the backend set.
        /// </value>
        [JsonProperty(PropertyName = "ipVersion")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<IpVersion> IpVersion { get; set; }
        
        /// <value>
        /// An array of backends.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Backends is required.")]
        [JsonProperty(PropertyName = "backends")]
        public System.Collections.Generic.List<Backend> Backends { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HealthChecker is required.")]
        [JsonProperty(PropertyName = "healthChecker")]
        public HealthChecker HealthChecker { get; set; }
        
    }
}
