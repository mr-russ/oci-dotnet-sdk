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
    /// Sql information in the Sql tuning set.
    /// </summary>
    public class SqlInSqlTuningSet 
    {
        
        /// <value>
        /// The unique Sql identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlId is required.")]
        [JsonProperty(PropertyName = "sqlId")]
        public string SqlId { get; set; }
        
        /// <value>
        /// Sql text.
        /// </value>
        [JsonProperty(PropertyName = "sqlText")]
        public string SqlText { get; set; }
        
        /// <value>
        /// The unique container database identifier.
        /// </value>
        [JsonProperty(PropertyName = "containerDatabaseId")]
        public System.Nullable<long> ContainerDatabaseId { get; set; }
        
        /// <value>
        /// Plan hash value of the Sql statement.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanHashValue is required.")]
        [JsonProperty(PropertyName = "planHashValue")]
        public System.Nullable<long> PlanHashValue { get; set; }
        
        /// <value>
        /// The schema name of the Sql.
        /// </value>
        [JsonProperty(PropertyName = "schema")]
        public string Schema { get; set; }
        
        /// <value>
        /// The module of the Sql.
        /// </value>
        [JsonProperty(PropertyName = "module")]
        public string Module { get; set; }
        
        /// <value>
        /// A list of the Sqls associated with the Sql tuning set.
        /// </value>
        [JsonProperty(PropertyName = "metrics")]
        public System.Collections.Generic.List<SqlMetrics> Metrics { get; set; }
        
    }
}
