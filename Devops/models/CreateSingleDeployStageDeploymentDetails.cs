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
    /// Details of a new deployment to be created that will run a single stage of the pipeline.
    /// </summary>
    public class CreateSingleDeployStageDeploymentDetails : CreateDeploymentDetails
    {
        
        /// <value>
        /// Specifies the OCID of the stage to be redeployed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeployStageId is required.")]
        [JsonProperty(PropertyName = "deployStageId")]
        public string DeployStageId { get; set; }
        
        [JsonProperty(PropertyName = "deploymentArguments")]
        public DeploymentArgumentCollection DeploymentArguments { get; set; }
        
        [JsonProperty(PropertyName = "deployStageOverrideArguments")]
        public DeployStageOverrideArgumentCollection DeployStageOverrideArguments { get; set; }
        
        [JsonProperty(PropertyName = "deployArtifactOverrideArguments")]
        public DeployArtifactOverrideArgumentCollection DeployArtifactOverrideArguments { get; set; }
        
        [JsonProperty(PropertyName = "deploymentType")]
        private readonly string deploymentType = "SINGLE_STAGE_DEPLOYMENT";
    }
}
