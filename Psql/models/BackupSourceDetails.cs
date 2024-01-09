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


namespace Oci.PsqlService.Models
{
    /// <summary>
    /// Restoring to a new database system from the backup. 
    /// The database system details that are part of the CreateDbSystem request are not required, but if present will override the details from the backup's database system snapshot.
    /// 
    /// </summary>
    public class BackupSourceDetails : SourceDetails
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the database system backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackupId is required.")]
        [JsonProperty(PropertyName = "backupId")]
        public string BackupId { get; set; }
        
        /// <value>
        /// Deprecated. Don't use.
        /// </value>
        [JsonProperty(PropertyName = "isHavingRestoreConfigOverrides")]
        public System.Nullable<bool> IsHavingRestoreConfigOverrides { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "BACKUP";
    }
}
