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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The patch object contains the audit summary information and the definition of the patch.
    /// </summary>
    public class Patch 
    {
        
        /// <value>
        /// The object key.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The object type.
        /// </value>
        [JsonProperty(PropertyName = "modelType")]
        public string ModelType { get; set; }
        
        /// <value>
        /// The object's model version.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
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
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore, and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// The date and time the patch was applied, in the timestamp format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timePatched")]
        public System.Nullable<System.DateTime> TimePatched { get; set; }
        
        /// <value>
        /// The errors encountered while applying the patch, if any.
        /// </value>
        [JsonProperty(PropertyName = "errorMessages")]
        public System.Collections.Generic.Dictionary<string, string> ErrorMessages { get; set; }
        
        /// <value>
        /// The application version of the patch.
        /// </value>
        [JsonProperty(PropertyName = "applicationVersion")]
        public System.Nullable<int> ApplicationVersion { get; set; }
                ///
        /// <value>
        /// The type of the patch applied or being applied on the application.
        /// </value>
        ///
        public enum PatchTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PUBLISH")]
            Publish,
            [EnumMember(Value = "REFRESH")]
            Refresh,
            [EnumMember(Value = "UNPUBLISH")]
            Unpublish
        };

        /// <value>
        /// The type of the patch applied or being applied on the application.
        /// </value>
        [JsonProperty(PropertyName = "patchType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PatchTypeEnum> PatchType { get; set; }
                ///
        /// <value>
        /// Status of the patch applied or being applied on the application
        /// </value>
        ///
        public enum PatchStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "QUEUED")]
            Queued,
            [EnumMember(Value = "SUCCESSFUL")]
            Successful,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress
        };

        /// <value>
        /// Status of the patch applied or being applied on the application
        /// </value>
        [JsonProperty(PropertyName = "patchStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PatchStatusEnum> PatchStatus { get; set; }
        
        /// <value>
        /// List of dependent objects in this patch.
        /// </value>
        [JsonProperty(PropertyName = "dependentObjectMetadata")]
        public System.Collections.Generic.List<PatchObjectMetadata> DependentObjectMetadata { get; set; }
        
        /// <value>
        /// List of objects that are published or unpublished in this patch.
        /// </value>
        [JsonProperty(PropertyName = "patchObjectMetadata")]
        public System.Collections.Generic.List<PatchObjectMetadata> PatchObjectMetadata { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
        [JsonProperty(PropertyName = "metadata")]
        public ObjectMetadata Metadata { get; set; }
        
        /// <value>
        /// A key map. If provided, key is replaced with generated key. This structure provides mapping between user provided key and generated key.
        /// </value>
        [JsonProperty(PropertyName = "keyMap")]
        public System.Collections.Generic.Dictionary<string, string> KeyMap { get; set; }
        
    }
}
