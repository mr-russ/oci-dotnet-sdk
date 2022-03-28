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
using Newtonsoft.Json.Linq;

namespace Oci.DevopsService.Models
{
    /// <summary>
    /// A single node in a pipeline. It is usually associated with some action on a specific set of OCI resources such as environments. For example, updating a Function or a Kubernetes cluster.
    /// </summary>
    [JsonConverter(typeof(DeployStageModelConverter))]
    public class DeployStage 
    {
        
        /// <value>
        /// Unique identifier that is immutable on creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Optional description about the deployment stage.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Deployment stage display name, which can be renamed and is not necessarily unique. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of a project.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProjectId is required.")]
        [JsonProperty(PropertyName = "projectId")]
        public string ProjectId { get; set; }
        
        /// <value>
        /// The OCID of a pipeline.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeployPipelineId is required.")]
        [JsonProperty(PropertyName = "deployPipelineId")]
        public string DeployPipelineId { get; set; }
        
        /// <value>
        /// The OCID of a compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// Deployment stage type.
        /// </value>
        ///
        public enum DeployStageTypeEnum {
            [EnumMember(Value = "WAIT")]
            Wait,
            [EnumMember(Value = "COMPUTE_INSTANCE_GROUP_ROLLING_DEPLOYMENT")]
            ComputeInstanceGroupRollingDeployment,
            [EnumMember(Value = "COMPUTE_INSTANCE_GROUP_BLUE_GREEN_DEPLOYMENT")]
            ComputeInstanceGroupBlueGreenDeployment,
            [EnumMember(Value = "COMPUTE_INSTANCE_GROUP_BLUE_GREEN_TRAFFIC_SHIFT")]
            ComputeInstanceGroupBlueGreenTrafficShift,
            [EnumMember(Value = "COMPUTE_INSTANCE_GROUP_CANARY_DEPLOYMENT")]
            ComputeInstanceGroupCanaryDeployment,
            [EnumMember(Value = "COMPUTE_INSTANCE_GROUP_CANARY_TRAFFIC_SHIFT")]
            ComputeInstanceGroupCanaryTrafficShift,
            [EnumMember(Value = "COMPUTE_INSTANCE_GROUP_CANARY_APPROVAL")]
            ComputeInstanceGroupCanaryApproval,
            [EnumMember(Value = "OKE_BLUE_GREEN_DEPLOYMENT")]
            OkeBlueGreenDeployment,
            [EnumMember(Value = "OKE_BLUE_GREEN_TRAFFIC_SHIFT")]
            OkeBlueGreenTrafficShift,
            [EnumMember(Value = "OKE_CANARY_DEPLOYMENT")]
            OkeCanaryDeployment,
            [EnumMember(Value = "OKE_CANARY_TRAFFIC_SHIFT")]
            OkeCanaryTrafficShift,
            [EnumMember(Value = "OKE_CANARY_APPROVAL")]
            OkeCanaryApproval,
            [EnumMember(Value = "OKE_DEPLOYMENT")]
            OkeDeployment,
            [EnumMember(Value = "DEPLOY_FUNCTION")]
            DeployFunction,
            [EnumMember(Value = "INVOKE_FUNCTION")]
            InvokeFunction,
            [EnumMember(Value = "LOAD_BALANCER_TRAFFIC_SHIFT")]
            LoadBalancerTrafficShift,
            [EnumMember(Value = "MANUAL_APPROVAL")]
            ManualApproval
        };

        
        /// <value>
        /// Time the deployment stage was created. Format defined by [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Time the deployment stage was updated. Format defined by [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
                ///
        /// <value>
        /// The current state of the deployment stage.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the deployment stage.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        [JsonProperty(PropertyName = "deployStagePredecessorCollection")]
        public DeployStagePredecessorCollection DeployStagePredecessorCollection { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.  See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }

    public class DeployStageModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DeployStage);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DeployStage);
            var discriminator = jsonObject["deployStageType"].Value<string>();
            switch (discriminator)
            {
                case "COMPUTE_INSTANCE_GROUP_BLUE_GREEN_TRAFFIC_SHIFT":
                    obj = new ComputeInstanceGroupBlueGreenTrafficShiftDeployStage();
                    break;
                case "LOAD_BALANCER_TRAFFIC_SHIFT":
                    obj = new LoadBalancerTrafficShiftDeployStage();
                    break;
                case "INVOKE_FUNCTION":
                    obj = new InvokeFunctionDeployStage();
                    break;
                case "OKE_CANARY_DEPLOYMENT":
                    obj = new OkeCanaryDeployStage();
                    break;
                case "OKE_DEPLOYMENT":
                    obj = new OkeDeployStage();
                    break;
                case "OKE_CANARY_TRAFFIC_SHIFT":
                    obj = new OkeCanaryTrafficShiftDeployStage();
                    break;
                case "DEPLOY_FUNCTION":
                    obj = new FunctionDeployStage();
                    break;
                case "OKE_BLUE_GREEN_DEPLOYMENT":
                    obj = new OkeBlueGreenDeployStage();
                    break;
                case "OKE_CANARY_APPROVAL":
                    obj = new OkeCanaryApprovalDeployStage();
                    break;
                case "COMPUTE_INSTANCE_GROUP_CANARY_TRAFFIC_SHIFT":
                    obj = new ComputeInstanceGroupCanaryTrafficShiftDeployStage();
                    break;
                case "COMPUTE_INSTANCE_GROUP_CANARY_APPROVAL":
                    obj = new ComputeInstanceGroupCanaryApprovalDeployStage();
                    break;
                case "WAIT":
                    obj = new WaitDeployStage();
                    break;
                case "COMPUTE_INSTANCE_GROUP_BLUE_GREEN_DEPLOYMENT":
                    obj = new ComputeInstanceGroupBlueGreenDeployStage();
                    break;
                case "COMPUTE_INSTANCE_GROUP_CANARY_DEPLOYMENT":
                    obj = new ComputeInstanceGroupCanaryDeployStage();
                    break;
                case "OKE_BLUE_GREEN_TRAFFIC_SHIFT":
                    obj = new OkeBlueGreenTrafficShiftDeployStage();
                    break;
                case "MANUAL_APPROVAL":
                    obj = new ManualApprovalDeployStage();
                    break;
                case "COMPUTE_INSTANCE_GROUP_ROLLING_DEPLOYMENT":
                    obj = new ComputeInstanceGroupDeployStage();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
