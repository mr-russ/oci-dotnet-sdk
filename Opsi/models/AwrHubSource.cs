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
    /// Awr hub source object
    /// </summary>
    public class AwrHubSource 
    {
        
        /// <value>
        /// The name of the Awr Hub source database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// AWR Hub OCID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AwrHubId is required.")]
        [JsonProperty(PropertyName = "awrHubId")]
        public string AwrHubId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// source type of the database
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AwrHubSourceType> Type { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Awr Hub source database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The shorted string of the Awr Hub source database identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AwrHubOpsiSourceId is required.")]
        [JsonProperty(PropertyName = "awrHubOpsiSourceId")]
        public string AwrHubOpsiSourceId { get; set; }
        
        /// <value>
        /// Opsi Mailbox URL based on the Awr Hub and Awr Hub source.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceMailBoxUrl is required.")]
        [JsonProperty(PropertyName = "sourceMailBoxUrl")]
        public string SourceMailBoxUrl { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database id.
        /// </value>
        [JsonProperty(PropertyName = "associatedResourceId")]
        public string AssociatedResourceId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database id.
        /// </value>
        [JsonProperty(PropertyName = "associatedOpsiId")]
        public string AssociatedOpsiId { get; set; }
        
        /// <value>
        /// The time at which the resource was first created. An RFC3339 formatted datetime string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time at which the resource was last updated. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
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
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// This is `true` if the source databse is registered with a Awr Hub, otherwise `false`
        /// </value>
        [JsonProperty(PropertyName = "isRegisteredWithAwrHub")]
        public System.Nullable<bool> IsRegisteredWithAwrHub { get; set; }
        
        /// <value>
        /// DatabaseId of the Source database for which AWR Data will be uploaded to AWR Hub.
        /// </value>
        [JsonProperty(PropertyName = "awrSourceDatabaseId")]
        public string AwrSourceDatabaseId { get; set; }
        
        /// <value>
        /// The minimum snapshot identifier of the source database for which AWR data is uploaded to AWR Hub.
        /// </value>
        [JsonProperty(PropertyName = "minSnapshotIdentifier")]
        public System.Nullable<decimal> MinSnapshotIdentifier { get; set; }
        
        /// <value>
        /// The maximum snapshot identifier of the source database for which AWR data is uploaded to AWR Hub.
        /// </value>
        [JsonProperty(PropertyName = "maxSnapshotIdentifier")]
        public System.Nullable<decimal> MaxSnapshotIdentifier { get; set; }
        
        /// <value>
        /// The time at which the earliest snapshot was generated in the source database for which data is uploaded to AWR Hub. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeFirstSnapshotGenerated")]
        public System.Nullable<System.DateTime> TimeFirstSnapshotGenerated { get; set; }
        
        /// <value>
        /// The time at which the latest snapshot was generated in the source database for which data is uploaded to AWR Hub. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeLastSnapshotGenerated")]
        public System.Nullable<System.DateTime> TimeLastSnapshotGenerated { get; set; }
        
        /// <value>
        /// Number of hours since last AWR snapshots import happened from the Source database.
        /// </value>
        [JsonProperty(PropertyName = "hoursSinceLastImport")]
        public System.Double HoursSinceLastImport { get; set; }
        
        /// <value>
        /// the current state of the source database
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AwrHubSourceLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Indicates the status of a source database in Operations Insights
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AwrHubSourceStatus> Status { get; set; }
        
    }
}
