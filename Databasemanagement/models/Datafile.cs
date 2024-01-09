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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details of a data file.
    /// </summary>
    public class Datafile 
    {
        
        /// <value>
        /// The filename (including the path) of the data file or temp file.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The status of the file. INVALID status is used when the file number is not in use, for example, a file in a tablespace that was removed.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "INVALID")]
            Invalid,
            [EnumMember(Value = "OFFLINE")]
            Offline,
            [EnumMember(Value = "ONLINE")]
            Online,
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        };

        /// <value>
        /// The status of the file. INVALID status is used when the file number is not in use, for example, a file in a tablespace that was removed.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
                ///
        /// <value>
        /// The online status of the file.
        /// </value>
        ///
        public enum OnlineStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SYSOFF")]
            Sysoff,
            [EnumMember(Value = "SYSTEM")]
            System,
            [EnumMember(Value = "OFFLINE")]
            Offline,
            [EnumMember(Value = "ONLINE")]
            Online,
            [EnumMember(Value = "RECOVER")]
            Recover
        };

        /// <value>
        /// The online status of the file.
        /// </value>
        [JsonProperty(PropertyName = "onlineStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OnlineStatusEnum> OnlineStatus { get; set; }
        
        /// <value>
        /// Indicates whether the data file is auto-extensible.
        /// </value>
        [JsonProperty(PropertyName = "isAutoExtensible")]
        public System.Nullable<bool> IsAutoExtensible { get; set; }
                ///
        /// <value>
        /// The lost write protection status of the file.
        /// </value>
        ///
        public enum LostWriteProtectEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "PROTECT_OFF")]
            ProtectOff,
            [EnumMember(Value = "SUSPEND")]
            Suspend
        };

        /// <value>
        /// The lost write protection status of the file.
        /// </value>
        [JsonProperty(PropertyName = "lostWriteProtect")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LostWriteProtectEnum> LostWriteProtect { get; set; }
                ///
        /// <value>
        /// Type of tablespace this file belongs to. If it's for a shared tablespace, for a local temporary tablespace for RIM (read-only) instances, or for local temporary tablespace for all instance types.
        /// </value>
        ///
        public enum SharedEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SHARED")]
            Shared,
            [EnumMember(Value = "LOCAL_FOR_RIM")]
            LocalForRim,
            [EnumMember(Value = "LOCAL_FOR_ALL")]
            LocalForAll
        };

        /// <value>
        /// Type of tablespace this file belongs to. If it's for a shared tablespace, for a local temporary tablespace for RIM (read-only) instances, or for local temporary tablespace for all instance types.
        /// </value>
        [JsonProperty(PropertyName = "shared")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SharedEnum> Shared { get; set; }
        
        /// <value>
        /// Instance ID of the instance to which the temp file belongs. This column has a NULL value for temp files that belong to shared tablespaces.
        /// </value>
        [JsonProperty(PropertyName = "instanceId")]
        public System.Nullable<decimal> InstanceId { get; set; }
        
        /// <value>
        /// The maximum file size in KB.
        /// </value>
        [JsonProperty(PropertyName = "maxSizeKB")]
        public System.Nullable<decimal> MaxSizeKB { get; set; }
        
        /// <value>
        /// The allocated file size in KB.
        /// </value>
        [JsonProperty(PropertyName = "allocatedSizeKB")]
        public System.Nullable<decimal> AllocatedSizeKB { get; set; }
        
        /// <value>
        /// The size of the file available for user data in KB. The actual size of the file minus the USER_BYTES value is used to store file-related metadata.
        /// </value>
        [JsonProperty(PropertyName = "userSizeKB")]
        public System.Nullable<decimal> UserSizeKB { get; set; }
        
        /// <value>
        /// The number of blocks used as auto-extension increment.
        /// </value>
        [JsonProperty(PropertyName = "incrementBy")]
        public System.Nullable<decimal> IncrementBy { get; set; }
        
        /// <value>
        /// The free space available in the data file in KB.
        /// </value>
        [JsonProperty(PropertyName = "freeSpaceKB")]
        public System.Nullable<decimal> FreeSpaceKB { get; set; }
        
        /// <value>
        /// The total space used in the data file in KB.
        /// </value>
        [JsonProperty(PropertyName = "usedSpaceKB")]
        public System.Nullable<decimal> UsedSpaceKB { get; set; }
        
        /// <value>
        /// The percentage of used space out of the maximum available space in the file.
        /// </value>
        [JsonProperty(PropertyName = "usedPercentAvailable")]
        public System.Double UsedPercentAvailable { get; set; }
        
        /// <value>
        /// The percentage of used space out of the total allocated space in the file.
        /// </value>
        [JsonProperty(PropertyName = "usedPercentAllocated")]
        public System.Double UsedPercentAllocated { get; set; }
        
    }
}
