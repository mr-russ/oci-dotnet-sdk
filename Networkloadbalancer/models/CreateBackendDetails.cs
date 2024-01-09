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
    /// The configuration of a backend server that is a member of a network load balancer backend set.
    /// For more information, see [Managing Backend Servers](https://docs.cloud.oracle.com/Content/Balance/Tasks/managingbackendservers.htm).
    /// 
    /// </summary>
    public class CreateBackendDetails 
    {
        
        /// <value>
        /// Optional unique name identifying the backend within the backend set. If not specified, then one will be generated.
        /// Example: webServer1
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The IP address of the backend server.
        /// Example: 10.0.0.3
        /// </value>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// The IP OCID/Instance OCID associated with the backend server.
        /// Example: ocid1.privateip..oc1.<var>&lt;unique_ID&gt;</var>
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The communication port for the backend server.
        /// <br/>
        /// Example: 8080
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The network load balancing policy weight assigned to the server. Backend servers with a higher weight receive a larger
        /// proportion of incoming traffic. For example, a server weighted '3' receives three times the number of new connections
        /// as a server weighted '1'.
        /// For more information about load balancing policies, see
        /// [How Network Load Balancing Policies Work](https://docs.cloud.oracle.com/Content/Balance/Reference/lbpolicies.htm).
        /// <br/>
        /// Example: 3
        /// </value>
        [JsonProperty(PropertyName = "weight")]
        public System.Nullable<int> Weight { get; set; }
        
        /// <value>
        /// Whether the network load balancer should drain this server. Servers marked \"isDrain\" receive no
        /// incoming traffic.
        /// <br/>
        /// Example: false
        /// </value>
        [JsonProperty(PropertyName = "isDrain")]
        public System.Nullable<bool> IsDrain { get; set; }
        
        /// <value>
        /// Whether the network load balancer should treat this server as a backup unit. If `true`, then the network load balancer forwards no ingress
        /// traffic to this backend server unless all other backend servers not marked as \"isBackup\" fail the health check policy.
        /// <br/>
        /// Example: false
        /// </value>
        [JsonProperty(PropertyName = "isBackup")]
        public System.Nullable<bool> IsBackup { get; set; }
        
        /// <value>
        /// Whether the network load balancer should treat this server as offline. Offline servers receive no incoming
        /// traffic.
        /// <br/>
        /// Example: false
        /// </value>
        [JsonProperty(PropertyName = "isOffline")]
        public System.Nullable<bool> IsOffline { get; set; }
        
    }
}
