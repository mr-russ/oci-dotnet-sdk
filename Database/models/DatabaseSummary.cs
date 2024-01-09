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
    /// An Oracle Database on a bare metal or virtual machine DB system. For more information, see [Bare Metal and Virtual Machine DB Systems](https://docs.cloud.oracle.com/Content/Database/Concepts/overview.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized, talk to an administrator. If you're an administrator who needs to write policies to give users access, see [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class DatabaseSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the database.
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
        /// The character set for the database.
        /// </value>
        [JsonProperty(PropertyName = "characterSet")]
        public string CharacterSet { get; set; }
        
        /// <value>
        /// The national character set for the database.
        /// </value>
        [JsonProperty(PropertyName = "ncharacterSet")]
        public string NcharacterSet { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Database Home.
        /// </value>
        [JsonProperty(PropertyName = "dbHomeId")]
        public string DbHomeId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the DB system.
        /// </value>
        [JsonProperty(PropertyName = "dbSystemId")]
        public string DbSystemId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VM cluster.
        /// </value>
        [JsonProperty(PropertyName = "vmClusterId")]
        public string VmClusterId { get; set; }
        
        /// <value>
        /// The database name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbName is required.")]
        [JsonProperty(PropertyName = "dbName")]
        public string DbName { get; set; }
        
        /// <value>
        /// The name of the pluggable database. The name must begin with an alphabetic character and can contain a maximum of thirty alphanumeric characters. Special characters are not permitted. Pluggable database should not be same as database name.
        /// </value>
        [JsonProperty(PropertyName = "pdbName")]
        public string PdbName { get; set; }
        
        /// <value>
        /// **Deprecated.** The dbWorkload field has been deprecated for Exadata Database Service on Dedicated Infrastructure, Exadata Database Service on Cloud@Customer, and Base Database Service.
        /// Support for this attribute will end in November 2023. You may choose to update your custom scripts to exclude the dbWorkload attribute. After November 2023 if you pass a value to the dbWorkload attribute, it will be ignored.
        /// <br/>
        /// The database workload type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbWorkload")]
        public string DbWorkload { get; set; }
        
        /// <value>
        /// A system-generated name for the database to ensure uniqueness within an Oracle Data Guard group (a primary database and its standby databases). The unique name cannot be changed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbUniqueName is required.")]
        [JsonProperty(PropertyName = "dbUniqueName")]
        public string DbUniqueName { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
                ///
        /// <value>
        /// The current state of the database.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "BACKUP_IN_PROGRESS")]
            BackupInProgress,
            [EnumMember(Value = "UPGRADING")]
            Upgrading,
            [EnumMember(Value = "CONVERTING")]
            Converting,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "RESTORE_FAILED")]
            RestoreFailed,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the database was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time when the latest database backup was created.
        /// </value>
        [JsonProperty(PropertyName = "lastBackupTimestamp")]
        public System.Nullable<System.DateTime> LastBackupTimestamp { get; set; }
        
        /// <value>
        /// The duration when the latest database backup created.
        /// </value>
        [JsonProperty(PropertyName = "lastBackupDurationInSeconds")]
        public System.Nullable<int> LastBackupDurationInSeconds { get; set; }
        
        /// <value>
        /// The date and time when the latest database backup failed.
        /// </value>
        [JsonProperty(PropertyName = "lastFailedBackupTimestamp")]
        public System.Nullable<System.DateTime> LastFailedBackupTimestamp { get; set; }
        
        [JsonProperty(PropertyName = "dbBackupConfig")]
        public DbBackupConfig DbBackupConfig { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The Connection strings used to connect to the Oracle Database.
        /// </value>
        [JsonProperty(PropertyName = "connectionStrings")]
        public DatabaseConnectionStrings ConnectionStrings { get; set; }
        
        /// <value>
        /// The OCID of the key container that is used as the master encryption key in database transparent data encryption (TDE) operations.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        /// <value>
        /// The OCID of the key container version that is used in database transparent data encryption (TDE) operations KMS Key can have multiple key versions. If none is specified, the current key version (latest) of the Key Id is used for the operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyVersionId")]
        public string KmsKeyVersionId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Oracle Cloud Infrastructure [vault](https://docs.cloud.oracle.com/Content/KeyManagement/Concepts/keyoverview.htm#concepts).
        /// </value>
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }
        
        /// <value>
        /// Point in time recovery timeStamp of the source database at which cloned database system is cloned from the source database system, as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339)
        /// </value>
        [JsonProperty(PropertyName = "sourceDatabasePointInTimeRecoveryTimestamp")]
        public System.Nullable<System.DateTime> SourceDatabasePointInTimeRecoveryTimestamp { get; set; }
        
        /// <value>
        /// The database software image [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)
        /// </value>
        [JsonProperty(PropertyName = "databaseSoftwareImageId")]
        public string DatabaseSoftwareImageId { get; set; }
        
        /// <value>
        /// True if the database is a container database.
        /// </value>
        [JsonProperty(PropertyName = "isCdb")]
        public System.Nullable<bool> IsCdb { get; set; }
        
        [JsonProperty(PropertyName = "databaseManagementConfig")]
        public CloudDatabaseManagementConfig DatabaseManagementConfig { get; set; }
        
        /// <value>
        /// Specifies a prefix for the `Oracle SID` of the database to be created.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sidPrefix")]
        public string SidPrefix { get; set; }
        
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
        
    }
}
