/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// The details specific to the SQL job request.
    /// </summary>
    public class CreateSqlJobDetails : CreateJobDetails
    {
        
        /// <value>
        /// The SQL text to be executed as part of the job.
        /// </value>
        [JsonProperty(PropertyName = "sqlText")]
        public string SqlText { get; set; }
        
        [JsonProperty(PropertyName = "sqlType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SqlJob.SqlTypeEnum> SqlType { get; set; }
        
        /// <value>
        /// The SQL operation type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationType is required.")]
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SqlJob.OperationTypeEnum> OperationType { get; set; }
        
        /// <value>
        /// The database user name used to execute the SQL job. If the job is being executed on a
        /// Managed Database Group, then the user name should exist on all the databases in the
        /// group with the same password.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
        
        /// <value>
        /// The password for the database user name used to execute the SQL job.
        /// </value>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <value>
        /// The role of the database user. Indicates whether the database user is a normal user or sysdba.
        /// </value>
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SqlJob.RoleEnum> Role { get; set; }
        
        [JsonProperty(PropertyName = "jobType")]
        private readonly string jobType = "SQL";
    }
}
