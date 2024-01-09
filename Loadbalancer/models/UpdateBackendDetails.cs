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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// The configuration details for updating a backend server.
    /// </summary>
    public class UpdateBackendDetails 
    {
        
        /// <value>
        /// The load balancing policy weight assigned to the server. Backend servers with a higher weight receive a larger
        /// proportion of incoming traffic. For example, a server weighted '3' receives 3 times the number of new connections
        /// as a server weighted '1'.
        /// For more information on load balancing policies, see
        /// [How Load Balancing Policies Work](https://docs.cloud.oracle.com/Content/Balance/Reference/lbpolicies.htm).
        /// <br/>
        /// Example: 3
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Weight is required.")]
        [JsonProperty(PropertyName = "weight")]
        public System.Nullable<int> Weight { get; set; }
        
        /// <value>
        /// Whether the load balancer should treat this server as a backup unit. If `true`, the load balancer forwards no ingress
        /// traffic to this backend server unless all other backend servers not marked as \"backup\" fail the health check policy.
        /// <br/>
        /// **Note:** You cannot add a backend server marked as `backup` to a backend set that uses the IP Hash policy.
        /// <br/>
        /// Example: false
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Backup is required.")]
        [JsonProperty(PropertyName = "backup")]
        public System.Nullable<bool> Backup { get; set; }
        
        /// <value>
        /// Whether the load balancer should drain this server. Servers marked \"drain\" receive no new
        /// incoming traffic.
        /// <br/>
        /// Example: false
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Drain is required.")]
        [JsonProperty(PropertyName = "drain")]
        public System.Nullable<bool> Drain { get; set; }
        
        /// <value>
        /// Whether the load balancer should treat this server as offline. Offline servers receive no incoming
        /// traffic.
        /// <br/>
        /// Example: false
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Offline is required.")]
        [JsonProperty(PropertyName = "offline")]
        public System.Nullable<bool> Offline { get; set; }
        
    }
}
