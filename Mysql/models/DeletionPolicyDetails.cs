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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// The Deletion policy for the DB System.
    /// </summary>
    public class DeletionPolicyDetails 
    {
                ///
        /// <value>
        /// Specifies if any automatic backups created for a DB System should be retained or deleted when the DB System is deleted.
        /// 
        /// </value>
        ///
        public enum AutomaticBackupRetentionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DELETE")]
            Delete,
            [EnumMember(Value = "RETAIN")]
            Retain
        };

        /// <value>
        /// Specifies if any automatic backups created for a DB System should be retained or deleted when the DB System is deleted.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AutomaticBackupRetention is required.")]
        [JsonProperty(PropertyName = "automaticBackupRetention")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AutomaticBackupRetentionEnum> AutomaticBackupRetention { get; set; }
                ///
        /// <value>
        /// Specifies whether or not a backup is taken when the DB System is deleted.
        ///   REQUIRE_FINAL_BACKUP: a backup is taken if the DB System is deleted.
        ///   SKIP_FINAL_BACKUP: a backup is not taken if the DB System is deleted.
        /// 
        /// </value>
        ///
        public enum FinalBackupEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SKIP_FINAL_BACKUP")]
            SkipFinalBackup,
            [EnumMember(Value = "REQUIRE_FINAL_BACKUP")]
            RequireFinalBackup
        };

        /// <value>
        /// Specifies whether or not a backup is taken when the DB System is deleted.
        ///   REQUIRE_FINAL_BACKUP: a backup is taken if the DB System is deleted.
        ///   SKIP_FINAL_BACKUP: a backup is not taken if the DB System is deleted.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FinalBackup is required.")]
        [JsonProperty(PropertyName = "finalBackup")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<FinalBackupEnum> FinalBackup { get; set; }
        
        /// <value>
        /// Specifies whether the DB System can be deleted. Set to true to prevent deletion, false (default) to allow.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsDeleteProtected is required.")]
        [JsonProperty(PropertyName = "isDeleteProtected")]
        public System.Nullable<bool> IsDeleteProtected { get; set; }
        
    }
}
