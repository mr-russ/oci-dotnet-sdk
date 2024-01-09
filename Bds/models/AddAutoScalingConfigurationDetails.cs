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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// The information about the autoscale configuration.
    /// </summary>
    public class AddAutoScalingConfigurationDetails 
    {
        
        /// <value>
        /// A user-friendly name. The name does not have to be unique, and it may be changed. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A node type that is managed by an autoscale configuration. The only supported types are WORKER and COMPUTE_ONLY_WORKER.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NodeType is required.")]
        [JsonProperty(PropertyName = "nodeType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Node.NodeTypeEnum> NodeType { get; set; }
        
        /// <value>
        /// Whether the autoscale configuration is enabled.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsEnabled is required.")]
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// Base-64 encoded password for the cluster (and Cloudera Manager) admin user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterAdminPassword is required.")]
        [JsonProperty(PropertyName = "clusterAdminPassword")]
        public string ClusterAdminPassword { get; set; }
        
        [JsonProperty(PropertyName = "policy")]
        public AutoScalePolicy Policy { get; set; }
        
        [JsonProperty(PropertyName = "policyDetails")]
        public AddAutoScalePolicyDetails PolicyDetails { get; set; }
        
    }
}
