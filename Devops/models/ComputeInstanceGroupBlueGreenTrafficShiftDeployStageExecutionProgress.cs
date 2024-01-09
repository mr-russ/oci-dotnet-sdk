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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Specifies the Instance Group Blue-Green deployment load balancer traffic shift stage.
    /// </summary>
    public class ComputeInstanceGroupBlueGreenTrafficShiftDeployStageExecutionProgress : DeployStageExecutionProgress
    {
        
        /// <value>
        /// The OCID of the environment where traffic is going.
        /// </value>
        [JsonProperty(PropertyName = "environmentId")]
        public string EnvironmentId { get; set; }
        
        [JsonProperty(PropertyName = "deployStageType")]
        private readonly string deployStageType = "COMPUTE_INSTANCE_GROUP_BLUE_GREEN_TRAFFIC_SHIFT";
    }
}
