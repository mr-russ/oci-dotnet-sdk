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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The view entity data entity details.
    /// </summary>
    public class DataEntitySummaryFromDataStore : DataEntitySummary
    {
        
        /// <value>
        /// The object key.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The object's model version.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value is editable and is restricted to 1000 characters.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Detailed description for the object.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The version of the object that is used to track changes in the object instance.
        /// </value>
        [JsonProperty(PropertyName = "objectVersion")]
        public System.Nullable<int> ObjectVersion { get; set; }
        
        /// <value>
        /// The external key for the object
        /// </value>
        [JsonProperty(PropertyName = "externalKey")]
        public string ExternalKey { get; set; }
        
        [JsonProperty(PropertyName = "shape")]
        public Shape Shape { get; set; }
        
        /// <value>
        /// The shape ID.
        /// </value>
        [JsonProperty(PropertyName = "shapeId")]
        public string ShapeId { get; set; }
        
        [JsonProperty(PropertyName = "types")]
        public TypeLibrary Types { get; set; }
                ///
        /// <value>
        /// The entity type.
        /// </value>
        ///
        public enum EntityTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "TABLE")]
            Table,
            [EnumMember(Value = "VIEW")]
            View,
            [EnumMember(Value = "FILE")]
            File,
            [EnumMember(Value = "QUEUE")]
            Queue,
            [EnumMember(Value = "STREAM")]
            Stream,
            [EnumMember(Value = "OTHER")]
            Other,
            [EnumMember(Value = "DATA_STORE")]
            DataStore
        };

        /// <value>
        /// The entity type.
        /// </value>
        [JsonProperty(PropertyName = "entityType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<EntityTypeEnum> EntityType { get; set; }
        
        /// <value>
        /// Specifies other type label.
        /// </value>
        [JsonProperty(PropertyName = "otherTypeLabel")]
        public string OtherTypeLabel { get; set; }
        
        /// <value>
        /// An array of unique keys.
        /// </value>
        [JsonProperty(PropertyName = "uniqueKeys")]
        public System.Collections.Generic.List<UniqueKey> UniqueKeys { get; set; }
        
        /// <value>
        /// An array of foreign keys.
        /// </value>
        [JsonProperty(PropertyName = "foreignKeys")]
        public System.Collections.Generic.List<ForeignKey> ForeignKeys { get; set; }
        
        /// <value>
        /// The resource name.
        /// </value>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// Query filter for the extract. It can be Null.
        /// </value>
        [JsonProperty(PropertyName = "filters")]
        public string Filters { get; set; }
        
        /// <value>
        /// It shows whether or not effective date is disabled
        /// </value>
        [JsonProperty(PropertyName = "isEffectiveDateDisabled")]
        public System.Nullable<bool> IsEffectiveDateDisabled { get; set; }
        
        /// <value>
        /// Is Flex data store. Metadata csv will be generated for flex data store
        /// </value>
        [JsonProperty(PropertyName = "isFlexDataStore")]
        public System.Nullable<bool> IsFlexDataStore { get; set; }
        
        /// <value>
        /// Should the VO failure fail the whole batch?
        /// </value>
        [JsonProperty(PropertyName = "isSilentError")]
        public System.Nullable<bool> IsSilentError { get; set; }
        
        /// <value>
        /// It shows whether the datastore supports Incremental Extract or not.
        /// </value>
        [JsonProperty(PropertyName = "supportsIncremental")]
        public System.Nullable<bool> SupportsIncremental { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "DATA_STORE_ENTITY";
    }
}
