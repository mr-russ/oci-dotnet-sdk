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


namespace Oci.AidocumentService.Models
{
    /// <summary>
    /// The metadata about the model.
    /// </summary>
    public class ModelSummary 
    {
        
        /// <value>
        /// A unique identifier that is immutable after creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A human-friendly name for the model, which can be changed.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// An optional description of the model.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The compartment identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The type of the Document model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelType is required.")]
        [JsonProperty(PropertyName = "modelType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Model.ModelTypeEnum> ModelType { get; set; }
        
        /// <value>
        /// The version of the model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelVersion is required.")]
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the project that contains the model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProjectId is required.")]
        [JsonProperty(PropertyName = "projectId")]
        public string ProjectId { get; set; }
        
        /// <value>
        /// When the model was created, as an RFC3339 datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// When the model was modified, as an RFC3339 datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Model.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail, that can provide actionable information if training failed.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The precision of the trained model.
        /// </value>
        [JsonProperty(PropertyName = "precision")]
        public System.Nullable<float> Precision { get; set; }
        
        /// <value>
        /// The tenancy id of the model.
        /// </value>
        [JsonProperty(PropertyName = "tenancyId")]
        public string TenancyId { get; set; }
        
        /// <value>
        /// the alias name of the model.
        /// </value>
        [JsonProperty(PropertyName = "aliasName")]
        public string AliasName { get; set; }
        
        [JsonProperty(PropertyName = "trainingDataset")]
        public Dataset TrainingDataset { get; set; }
        
        [JsonProperty(PropertyName = "testingDataset")]
        public Dataset TestingDataset { get; set; }
        
        [JsonProperty(PropertyName = "validationDataset")]
        public Dataset ValidationDataset { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) list of active custom Key Value models that need to be composed.
        /// </value>
        [JsonProperty(PropertyName = "componentModels")]
        public System.Collections.Generic.List<ComponentModel> ComponentModels { get; set; }
        
        /// <value>
        /// Set to true when the model is created by using multiple key value extraction models.
        /// </value>
        [JsonProperty(PropertyName = "isComposedModel")]
        public System.Nullable<bool> IsComposedModel { get; set; }
        
        /// <value>
        /// A simple key-value pair that is applied without any predefined name, type, or scope. It exists for cross-compatibility only.
        /// For Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// For Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
