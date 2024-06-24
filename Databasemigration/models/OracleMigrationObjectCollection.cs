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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Database objects to migrate.
    /// </summary>
    public class OracleMigrationObjectCollection : MigrationObjectCollection
    {
        
        /// <value>
        /// Database objects to exclude/include from migration
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Items is required.")]
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<OracleDatabaseObjectSummary> Items { get; set; }
        
        /// <value>
        /// Specifies the database objects to be excluded from the migration in bulk.
        /// The definition accepts input in a CSV format, newline separated for each entry.
        /// More details can be found in the documentation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bulkIncludeExcludeData")]
        public string BulkIncludeExcludeData { get; set; }
        
        [JsonProperty(PropertyName = "databaseCombination")]
        private readonly string databaseCombination = "ORACLE";
    }
}
