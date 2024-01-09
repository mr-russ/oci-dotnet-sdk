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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Configuration parameters defined for external databases.
    /// </summary>
    public class DBExternalProperties : DatabaseConfigurationMetricGroup
    {
        
        /// <value>
        /// Name of the database.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Archive log mode.
        /// </value>
        [JsonProperty(PropertyName = "logMode")]
        public string LogMode { get; set; }
        
        /// <value>
        /// Indicates if it is a CDB or not. This would be 'yes' or 'no'.
        /// </value>
        [JsonProperty(PropertyName = "cdb")]
        public string Cdb { get; set; }
        
        /// <value>
        /// Open mode information.
        /// </value>
        [JsonProperty(PropertyName = "openMode")]
        public string OpenMode { get; set; }
        
        /// <value>
        /// Current role of the database.
        /// </value>
        [JsonProperty(PropertyName = "databaseRole")]
        public string DatabaseRole { get; set; }
        
        /// <value>
        /// Data protection policy.
        /// </value>
        [JsonProperty(PropertyName = "guardStatus")]
        public string GuardStatus { get; set; }
        
        /// <value>
        /// Platform name of the database, OS with architecture.
        /// </value>
        [JsonProperty(PropertyName = "platformName")]
        public string PlatformName { get; set; }
        
        /// <value>
        /// Type of control file.
        /// </value>
        [JsonProperty(PropertyName = "controlFileType")]
        public string ControlFileType { get; set; }
        
        /// <value>
        /// Indicates whether switchover is allowed.
        /// </value>
        [JsonProperty(PropertyName = "switchoverStatus")]
        public string SwitchoverStatus { get; set; }
        
        /// <value>
        /// Creation time.
        /// </value>
        [JsonProperty(PropertyName = "created")]
        public System.Nullable<System.DateTime> Created { get; set; }
        
        [JsonProperty(PropertyName = "metricName")]
        private readonly string metricName = "DB_EXTERNAL_PROPERTIES";
    }
}
