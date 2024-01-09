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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// A point-in-time copy of a volume that can then be used to create a new block volume
    /// or recover a block volume. For more information, see
    /// [Overview of Cloud Volume Storage](https://docs.cloud.oracle.com/iaas/Content/Block/Concepts/overview.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/iaas/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you
    /// supply string values using the API.
    /// 
    /// </summary>
    public class VolumeBackup 
    {
        
        /// <value>
        /// The OCID of the compartment that contains the volume backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The date and time the volume backup will expire and be automatically deleted.
        /// Format defined by [RFC3339](https://tools.ietf.org/html/rfc3339). This parameter will always be present for backups that
        /// were created automatically by a scheduled-backup policy. For manually created backups,
        /// it will be absent, signifying that there is no expiration time and the backup will
        /// last forever until manually deleted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "expirationTime")]
        public System.Nullable<System.DateTime> ExpirationTime { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The OCID of the volume backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the Vault service key which is the master encryption key for the volume backup.
        /// For more information about the Vault service and encryption keys, see
        /// [Overview of Vault service](https://docs.cloud.oracle.com/iaas/Content/KeyManagement/Concepts/keyoverview.htm) and
        /// [Using Keys](https://docs.cloud.oracle.com/iaas/Content/KeyManagement/Tasks/usingkeys.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
                ///
        /// <value>
        /// The current state of a volume backup.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "FAULTY")]
            Faulty,
            [EnumMember(Value = "REQUEST_RECEIVED")]
            RequestReceived
        };

        /// <value>
        /// The current state of a volume backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The size of the volume, in GBs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sizeInGBs")]
        public System.Nullable<long> SizeInGBs { get; set; }
        
        /// <value>
        /// The size of the volume in MBs. The value must be a multiple of 1024.
        /// This field is deprecated. Please use sizeInGBs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sizeInMBs")]
        public System.Nullable<long> SizeInMBs { get; set; }
                ///
        /// <value>
        /// Specifies whether the backup was created manually, or via scheduled backup policy.
        /// 
        /// </value>
        ///
        public enum SourceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MANUAL")]
            Manual,
            [EnumMember(Value = "SCHEDULED")]
            Scheduled
        };

        /// <value>
        /// Specifies whether the backup was created manually, or via scheduled backup policy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SourceTypeEnum> SourceType { get; set; }
        
        /// <value>
        /// The OCID of the source volume backup.
        /// </value>
        [JsonProperty(PropertyName = "sourceVolumeBackupId")]
        public string SourceVolumeBackupId { get; set; }
        
        /// <value>
        /// The date and time the volume backup was created. This is the time the actual point-in-time image
        /// of the volume data was taken. Format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the request to create the volume backup was received. Format defined by [RFC3339]https://tools.ietf.org/html/rfc3339.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeRequestReceived")]
        public System.Nullable<System.DateTime> TimeRequestReceived { get; set; }
                ///
        /// <value>
        /// The type of a volume backup.
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "FULL")]
            Full,
            [EnumMember(Value = "INCREMENTAL")]
            Incremental
        };

        /// <value>
        /// The type of a volume backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The size used by the backup, in GBs. It is typically smaller than sizeInGBs, depending on the space
        /// consumed on the volume and whether the backup is full or incremental.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "uniqueSizeInGBs")]
        public System.Nullable<long> UniqueSizeInGBs { get; set; }
        
        /// <value>
        /// The size used by the backup, in MBs. It is typically smaller than sizeInMBs, depending on the space
        /// consumed on the volume and whether the backup is full or incremental.
        /// This field is deprecated. Please use uniqueSizeInGBs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "uniqueSizeInMbs")]
        public System.Nullable<long> UniqueSizeInMbs { get; set; }
        
        /// <value>
        /// The OCID of the volume.
        /// </value>
        [JsonProperty(PropertyName = "volumeId")]
        public string VolumeId { get; set; }
        
    }
}
