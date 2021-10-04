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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// A container for your OCI GoldenGate resources, such as the OCI GoldenGate deployment console.
    /// 
    /// </summary>
    public class Deployment 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the deployment being referenced.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// An object's Display Name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Metadata about this specific object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment being referenced.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the backup being referenced.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "deploymentBackupId")]
        public string DeploymentBackupId { get; set; }
        
        /// <value>
        /// The time the resource was created. The format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the resource was last updated. The format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Possible lifecycle states.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Possible GGS lifecycle sub-states.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleSubState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleSubState> LifecycleSubState { get; set; }
        
        /// <value>
        /// Describes the object's current state in detail. For example, it can be used to provide actionable information for a resource in a Failed state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// A simple key-value pair that is applied without any predefined name, type, or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Tags defined for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// True if all of the aggregate resources are working correctly.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHealthy")]
        public System.Nullable<bool> IsHealthy { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet being referenced.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// A three-label Fully Qualified Domain Name (FQDN) for a resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; set; }
        
        /// <value>
        /// The Oracle license model that applies to a Deployment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LicenseModel is required.")]
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModel> LicenseModel { get; set; }
        
        /// <value>
        /// The Minimum number of OCPUs to be made available for this Deployment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuCoreCount is required.")]
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// Indicates if auto scaling is enabled for the Deployment's CPU core count.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsAutoScalingEnabled is required.")]
        [JsonProperty(PropertyName = "isAutoScalingEnabled")]
        public System.Nullable<bool> IsAutoScalingEnabled { get; set; }
        
        /// <value>
        /// An array of [Network Security Group](https://docs.cloud.oracle.com/Content/Network/Concepts/networksecuritygroups.htm) OCIDs used to define network access for a deployment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// True if this object is publicly available.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isPublic")]
        public System.Nullable<bool> IsPublic { get; set; }
        
        /// <value>
        /// The public IP address representing the access point for the Deployment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "publicIpAddress")]
        public string PublicIpAddress { get; set; }
        
        /// <value>
        /// The private IP address in the customer's VCN representing the access point for the associated endpoint service in the GoldenGate service VCN.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateIpAddress")]
        public string PrivateIpAddress { get; set; }
        
        /// <value>
        /// The URL of a resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "deploymentUrl")]
        public string DeploymentUrl { get; set; }
        
        /// <value>
        /// The system tags associated with this resource, if any. The system tags are set by Oracle Cloud Infrastructure services. Each key is predefined and scoped to namespaces.  For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {orcl-cloud: {free-tier-retain: true}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// Indicates if the resource is the the latest available version.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isLatestVersion")]
        public System.Nullable<bool> IsLatestVersion { get; set; }
        
        /// <value>
        /// The date the existing version in use will no longer be considered as usable and an upgrade will be required.  This date is typically 6 months after the version was released for use by GGS.  The format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpgradeRequired")]
        public System.Nullable<System.DateTime> TimeUpgradeRequired { get; set; }
        
        /// <value>
        /// The deployment type.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentType is required.")]
        [JsonProperty(PropertyName = "deploymentType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DeploymentType> DeploymentType { get; set; }
        
        [JsonProperty(PropertyName = "oggData")]
        public OggDeployment OggData { get; set; }
        
    }
}
