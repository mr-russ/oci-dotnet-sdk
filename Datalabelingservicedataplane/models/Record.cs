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


namespace Oci.DatalabelingservicedataplaneService.Models
{
    /// <summary>
    /// A record represents an entry in a dataset that needs labeling.
    /// </summary>
    public class Record 
    {
        
        /// <value>
        /// The OCID of the record.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name is created by the user. It is unique and immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The date and time the resource was created, in the timestamp format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the resource was updated, in the timestamp format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The OCID of the dataset to associate the record with.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatasetId is required.")]
        [JsonProperty(PropertyName = "datasetId")]
        public string DatasetId { get; set; }
        
        /// <value>
        /// The OCID of the compartment for the task.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceDetails is required.")]
        [JsonProperty(PropertyName = "sourceDetails")]
        public SourceDetails SourceDetails { get; set; }
        
        /// <value>
        /// Whether or not the record has been labeled and has associated annotations.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsLabeled is required.")]
        [JsonProperty(PropertyName = "isLabeled")]
        public System.Nullable<bool> IsLabeled { get; set; }
                ///
        /// <value>
        /// The lifecycle state of the record.
        /// ACTIVE - The record is active and ready for labeling.
        /// INACTIVE - The record has been marked as inactive and should not be used for labeling.
        /// DELETED - The record has been deleted and is no longer available for labeling.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The lifecycle state of the record.
        /// ACTIVE - The record is active and ready for labeling.
        /// INACTIVE - The record has been marked as inactive and should not be used for labeling.
        /// DELETED - The record has been deleted and is no longer available for labeling.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        [JsonProperty(PropertyName = "recordMetadata")]
        public RecordMetadata RecordMetadata { get; set; }
        
        /// <value>
        /// A simple key-value pair that is applied without any predefined name, type, or scope. It exists for cross-compatibility only.
        /// For Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
