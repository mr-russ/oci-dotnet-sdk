/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// Parameters for converting Refreshable Clone Pluggable Database into Regular Pluggable Database.
    /// 
    /// </summary>
    public class ConvertToRegularPluggableDatabaseDetails 
    {
        
        /// <value>
        /// Indicates whether to take Pluggable Database Backup after the operation.
        /// </value>
        [JsonProperty(PropertyName = "shouldCreatePdbBackup")]
        public System.Nullable<bool> ShouldCreatePdbBackup { get; set; }
        
        /// <value>
        /// The DB system administrator password of the Container Database.
        /// </value>
        [JsonProperty(PropertyName = "containerDatabaseAdminPassword")]
        public string ContainerDatabaseAdminPassword { get; set; }
        
        /// <value>
        /// The existing TDE wallet password of the Container Database.
        /// </value>
        [JsonProperty(PropertyName = "tdeWalletPassword")]
        public string TdeWalletPassword { get; set; }
        
    }
}
