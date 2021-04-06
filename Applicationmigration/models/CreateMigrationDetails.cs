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


namespace Oci.ApplicationmigrationService.Models
{
    /// <summary>
    /// While creating a migration, specify the source and the application that you want migrate.
    /// Each migration moves a single application from a specified source to a specified Oracle Cloud Infrastructure tenancy.
    /// If required, provide the credentials of the application administrator in the source environment.
    /// Application Migration uses this information to access the application, as well as discover application artifacts,
    /// such as the complete domain configuration along with data sources and other dependencies.
    /// <br/>
    /// You must also assign a name and provide a description for the migration.
    /// This helps you to identify the appropriate source environment when you have multiple sources defined.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class CreateMigrationDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment that contains the source.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// User-friendly name of the application. This will be the name of the migrated application in Oracle Cloud Infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the application that you are migrating.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the source.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceId is required.")]
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }
        
        /// <value>
        /// Name of the application that you want to migrate from the source environment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApplicationName is required.")]
        [JsonProperty(PropertyName = "applicationName")]
        public string ApplicationName { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DiscoveryDetails is required.")]
        [JsonProperty(PropertyName = "discoveryDetails")]
        public DiscoveryDetails DiscoveryDetails { get; set; }
        
        /// <value>
        /// The pre-existing database type to be used in this migration. Currently, Application migration only supports Oracle Cloud
        /// Infrastructure databases and this option is currently available only for `JAVA_CLOUD_SERVICE` and `WEBLOGIC_CLOUD_SERVICE` target instance types.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "preCreatedTargetDatabaseType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TargetDatabaseTypes> PreCreatedTargetDatabaseType { get; set; }
        
        /// <value>
        /// If set to `true`, Application Migration migrates the application resources selectively depending on the source.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSelectiveMigration")]
        public System.Nullable<bool> IsSelectiveMigration { get; set; }
        
        /// <value>
        /// Configuration required to migrate the application. In addition to the key and value, additional fields are provided
        /// to describe type type and purpose of each field. Only the value for each key is required when passing configuration to the 
        /// CreateMigration operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "serviceConfig")]
        public System.Collections.Generic.Dictionary<string, ConfigurationField> ServiceConfig { get; set; }
        
        /// <value>
        /// Configuration required to migrate the application. In addition to the key and value, additional fields are provided
        /// to describe type type and purpose of each field. Only the value for each key is required when passing configuration to the 
        /// CreateMigration operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "applicationConfig")]
        public System.Collections.Generic.Dictionary<string, ConfigurationField> ApplicationConfig { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
