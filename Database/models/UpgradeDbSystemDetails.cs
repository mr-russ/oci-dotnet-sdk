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
    /// Details for upgrading the operating system and Oracle Grid Infrastructure (GI) of a DB system.
    /// 
    /// </summary>
    public class UpgradeDbSystemDetails 
    {
                ///
        /// <value>
        /// The operating system upgrade action.
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "PRECHECK")]
            Precheck,
            [EnumMember(Value = "ROLLBACK")]
            Rollback,
            [EnumMember(Value = "UPDATE_SNAPSHOT_RETENTION_DAYS")]
            UpdateSnapshotRetentionDays,
            [EnumMember(Value = "UPGRADE")]
            Upgrade
        };

        /// <value>
        /// The operating system upgrade action.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
        
        /// <value>
        /// The retention period, in days, for the snapshot that allows you to perform a rollback of the upgrade operation. After this number of days passes, you cannot roll back the upgrade.
        /// </value>
        [JsonProperty(PropertyName = "snapshotRetentionPeriodInDays")]
        public System.Nullable<int> SnapshotRetentionPeriodInDays { get; set; }
        
        /// <value>
        /// A valid Oracle Grid Infrastructure (GI) software version.
        /// </value>
        [JsonProperty(PropertyName = "newGiVersion")]
        public string NewGiVersion { get; set; }
        
        /// <value>
        /// A valid Oracle Software (OS) version eg. Oracle Linux Server release 8
        /// </value>
        [JsonProperty(PropertyName = "newOsVersion")]
        public string NewOsVersion { get; set; }
        
        /// <value>
        /// If true, rollback time is updated even if operating system upgrade history contains errors.
        /// </value>
        [JsonProperty(PropertyName = "isSnapshotRetentionDaysForceUpdated")]
        public System.Nullable<bool> IsSnapshotRetentionDaysForceUpdated { get; set; }
        
    }
}
