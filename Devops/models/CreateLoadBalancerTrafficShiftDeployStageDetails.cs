/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Specifies load balancer traffic shift stage.
    /// </summary>
    public class CreateLoadBalancerTrafficShiftDeployStageDetails : CreateDeployStageDetails
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BlueBackendIps is required.")]
        [JsonProperty(PropertyName = "blueBackendIps")]
        public BackendSetIpCollection BlueBackendIps { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GreenBackendIps is required.")]
        [JsonProperty(PropertyName = "greenBackendIps")]
        public BackendSetIpCollection GreenBackendIps { get; set; }
        
        /// <value>
        /// Specifies the target or destination backend set. Example: BLUE - Traffic from the existing backends of managed Load Balance Listener to blue Backend IPs, as per rolloutPolicy. GREEN - Traffic from the existing backends of managed Load Balance Listener to blue Backend IPs ser as per rolloutPolicy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TrafficShiftTarget is required.")]
        [JsonProperty(PropertyName = "trafficShiftTarget")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LoadBalancerTrafficShiftDeployStage.TrafficShiftTargetEnum> TrafficShiftTarget { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RolloutPolicy is required.")]
        [JsonProperty(PropertyName = "rolloutPolicy")]
        public LoadBalancerTrafficShiftRolloutPolicy RolloutPolicy { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LoadBalancerConfig is required.")]
        [JsonProperty(PropertyName = "loadBalancerConfig")]
        public LoadBalancerConfig LoadBalancerConfig { get; set; }
        
        [JsonProperty(PropertyName = "rollbackPolicy")]
        public DeployStageRollbackPolicy RollbackPolicy { get; set; }
        
        [JsonProperty(PropertyName = "deployStageType")]
        private readonly string deployStageType = "LOAD_BALANCER_TRAFFIC_SHIFT";
    }
}
