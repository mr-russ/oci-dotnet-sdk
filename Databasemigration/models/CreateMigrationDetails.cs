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
    /// Create Migration resource parameters.
    /// 
    /// </summary>
    public class CreateMigrationDetails 
    {
        
        /// <value>
        /// Migration type.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MigrationTypes> Type { get; set; }
        
        /// <value>
        /// Migration Display Name
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// OCID of the compartment
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the registered ODMS Agent. Only valid for Offline Logical Migrations.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "agentId")]
        public string AgentId { get; set; }
        
        /// <value>
        /// The OCID of the Source Database Connection.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceDatabaseConnectionId is required.")]
        [JsonProperty(PropertyName = "sourceDatabaseConnectionId")]
        public string SourceDatabaseConnectionId { get; set; }
        
        /// <value>
        /// The OCID of the Source Container Database Connection. Only used for Online migrations.
        /// Only Connections of type Non-Autonomous can be used as source container databases.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceContainerDatabaseConnectionId")]
        public string SourceContainerDatabaseConnectionId { get; set; }
        
        /// <value>
        /// The OCID of the Target Database Connection.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetDatabaseConnectionId is required.")]
        [JsonProperty(PropertyName = "targetDatabaseConnectionId")]
        public string TargetDatabaseConnectionId { get; set; }
        
        [JsonProperty(PropertyName = "dataTransferMediumDetailsV2")]
        public DataTransferMediumDetailsV2 DataTransferMediumDetailsV2 { get; set; }
        
        [JsonProperty(PropertyName = "dataTransferMediumDetails")]
        public CreateDataTransferMediumDetails DataTransferMediumDetails { get; set; }
        
        [JsonProperty(PropertyName = "dumpTransferDetails")]
        public CreateDumpTransferDetails DumpTransferDetails { get; set; }
        
        [JsonProperty(PropertyName = "datapumpSettings")]
        public CreateDataPumpSettings DatapumpSettings { get; set; }
        
        [JsonProperty(PropertyName = "advisorSettings")]
        public CreateAdvisorSettings AdvisorSettings { get; set; }
        
        /// <value>
        /// Database objects to exclude from migration, cannot be specified alongside 'includeObjects'
        /// 
        /// </value>
        [JsonProperty(PropertyName = "excludeObjects")]
        public System.Collections.Generic.List<DatabaseObject> ExcludeObjects { get; set; }
        
        /// <value>
        /// Database objects to include from migration, cannot be specified alongside 'excludeObjects'
        /// 
        /// </value>
        [JsonProperty(PropertyName = "includeObjects")]
        public System.Collections.Generic.List<DatabaseObject> IncludeObjects { get; set; }
        
        /// <value>
        /// Database objects to exclude/include from migration in CSV format. The excludeObjects and includeObjects fields will be ignored if this field is not null.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "csvText")]
        public string CsvText { get; set; }
        
        [JsonProperty(PropertyName = "goldenGateDetails")]
        public CreateGoldenGateDetails GoldenGateDetails { get; set; }
        
        [JsonProperty(PropertyName = "goldenGateServiceDetails")]
        public CreateGoldenGateServiceDetails GoldenGateServiceDetails { get; set; }
        
        [JsonProperty(PropertyName = "vaultDetails")]
        public CreateVaultDetails VaultDetails { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
