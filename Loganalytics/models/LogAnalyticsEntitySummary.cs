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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Summary of a log analytics entity.
    /// 
    /// </summary>
    public class LogAnalyticsEntitySummary 
    {
        
        /// <value>
        /// The log analytics entity OCID. This ID is a reference used by log analytics features and it represents
        /// a resource that is provisioned and managed by the customer on their premises or on the cloud.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Log analytics entity name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Compartment Identifier [OCID] (https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Log analytics entity type name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityTypeName is required.")]
        [JsonProperty(PropertyName = "entityTypeName")]
        public string EntityTypeName { get; set; }
        
        /// <value>
        /// Internal name for the log analytics entity type.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityTypeInternalName is required.")]
        [JsonProperty(PropertyName = "entityTypeInternalName")]
        public string EntityTypeInternalName { get; set; }
        
        /// <value>
        /// The current state of the log analytics entity.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<EntityLifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// lifecycleDetails has additional information regarding substeps such as management agent plugin deployment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleDetails is required.")]
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The OCID of the Management Agent.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "managementAgentId")]
        public string ManagementAgentId { get; set; }
        
        /// <value>
        /// The OCID of the Cloud resource which this entity is a representation of. This may be blank when the entity
        /// represents a non-cloud resource that the customer may have on their premises.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cloudResourceId")]
        public string CloudResourceId { get; set; }
        
        /// <value>
        /// The timezone region of the log analytics entity.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timezoneRegion")]
        public string TimezoneRegion { get; set; }
        
        /// <value>
        /// The date and time the resource was created, in the format defined by RFC3339.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the resource was last updated, in the format defined by RFC3339.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The date and time the resource was last discovered, in the format defined by RFC3339.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeLastDiscovered")]
        public System.Nullable<System.DateTime> TimeLastDiscovered { get; set; }
        
        [JsonProperty(PropertyName = "metadata")]
        public LogAnalyticsMetadataCollection Metadata { get; set; }
        
        /// <value>
        /// The Boolean flag to indicate if logs are collected for an entity for log analytics usage.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "areLogsCollected")]
        public System.Nullable<bool> AreLogsCollected { get; set; }
        
        /// <value>
        /// This indicates the type of source. It is primarily for Enterprise Manager Repository ID.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }
        
        [JsonProperty(PropertyName = "creationSource")]
        public CreationSource CreationSource { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
