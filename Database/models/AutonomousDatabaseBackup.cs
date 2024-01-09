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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// An Autonomous Database backup.
    /// 
    /// </summary>
    public class AutonomousDatabaseBackup 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Autonomous Database backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Autonomous Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AutonomousDatabaseId is required.")]
        [JsonProperty(PropertyName = "autonomousDatabaseId")]
        public string AutonomousDatabaseId { get; set; }
        
        /// <value>
        /// The user-friendly name for the backup. The name does not have to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// The type of backup.
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "INCREMENTAL")]
            Incremental,
            [EnumMember(Value = "FULL")]
            Full,
            [EnumMember(Value = "LONGTERM")]
            Longterm
        };

        /// <value>
        /// The type of backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// Indicates whether the backup is user-initiated or automatic.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsAutomatic is required.")]
        [JsonProperty(PropertyName = "isAutomatic")]
        public System.Nullable<bool> IsAutomatic { get; set; }
        
        /// <value>
        /// The date and time the backup started.
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time the backup completed.
        /// </value>
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The size of the database in terabytes at the time the backup was taken.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseSizeInTBs")]
        public System.Nullable<decimal> DatabaseSizeInTBs { get; set; }
                ///
        /// <value>
        /// The current state of the backup.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "UPDATING")]
            Updating
        };

        /// <value>
        /// The current state of the backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Indicates whether the backup can be used to restore the associated Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "isRestorable")]
        public System.Nullable<bool> IsRestorable { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the key store.
        /// </value>
        [JsonProperty(PropertyName = "keyStoreId")]
        public string KeyStoreId { get; set; }
        
        /// <value>
        /// The wallet name for Oracle Key Vault.
        /// </value>
        [JsonProperty(PropertyName = "keyStoreWalletName")]
        public string KeyStoreWalletName { get; set; }
        
        /// <value>
        /// The OCID of the key container that is used as the master encryption key in database transparent data encryption (TDE) operations.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Oracle Cloud Infrastructure [vault](https://docs.cloud.oracle.com/Content/KeyManagement/Concepts/keyoverview.htm#concepts).
        /// </value>
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }
        
        /// <value>
        /// The OCID of the key container version that is used in database transparent data encryption (TDE) operations KMS Key can have multiple key versions. If none is specified, the current key version (latest) of the Key Id is used for the operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyVersionId")]
        public string KmsKeyVersionId { get; set; }
        
        /// <value>
        /// Retention period, in days, for long-term backups
        /// </value>
        [JsonProperty(PropertyName = "retentionPeriodInDays")]
        public System.Nullable<int> RetentionPeriodInDays { get; set; }
        
        /// <value>
        /// Timestamp until when the backup will be available
        /// </value>
        [JsonProperty(PropertyName = "timeAvailableTill")]
        public System.Nullable<System.DateTime> TimeAvailableTill { get; set; }
        
        /// <value>
        /// A valid Oracle Database version for Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
        
        /// <value>
        /// The backup size in terrabytes (TB).
        /// </value>
        [JsonProperty(PropertyName = "sizeInTBs")]
        public System.Double SizeInTBs { get; set; }
        
        [JsonProperty(PropertyName = "backupDestinationDetails")]
        public BackupDestinationDetails BackupDestinationDetails { get; set; }
        
    }
}
