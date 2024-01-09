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
    /// The summary information of a SQL tuning set.
    /// </summary>
    public class SqlTuningSetSummary 
    {
        
        /// <value>
        /// The name of the SQL tuning set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The owner of the SQL tuning set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Owner is required.")]
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }
        
        /// <value>
        /// The description of the SQL tuning set.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The number of SQL statements in the SQL tuning set.
        /// </value>
        [JsonProperty(PropertyName = "statementCounts")]
        public System.Nullable<int> StatementCounts { get; set; }
        
        /// <value>
        /// The unique Sql tuning set identifier. This is not OCID.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public System.Nullable<int> Id { get; set; }
        
        /// <value>
        /// The created time of the Sql tuning set.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Last modified time of the Sql tuning set.
        /// </value>
        [JsonProperty(PropertyName = "timeLastModified")]
        public System.Nullable<System.DateTime> TimeLastModified { get; set; }
        
        /// <value>
        /// Current status of the Sql tuning set.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SqlTuningSetStatusTypes> Status { get; set; }
        
        /// <value>
        /// Name of the Sql tuning set scheduler job.
        /// </value>
        [JsonProperty(PropertyName = "scheduledJobName")]
        public string ScheduledJobName { get; set; }
        
        /// <value>
        /// Latest execution error of the plsql that was submitted as a scheduler job.
        /// </value>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
        
    }
}
